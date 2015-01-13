﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SukkuShop.Models
{
    public class ForgotViewModel
    {
        [Required(ErrorMessage = "Pole {0} jest wymagane.")]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }

    public class LoginViewModel
    {
        [Required(ErrorMessage = "Pole {0} jest wymagane.")]
        [Display(Name = "Email")]
        [EmailAddress(ErrorMessage = "To nie jest adres Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Pole {0} jest wymagane.")]
        [DataType(DataType.Password)]
        [Display(Name = "Hasło")]
        public string PasswordLogin { get; set; }

        [Display(Name = "Nie wylogowuj mnie")]
        public bool RememberMe { get; set; }
    }

    public class RegisterViewModel
    {
        [Required(ErrorMessage = "Pole {0} jest wymagane.")]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Pole {0} jest wymagane.")]
        [StringLength(100, ErrorMessage = "{0} musi zawierać przynajmniej {2} znaków.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Hasło")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Potwierdź hasło")]
        [Compare("Password", ErrorMessage = "Podane hasła nie są takie same")]
        public string ConfirmPassword { get; set; }

        public bool KontoFirmowe { get; set; }
    }

    public class ResetPasswordViewModel
    {
        [Required(ErrorMessage = "Pole {0} jest wymagane.")]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Pole {0} jest wymagane.")]
        [StringLength(100, ErrorMessage = "{0} musi zawierać przynajmniej {2} znaków.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Hasło")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Potwierdź hasło")]
        [Compare("Password", ErrorMessage = "Podane hasła nie są takie same")]
        public string ConfirmPassword { get; set; }

        public string Code { get; set; }

        public string result { get; set; }
    }

    public class ForgotPasswordViewModel
    {
        [Required(ErrorMessage = "Pole {0} jest wymagane.")]
        [EmailAddress(ErrorMessage = "To nie jest adres email.")]
        [Display(Name = "Email")]
        public string Email { get; set; }

        public string result { get; set; }
    }

    public class SetPasswordViewModel
    {
        [Required(ErrorMessage = "Pole {0} jest wymagane.")]
        [StringLength(100, ErrorMessage = "{0} musi zawierać przynajmniej {2} znaków.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Nowe hasło")]
        public string NewPassword { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Potwierdź nowe hasło")]
        [Compare("NewPassword", ErrorMessage = "Nowe hasła nie są takie same")]
        public string ConfirmPassword { get; set; }
    }

    public class ChangeUserInfoViewModel
    {
        [Required(ErrorMessage = "Pole {0} jest wymagane.")]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [RegularExpression("^[A-Ża-ż]*$|^Nie podano$", ErrorMessage = "Nieprawidłowa wartość")]
        [StringLength(20, ErrorMessage = "{0} musi zawierać przynajmniej {2} znaków.", MinimumLength = 2)]
        [Display(Name = "Imię")]
        public string Name { get; set; }

        [RegularExpression("^[A-Ża-ż -]*$|^Nie podano$", ErrorMessage = "Nieprawidłowa wartość")]
        [StringLength(30, ErrorMessage = "{0} musi zawierać przynajmniej {2} znaków.", MinimumLength = 2)]
        [Display(Name = "Nazwisko")]
        public string LastName { get; set; }

        [RegularExpression("^[A-Ża-ż -]*$|^Nie podano$", ErrorMessage = "Nieprawidłowa wartość")]
        [StringLength(50, ErrorMessage = "{0} musi zawierać przynajmniej {2} znaków.", MinimumLength = 2)]
        [Display(Name = "Miasto")]
        public string City { get; set; }

        [RegularExpression("^[A-Ża-ż -0-9]*$|^Nie podano$", ErrorMessage = "Ulica nie może zawierać znaków specjalnych")]
        [StringLength(20, ErrorMessage = "{0} musi zawierać przynajmniej {2} znaków.", MinimumLength = 2)]
        [Display(Name = "Ulica")]
        public string Street { get; set; }

        [RegularExpression("^[1-9][0-9]{0,4}[A-Ża-ż]{0,1}[/]?[0-9]*$|^Nie podano$", ErrorMessage = "Numer domu jest niepoprawny")]
        [StringLength(10, ErrorMessage = "{0} musi zawierać przynajmniej {2} znaków.", MinimumLength = 1)]
        [Display(Name = "Numer domu")]
        public string Number { get; set; }

        [RegularExpression("^[1-9][0-9]{8}$|^Nie podano$", ErrorMessage = "Numer domu jest niepoprawny")]
        [Display(Name = "Telefon")]
        public string Phone { get; set; }

        [Display(Name = "Kod pocztowy")]
        [RegularExpression("^[0-9]{2}-[0-9]{3}$", ErrorMessage = "Kod pocztowy jest niepoprawny (xx-xxx)")]
        public string PostalCode { get; set; }

        public bool? Success { get; set; }

        public bool CzyFirmowe { get; set; }
    }


    public class ChangeUserFirmaInfoViewModel
    {
        [Required(ErrorMessage = "Pole {0} jest wymagane.")]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [RegularExpression("^[A-Ża-ż 0-9-]*$|^Nie podano$", ErrorMessage = "Nazwa nie może zawierać znaków specjalnych")]
        [StringLength(50, ErrorMessage = "{0} musi zawierać przynajmniej {2} znaków.", MinimumLength = 2)]
        [Display(Name = "Nazwa firmy")]
        public string NazwaFirmy { get; set; }

        [RegularExpression("^[0-9]{10}$|^Nie podano$", ErrorMessage = "Numer NIP to 10 cyfrowa liczba.")]
        [StringLength(10, ErrorMessage = "{0} musi zawierać przynajmniej {2} znaków.", MinimumLength = 10)]
        [Display(Name = "NIP")]
        public string Nip { get; set; }

        [RegularExpression("^[A-Ża-ż -]*$|^Nie podano$", ErrorMessage = "Nieprawidłowa wartość")]
        [StringLength(50, ErrorMessage = "{0} musi zawierać przynajmniej {2} znaków.", MinimumLength = 2)]
        [Display(Name = "Miasto")]
        public string City { get; set; }

        [RegularExpression("^[A-Ża-ż -0-9]*$|^Nie podano$", ErrorMessage = "Ulica nie może zawierać znaków specjalnych")]
        [StringLength(20, ErrorMessage = "{0} musi zawierać przynajmniej {2} znaków.", MinimumLength = 2)]
        [Display(Name = "Ulica")]
        public string Street { get; set; }

        [RegularExpression("^[1-9][0-9]{0,4}[A-Ża-ż]{0,1}[/]?[0-9]*$|^Nie podano$", ErrorMessage = "Numer domu jest niepoprawny")]
        [StringLength(10, ErrorMessage = "{0} musi zawierać przynajmniej {2} znaków.", MinimumLength = 1)]
        [Display(Name = "Numer domu")]
        public string Number { get; set; }

        [RegularExpression("^[1-9][0-9]{8}$|^Nie podano$",ErrorMessage = "Numer domu jest niepoprawny")]
        [Display(Name = "Telefon")]
        public string Phone { get; set; }

        [Display(Name = "Kod pocztowy")]
        [RegularExpression("^[0-9]{2}-[0-9]{3}$", ErrorMessage = "Kod pocztowy jest niepoprawny (xx-xxx)")]
        public string PostalCode { get; set; }

        public bool? Success { get; set; }

        public bool CzyFirmowe { get; set; }
    }

    public class ChangePasswordViewModel
    {
        [Required(ErrorMessage = "Pole {0} jest wymagane.")]
        [StringLength(100, ErrorMessage = "{0} musi zawierać przynajmniej {2} znaków.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Stare hasło")]
        public string OldPassword { get; set; }

        [Required(ErrorMessage = "Pole {0} jest wymagane.")]
        [StringLength(100, ErrorMessage = "{0} musi zawierać przynajmniej {2} znaków.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Nowe hasło")]
        public string NewPassword { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Potwierdź nowe hasło")]
        [Compare("NewPassword", ErrorMessage = "Nowe hasła nie są takie same.")]
        public string ConfirmPassword { get; set; }

        public bool? Success { get; set; }
    }

    public class AccountOrderItemModel
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal TotalPrice { get; set; }
        public string ActualState { get; set; }
    }

    public class AccountOrderItemViewModel
    {
        public int Id { get; set; }
        public string OrderDate { get; set; }
        public decimal TotalPrice { get; set; }
        public string ActualState { get; set; }
    }

    //public class AccountOrdersViewModel
    //{
    //    public List<AccountOrderItemModel> AccountOrdersList { get; set; }
    //}

    //public class AccountOrderDetailsViewModel
    //{
    //    public int PaymentId { get; set; }
    //    public int ShippingId { get; set; }
    //    public string TotalPrice { get; set; }
    //    public List<AccountOrderItemDetailsModel> ItemList { get; set; }
    //}

    //public class AccountOrderItemDetailsModel
    //{
    //    public string ImageName { get; set; }
    //    public string Name { get; set; }
    //    public string Id { get; set; }
    //    public string Price { get; set; }
    //    public string Quantity { get; set; }
    //    public string SubTotalPrice { get; set; }
    //}

    public class AccountOrderViewModelsSummary
    {
        public OrderViewItemsTotal OrderViewItemsTotal { get; set; }
        public CartAddressModel UserAddressModel { get; set; }
        public OrderShippingSummary OrderShipping { get; set; }
        public OrderPaymentSummary OrderPayment { get; set; }
        public string OrderDat { get; set; }
        public string TotalTotalValue { get; set; }
        public string OrderInfo { get; set; }
        public bool Firma { get; set; }
        public int Id { get; set; }
    }
}