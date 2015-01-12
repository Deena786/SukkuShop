﻿using System;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using SukkuShop.Identity;
using SukkuShop.Models;

namespace SukkuShop.Controllers
{
    [Authorize]
    public partial class KontoController : Controller
    {
        private readonly ApplicationUserManager _userManager;
        private readonly ApplicationSignInManager _signInManager;
        private readonly IAuthenticationManager _authenticationManager;
        private readonly ApplicationDbContext _dbContext;

        public KontoController(ApplicationUserManager userManager, ApplicationSignInManager signInManager,
            IAuthenticationManager authenticationManager, ApplicationDbContext dbContext)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _authenticationManager = authenticationManager;
            _dbContext = dbContext;
        }

        [AllowAnonymous]
        public virtual async Task<ActionResult> ResendActivationEmail(string email)
        {
            var userid = _userManager.FindByEmail(email).Id;
            var code = await _userManager.GenerateEmailConfirmationTokenAsync(userid);
            var callbackUrl = Url.Action(MVC.Konto.Aktywacja(userid, code), Request.Url.Scheme);
            ActivationMailBuilder(callbackUrl, email);
            return new EmptyResult();
        }


        // GET: /Account/Login
        [AllowAnonymous]
        public virtual ActionResult Zaloguj(string returnUrl)
        {
            if (User.Identity.IsAuthenticated)
                return RedirectToAction(MVC.Home.Index());
            ViewBag.ReturnUrl = returnUrl;
            return View();
        }


        // POST: /Account/Login
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public virtual async Task<ActionResult> Zaloguj(LoginViewModel model, string returnUrl)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            if (!_userManager.IsEmailConfirmed(_userManager.FindByEmail(model.Email).Id))
            {
                return View("KontoNieaktywne", (object) model.Email);
            }
            var result =
                await _signInManager.PasswordSignInAsync(model.Email, model.PasswordLogin, model.RememberMe, false);
            switch (result)
            {
                case SignInStatus.Success:
                    var user = await _userManager.FindByEmailAsync(model.Email);
                    Session["username"] = user.Name;
                    return RedirectToLocal(returnUrl);
                case SignInStatus.LockedOut:
                    return View(MVC.Shared.Views.Blokada);
                default:
                    ModelState.AddModelError("", "Nieprawidłowa nazwa użytkownika lub hasło");
                    return View(model);
            }
        }


        // GET: /Account/Register
        [AllowAnonymous]
        public virtual ActionResult Zarejestruj()
        {
            if (User.Identity.IsAuthenticated)
                return RedirectToAction(MVC.Home.Index());
            return View();
        }

        // POST: /Account/Register
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public virtual async Task<ActionResult> Zarejestruj(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = new ApplicationUser
                {
                    UserName = model.Email,
                    Email = model.Email,
                    KontoFirmowe = model.KontoFirmowe
                };
                var result = await _userManager.CreateAsync(user, model.Password);
                if (result.Succeeded)
                {
                    var code = await _userManager.GenerateEmailConfirmationTokenAsync(user.Id);
                    var callbackUrl = Url.Action(MVC.Konto.Aktywacja(user.Id, code), Request.Url.Scheme);
                    ActivationMailBuilder(callbackUrl, model.Email);
                    return View(MVC.Konto.Views.RegisterSuccess);
                }
                ModelState.AddModelError("", "Istnieje już użytkownik o podanym adresie Email.");
            }
            return View(model);
        }


        //
        // GET: /Account/ConfirmEmail
        [AllowAnonymous]
        public virtual async Task<ActionResult> Aktywacja(int userId, string code)
        {
            if (code == null)
            {
                return View(MVC.Shared.Views._Blad);
            }
            var result = await _userManager.ConfirmEmailAsync(userId, code);
            return View(result.Succeeded ? MVC.Konto.Views.KontoAktywne : MVC.Shared.Views._Blad);
        }

        //
        // GET: /Account/ForgotPassword
        [AllowAnonymous]
        public virtual ActionResult ZapomnianeHaslo()
        {
            var model = new ForgotPasswordViewModel();
            return View(model);
        }

        //
        // POST: /Account/ForgotPassword
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public virtual async Task<ActionResult> ZapomnianeHaslo(ForgotPasswordViewModel model)
        {
            if (ModelState.IsValid)
            {
                model.result = "Sent";
                var user = await _userManager.FindByEmailAsync(model.Email);
                if (user == null)
                {
                    model.result = "NoUser";
                    return PartialView("_ZapomnianeHasloPartial", model);
                }
                var code = await _userManager.GeneratePasswordResetTokenAsync(user.Id);
                var callbackUrl = Url.Action("ResetujHaslo", "Konto", new {userId = user.Id, code}, Request.Url.Scheme);
                ResetPasswordMailBuilder(callbackUrl, model.Email);
                return PartialView("_ZapomnianeHasloPartial", model);
            }
            return PartialView("_ZapomnianeHasloPartial", model);
        }

        //
        // GET: /Account/ResetPassword
        [AllowAnonymous]
        public virtual ActionResult ResetujHaslo(string code)
        {
            var model = new ResetPasswordViewModel
            {
                Code = code
            };
            return code == null ? View(MVC.Error.Views.Error) : View(model);
        }

        //
        // POST: /Account/ResetPassword
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public virtual async Task<ActionResult> ResetujHaslo(ResetPasswordViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return PartialView("_ResetujHasloPartial", model);
            }
            var user = await _userManager.FindByNameAsync(model.Email);
            if (user == null)
            {
                model.result = "NoUser";
                return PartialView("_ResetujHasloPartial", model);
            }
            var result = await _userManager.ResetPasswordAsync(user.Id, model.Code, model.Password);
            if (result.Succeeded)
            {
                model.result = "Sent";
                return PartialView("_ResetujHasloPartial", model);
            }
            AddErrors(result);
            return PartialView("_ResetujHasloPartial", model);
        }

        //
        // POST: /Account/LogOff
        [HttpPost]
        [ValidateAntiForgeryToken]
        public virtual ActionResult Wyloguj()
        {
            _authenticationManager.SignOut();
            Session["username"] = null;
            return RedirectToAction(MVC.Home.Index());
        }


        ////////////MANAGE//////////////

        // GET: DaneOsobowe main view
        [HttpGet]
        [Authorize]
        public virtual ActionResult DaneOsobowe()
        {
            var user = _userManager.FindById(User.Identity.GetUserId<int>());
            return View("Index", user.KontoFirmowe);
        }


        // GET: Zmień hasło
        [HttpGet]
        [Authorize]
        public virtual ActionResult ZmienHaslo()
        {
            var model = new ChangePasswordViewModel();
            return PartialView("_ChangePassword", model);
        }

        // POST: Zmień hasło
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public virtual ActionResult ZmienHaslo(ChangePasswordViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return PartialView("_ChangePassword", model);
            }
            var result = _userManager.ChangePassword(int.Parse(User.Identity.GetUserId()), model.OldPassword,
                model.NewPassword);
            if (result.Succeeded)
            {
                var user = _userManager.FindById(int.Parse(User.Identity.GetUserId()));
                if (user != null)
                {
                    _signInManager.SignIn(user, false, false);
                }
                model.Success = true;
                return PartialView("_ChangePassword", model);
            }
            model.Success = false;
            return PartialView("_ChangePassword", model);
        }

        //GET: User data - konto osobiste
        [HttpGet]
        [Authorize]
        public virtual ActionResult ChangeUserInfoViewModel()
        {
            var user = _userManager.FindById(User.Identity.GetUserId<int>());
            var model = new ChangeUserInfoViewModel
            {
                City = user.City ?? "Nie podano",
                Email = user.Email,
                LastName = user.LastName ?? "Nie podano",
                Name = user.Name ?? "Nie podano",
                Number = user.Number ?? "Nie podano",
                Phone = user.PhoneNumber ?? "Nie podano",
                PostalCode = user.PostalCode ?? "Nie podano",
                Street = user.Street ?? "Nie podano",
                Success = null
            };
            return PartialView("_ChangeUserInfoViewModel", model);
        }

        //POST: change User data - konto osobiste
        [HttpPost]
        [Authorize]
        public virtual ActionResult ChangeUserInfoViewModel(ChangeUserInfoViewModel model)
        {
            var userExists = _userManager.FindByEmail(model.Email);
            if (userExists != null)
                if (userExists.Id != User.Identity.GetUserId<int>())
                    ModelState.AddModelError("Email", "Adres email jest używany!");
            if (ModelState.IsValid)
            {
                var user = _userManager.FindById(User.Identity.GetUserId<int>());
                user.City = model.City;
                user.LastName = model.LastName;
                user.Name = model.Name;
                user.PostalCode = model.PostalCode;
                user.Number = model.Number;
                user.PhoneNumber = model.Phone;
                user.Street = model.Street;
                user.KontoFirmowe = false;
                var result = _userManager.Update(user);
                model.Success = result.Succeeded;
                return PartialView("_ChangeUserInfoViewModel", model);
            }
            return PartialView("_ChangeUserInfoViewModel", model);
        }

        //GET: User data - konto firmowe
        [HttpGet]
        [Authorize]
        public virtual ActionResult ChangeUserFirmaInfoViewModel()
        {
            var user = _userManager.FindById(User.Identity.GetUserId<int>());
            var model = new ChangeUserFirmaInfoViewModel
            {
                City = user.City ?? "Nie podano",
                Email = user.Email,
                NazwaFirmy = user.NazwaFirmy ?? "Nie podano",
                Nip = user.AccNip ?? "Nie podano",
                Number = user.Number ?? "Nie podano",
                Phone = user.PhoneNumber ?? "Nie podano",
                PostalCode = user.PostalCode ?? "Nie podano",
                Street = user.Street ?? "Nie podano",
                Success = null
            };
            return PartialView("_ChangeUserFirmaInfoViewModel", model);
        }

        //GET: change User data - konto firmowe
        [HttpPost]
        [Authorize]
        public virtual ActionResult ChangeUserFirmaInfoViewModel(ChangeUserFirmaInfoViewModel model)
        {
            var userExists = _userManager.FindByEmail(model.Email);
            if (userExists != null)
                if (userExists.Id != User.Identity.GetUserId<int>())
                    ModelState.AddModelError("Email", "Adres email jest używany!");
            if (ModelState.IsValid)
            {
                var user = _userManager.FindById(User.Identity.GetUserId<int>());
                user.City = model.City;
                user.NazwaFirmy = model.NazwaFirmy;
                user.AccNip = model.Nip;
                user.PostalCode = model.PostalCode;
                user.Number = model.Number;
                user.PhoneNumber = model.Phone;
                user.Street = model.Street;
                user.KontoFirmowe = true;
                var result = _userManager.Update(user);
                model.Success = result.Succeeded;
                return PartialView("_ChangeUserFirmaInfoViewModel", model);
            }
            return PartialView("_ChangeUserFirmaInfoViewModel", model);
        }

        [HttpGet]
        [Authorize]
        public virtual ActionResult HistoriaZamowien()
        {
            var userId = _userManager.FindById(User.Identity.GetUserId<int>()).Id;
            var model = _dbContext.Orders.Where(m => m.UserId == userId).Select(x => new AccountOrderItemModel
            {
                ActualState = x.OrderInfo,
                Id = x.OrderId,
                OrderDate = x.OrderDate,
                TotalPrice = x.TotalPrice
            }).ToList();
            var viewModel = model.Select(itemModel => new AccountOrderItemViewModel
            {
                ActualState = itemModel.ActualState,
                Id = itemModel.Id,
                OrderDate = itemModel.OrderDate.ToShortDateString(),
                TotalPrice = itemModel.TotalPrice
            }).ToList();
            return View(viewModel);
        }

        public virtual ActionResult AnulujZamówienie(int id)
        {
            var order = _dbContext.Orders.First(m => m.OrderId == id);
            if (order.OrderInfo!="Wysłano")
            {
                order.OrderInfo = "Anulowano";
                var orderItems = _dbContext.OrderDetails.Where(x => x.OrderId == id);
                foreach (var item in orderItems)
                {
                    var prod = _dbContext.Products.First(m => m.ProductId == item.ProductId);
                    prod.Quantity += item.Quantity;
                    prod.OrdersCount++;
                    _dbContext.Products.AddOrUpdate(prod);
                }
            }
            return RedirectToAction(MVC.Konto.HistoriaZamowien());
        }

        [Authorize]
        [HttpGet]
        public virtual ActionResult SzczegółyZamówienia(int id)
        {
            var userId = _userManager.FindById(User.Identity.GetUserId<int>());
            var order = _dbContext.Orders.First(m => m.OrderId == id);
            if (userId.Id != order.UserId)
                return RedirectToAction(MVC.Konto.HistoriaZamowien());
            var paymentModel = _dbContext.PaymentTypes.Where(m => m.PaymentId == order.PaymentId)
                .Select(k => new OrderPaymentSummary
                {
                    Description = k.PaymentDescription,
                    Name = k.PaymentName,
                    Price = k.PaymentPrice.ToString()
                }).First();
            var shippingModel = _dbContext.ShippingTypes.Where(m => m.ShippingId == order.ShippingId)
                .Select(k => new OrderShippingSummary
                {
                    Description = k.ShippingDescription,
                    Name = k.ShippingName,
                    Price = k.ShippingPrice.ToString()
                }).First();
            var orderProductsList = _dbContext.OrderDetails.Where(k => k.OrderId == order.OrderId).Select(x => new OrderItemSummary
                {                    
                    Name = x.Products.Description,
                    Image = x.Products.ImageName,
                    Price = x.Products.Price.ToString(),
                    Quantity = x.Quantity,
                    TotalValue = x.SubTotalPrice.ToString()
                }).ToList();
            var orderProductsPrice= orderProductsList.Sum(itemSummary => Convert.ToDecimal(itemSummary.TotalValue.Replace('.', ',')));
            var model = new AccountOrderViewModelsSummary
            {
                Id = id,
                Firma = userId.KontoFirmowe,
                OrderPayment = paymentModel,
                OrderShipping = shippingModel,
                TotalTotalValue = order.TotalPrice.ToString("c"),
                UserAddressModel = new CartAddressModel
                {
                    Imie = order.Name,
                    KodPocztowy = order.PostalCode,
                    Miasto = order.City,
                    NazwaFirmy = order.NazwaFirmy,
                    Nazwisko = order.Surname,
                    Nip = order.OrderNip,
                    Numer = order.Number,
                    Telefon = order.Phone,
                    Ulica = order.Street
                },
                OrderViewItemsTotal = new OrderViewItemsTotal
                {
                    OrderProductList = orderProductsList,
                    TotalValue = orderProductsPrice.ToString("c")                        
                }
            };
            return View(model);
        }

        ////
        //// GET: /Manage/SetPassword
        //public virtual ActionResult UstawHaslo()
        //{
        //    return View();
        //}

        ////
        //// POST: /Manage/SetPassword
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public virtual async Task<ActionResult> UstawHaslo(SetPasswordViewModel model)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        var result =
        //            await _userManager.AddPasswordAsync(int.Parse(User.Identity.GetUserId()), model.NewPassword);
        //        if (result.Succeeded)
        //        {
        //            var user = await _userManager.FindByIdAsync(int.Parse(User.Identity.GetUserId()));
        //            if (user != null)
        //            {
        //                await SignInAsync(user, isPersistent: false);
        //            }
        //            return RedirectToAction(MVC.Konto.Index());
        //        }
        //        AddErrors(result);
        //    }
        //    return View(model);
        //}

        #region Helpers

        private void ActivationMailBuilder(string callbackUrl, string sendTo)
        {
            var email = new ActivationEmail
            {
                CallbackUrl = callbackUrl,
                To = sendTo
            };
            email.Send();
        }

        private void ResetPasswordMailBuilder(string callbackUrl, string sendTo)
        {
            var email = new ResetEmail
            {
                CallbackUrl = callbackUrl,
                To = sendTo
            };
            email.Send();
        }

        private void AddErrors(IdentityResult result)
        {
            foreach (var error in result.Errors)
            {
                ModelState.AddModelError("", error);
            }
        }

        private ActionResult RedirectToLocal(string returnUrl)
        {
            if (Url.IsLocalUrl(returnUrl))
            {
                return Redirect(returnUrl);
            }
            return RedirectToAction(MVC.Home.Index());
        }


        private async Task SignInAsync(ApplicationUser user, bool isPersistent)
        {
            _authenticationManager.SignOut(DefaultAuthenticationTypes.ExternalCookie,
                DefaultAuthenticationTypes.TwoFactorCookie);
            _authenticationManager.SignIn(new AuthenticationProperties {IsPersistent = isPersistent},
                await user.GenerateUserIdentityAsync(_userManager));
        }

        #endregion
    }
}