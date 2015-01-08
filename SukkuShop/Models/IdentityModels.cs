﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using SukkuShop.Identity;
using SukkuShop.Infrastructure.Generic;

namespace SukkuShop.Models
{
    public sealed class ApplicationUser : IdentityUser<int, UserLoginIntPk, UserRoleIntPk, UserClaimIntPk>
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(ApplicationUserManager manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }

        public ApplicationUser()
        {
            Orders = new List<Orders>();
        }

        public string NazwaFirmy { get; set; }
        public int Nip { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string Number { get; set; }
        public string PostalCode { get; set; }
        public ICollection<Orders> Orders { get; set; }
    }


    [Table("Categories")]
    public sealed class Categories
    {
        [Key]
        public int CategoryId { get; set; }

        public string Name { get; set; }
        public int? Promotion { get; set; }
        public int? UpperCategoryId { get; set; }
    }


    [Table("Products")]
    public sealed class Products
    {
        public Products()
        {
            OrderDetails = new List<OrderDetails>();
        }

        [Key]
        public int ProductId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public int CategoryId { get; set; }
        public string ImageName { get; set; }
        public string Producer { get; set; }
        public int? Promotion { get; set; }
        public string Description { get; set; }

        [DisplayName("Sposób pakowania")]
        public string Packing { get; set; }

        public DateTime DateAdded { get; set; }

        [DefaultValue(typeof(int),"0")]
        public int OrdersCount { get; set; }

        public Categories Categories { get; set; }

        public ICollection<OrderDetails> OrderDetails { get; set; }
    }

    [Table("OrderDetails")]
    public class OrderDetails
    {
        [Key]
        public int OrderDetailId { get; set; }
        public int ProductId { get; set; }
        public int OrderId { get; set; }
        public int Quantity { get; set; }
        public decimal SubTotalPrice { get; set; }
        public virtual Products Products { get; set; }

        public virtual Orders Orders { get; set; }
    }

    [Table("Orders")]
    public sealed class Orders
    {
        public Orders()
        {
            OrderDetails = new List<OrderDetails>();
        }
            
        [Key]
        public int OrderId { get; set; }
        public int UserId { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime SentDate { get; set; }
        public string OrderInfo { get; set; }
        public int ShippingId { get; set; }
        public int PaymentId { get; set; }
        public decimal ProductsPrice { get; set; }
        public decimal TotalPrice { get; set; }
        public string UserHints { get; set; }
        public string NazwaFirmy { get; set; }
        public int NIP { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string Number { get; set; }
        public string PostalCode { get; set; }
        public ICollection<OrderDetails> OrderDetails { get; set; }

        public ShippingType Shipping { get; set; }
        public PaymentType Payment { get; set; }
        public ApplicationUser User { get; set; }
    }


    [Table("ShippingTypes")]
    public class ShippingType
    {
        [Key]
        public int ShippingId { get; set; }
        public string ShippingName { get; set; }
        public decimal ShippingPrice { get; set; }
    }

    [Table("PaymentTypes")]
    public class PaymentType
    {
        [Key]
        public int PaymentId { get; set; }
        public string PaymentName { get; set; }
        public decimal PaymentPrice { get; set; }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, RoleIntPk, int,
        UserLoginIntPk, UserRoleIntPk, UserClaimIntPk>,IAppRepository
    {
        public ApplicationDbContext()
            : base("DefaultConnection")
        {
        }

        public virtual DbSet<Products> Products { get; set; }
        public virtual DbSet<Categories> Categories { get; set; }
        public virtual DbSet<OrderDetails> OrderDetails { get; set; }
        public virtual DbSet<Orders> Orders { get; set; }
        public virtual DbSet<ShippingType> ShippingTypes { get; set; }
        public virtual DbSet<PaymentType> PaymentTypes { get; set; }


        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        //public bool Seed(ApplicationDbContext context)
        //{
            
        //}

        /// Context Initializer
        public class DropCreateInitializer : CreateDatabaseIfNotExists<ApplicationDbContext>
        {
            protected override void Seed(ApplicationDbContext context)
            {
                var roleManager = new ApplicationRoleManager(new RoleStore<RoleIntPk, int, UserRoleIntPk>(context));
                roleManager.Create(new RoleIntPk("Admin", "Admin Role"));

                //Create Admin acc
                var userManager = new ApplicationUserManager(new UserStore<ApplicationUser, RoleIntPk, int,
                    UserLoginIntPk, UserRoleIntPk, UserClaimIntPk>(context));

                var user = new ApplicationUser
                {
                    Name = "Admin",
                    Email = "Admin@sukku.pl",
                    UserName = "Admin@sukku.pl"
                };

                userManager.Create(user, "Admin123456");
                userManager.AddToRole(user.Id, "Admin");

                context.Categories.AddOrUpdate(p => p.CategoryId,
                        new Categories { CategoryId = 1, Name = "Kosmetyki", UpperCategoryId = 0 },
                        new Categories { CategoryId = 2, Name = "Przyprawy", UpperCategoryId = 0 },
                        new Categories { CategoryId = 3, Name = "Herbaty", UpperCategoryId = 0 },
                        new Categories { CategoryId = 4, Name = "Bakalie", UpperCategoryId = 0 },
                        new Categories { CategoryId = 5, Name = "Inne", UpperCategoryId = 0 },
                        new Categories { CategoryId = 6, Name = "Pielęgnacja Ciała", UpperCategoryId = 1 },
                        new Categories { CategoryId = 7, Name = "Pielęgnacja Twarzy", UpperCategoryId = 1 },
                        new Categories { CategoryId = 8, Name = "Ostre", UpperCategoryId = 2 },
                        new Categories { CategoryId = 9, Name = "Łagodne", UpperCategoryId = 2 }
                    );

                context.PaymentTypes.AddOrUpdate(p => p.PaymentId,
                        new PaymentType { PaymentId = 1, PaymentName = "Przedpłata na konto", PaymentPrice = 0 },
                        new PaymentType { PaymentId = 2, PaymentName = "Płatność za pobraniem", PaymentPrice = 5 },
                        new PaymentType { PaymentId = 3, PaymentName = "PayU", PaymentPrice = 1 }
                    );

                context.ShippingTypes.AddOrUpdate(p => p.ShippingId,
                    new ShippingType { ShippingId = 1, ShippingName = "Poczta Polska Kurier48", ShippingPrice = 8 },
                    new ShippingType { ShippingId = 2, ShippingName = "Poczta Polska Przesyłka Ekonomiczna", ShippingPrice = 7 },
                    new ShippingType { ShippingId = 3, ShippingName = "Kurier Siódemka", ShippingPrice = 12 },
                    new ShippingType { ShippingId = 4, ShippingName = "Paczkomaty", ShippingPrice = 5 },
                    new ShippingType { ShippingId = 5, ShippingName = "Odbiór osobisty", ShippingPrice = 0 }
                    );
                base.Seed(context);
            }
        }

        public ApplicationDbContext Context { get; set; }
    }

    //New drived classes 
    public class UserRoleIntPk : IdentityUserRole<int>
    {
    }

    public class UserClaimIntPk : IdentityUserClaim<int>
    {
    }

    public class UserLoginIntPk : IdentityUserLogin<int>
    {
    }

    public class RoleIntPk : IdentityRole<int, UserRoleIntPk>
    {
        public RoleIntPk()
        {
        }

        public RoleIntPk(string name, string description)
        {
            Name = name;
            Description = description;
        }

        public string Description { get; set; }
    }

    public class UserStoreIntPk : UserStore<ApplicationUser, RoleIntPk, int,
        UserLoginIntPk, UserRoleIntPk, UserClaimIntPk>
    {
        public UserStoreIntPk(DbContext context)
            : base(context)
        {
        }
    }

    public class RoleStoreIntPk : RoleStore<RoleIntPk, int, UserRoleIntPk>
    {
        public RoleStoreIntPk(DbContext context)
            : base(context)
        {
        }
    }
}