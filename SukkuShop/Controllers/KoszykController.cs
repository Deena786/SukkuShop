﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using SukkuShop.Infrastructure.Generic;
using SukkuShop.Models;

namespace SukkuShop.Controllers 
{

    public partial class KoszykController : Controller
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly IAppRepository _appRepository;
        
        public KoszykController(ApplicationDbContext dbContext, IAppRepository appRepository)
        {
            _dbContext = dbContext;
            _appRepository = appRepository;
        }

        [HttpPost]
        public virtual ActionResult AddToCart(int id, Cart shoppingCart, int quantity = 1)
        {
            var productQ = _appRepository.GetSingle<Products>(m => m.ProductId == id);
            var firstOrDefault = shoppingCart.Lines.FirstOrDefault(m => m.Id == id);
            if (firstOrDefault != null)
            {
                var prodLineQ = firstOrDefault.Quantity;
                if (prodLineQ + quantity <= productQ.Quantity-productQ.ReservedQuantity)
                {
                    shoppingCart.AddItem(id, quantity);
                }
            }
            else
            {
                const int prodLineQ = 0;
                if (prodLineQ + quantity <= productQ.Quantity-productQ.ReservedQuantity)
                {
                    shoppingCart.AddItem(id, quantity);
                }
            }
            var valuee = CalcTotalValue(shoppingCart);
            var value = String.Format("{0:0.00}", valuee);
            var data = new
            {
                value,
                id
            };
            return Json(data, JsonRequestBehavior.AllowGet);
        }

        public virtual ActionResult RemoveFromCart(int id, Cart shoppingCart)
        {
            shoppingCart.RemoveLine(id);
            var result = CartViewModels(shoppingCart);
            return PartialView("CartTable",result);
        }

        public virtual JsonResult IncreaseQuantity(int id, Cart shoppingCart)
        {

            var firstOrDefault = _appRepository.GetSingle<Products>(m => m.ProductId == id);
            var ordefault = shoppingCart.Lines.FirstOrDefault(x => x.Id == id);
            if (ordefault != null)
            {
                var quantity = ordefault.Quantity;
                if (firstOrDefault.Quantity - firstOrDefault.ReservedQuantity <= quantity) return Json(false);
                shoppingCart.AddItem(id);
                var price = CalcPrice(firstOrDefault.Price, firstOrDefault.Promotion);
                var data = price*(quantity + 1);
                return Json(data, JsonRequestBehavior.AllowGet);
            }
            return Json(false,JsonRequestBehavior.AllowGet);
        }

        public virtual JsonResult DecreaseQuantity(int id, Cart shoppingCart)
        {           
            shoppingCart.DecreaseQuantity(id);
            var firstOrDefault = _appRepository.GetSingle<Products>(m => m.ProductId == id);
            var quantity = shoppingCart.Lines.FirstOrDefault(x => x.Id == id).Quantity;
            var price = CalcPrice(firstOrDefault.Price, firstOrDefault.Promotion);
            var data = price*quantity;
            return Json(data, JsonRequestBehavior.AllowGet);
        }

        public virtual JsonResult TotalPriceJson(Cart cart)
        {
            var data = CalcTotalValue(cart);
            return Json(data, JsonRequestBehavior.AllowGet);
        }

        public virtual ActionResult TotalValue(Cart shoppingCart)
        {
            var value = CalcTotalValue(shoppingCart);
            return PartialView(MVC.Shared.Views._CartInfoPartialView, value.ToString("c"));
        }

        private decimal CalcTotalValue(Cart shoppingCart)
        {
            decimal sum = 0;
            foreach (var line in shoppingCart.Lines)
            {
                var firstOrDefault = _appRepository.GetSingle<Products>(m => m.ProductId == line.Id);
                if (firstOrDefault != null)
                {
                    var priceFloored = CalcPrice(firstOrDefault.Price, firstOrDefault.Promotion);
                    sum += priceFloored*line.Quantity;
                }
            }
            return sum;
        }

        // GET: Cart
        public virtual ActionResult Index(Cart shoppingCart)
        {
            var model = CartViewModels(shoppingCart);
            return View(model);
        }


        private static decimal CalcPrice(decimal? price, int? promotion)
        {
            var pricee = (price - ((price * promotion) / 100)) ?? price;
            return Math.Floor((pricee ?? 0) * 100) / 100;
        }

        private CartViewModels CartViewModels(Cart shoppingCart)
        {
            var productList = new List<CartProduct>();
            foreach (var item in shoppingCart.Lines)
            {
                var product = _appRepository.GetSingle<Products>(m => m.ProductId == item.Id);
                if (product == null) continue;
                var categoryName = _appRepository.GetSingle<Categories>(m => m.CategoryId == product.CategoryId).Name;
                var price = (product.Price - ((product.Price*product.Promotion)/100)) ?? product.Price;
                var priceFloored = Math.Floor((price??0)*100)/100;
                productList.Add(new CartProduct
                {
                    Id = product.ProductId, 
                    Description = product.Description, 
                    Name = product.Name, 
                    Price = priceFloored.ToString("c"), 
                    Quantity = item.Quantity, 
                    TotalValue = (priceFloored*item.Quantity).ToString("c"),
                    Image = product.IconName ?? "NoPhoto_small",
                    MaxQuantity = product.Quantity ?? 0,
                    CategoryName = categoryName,
                    Packing = product.Packing
                });
            }
            var model = new CartViewModels
            {
                CartProductsList = productList,
                TotalValue = CalcTotalValue(shoppingCart).ToString("c").Replace(",",".")
            };
            return model;
        }
    }
}