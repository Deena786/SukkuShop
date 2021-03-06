﻿#region

using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web.Mvc;
using SukkuShop.Infrastructure.Generic;
using SukkuShop.Models;

#endregion

namespace SukkuShop.Controllers
{
    public partial class SklepController : Controller
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly IShop _shop;
        private readonly IAppRepository _appRepository;


        public SklepController(ApplicationDbContext dbContext, IShop shop, IAppRepository appRepository)
        {
            _appRepository = appRepository;
            _dbContext = dbContext;
            _shop = shop;
        }

        // GET: Produkty

        public virtual ActionResult GetProductByCategory(Cart shoppingCart,string id = null)
        {
            //getallproducts
            GetAllProducts(shoppingCart.Lines.ToList());

            //Novelty system
            _shop.Bestsellers();

            //bestseller system
            _shop.NewProducts();
            var categoryId = 0;
            var subcategoryList = new List<string>();
            if (id != null)
            {
                var categorylist =
                    _appRepository.GetAll<Categories>(j => j.UpperCategoryId == 0 || j.UpperCategoryId == null)
                        .Select(x => x.Name);

                var optionlist = new List<string> {"promocje", "bestseller", "nowość"};
                if (categorylist.Contains(id))
                {
                    var firstOrDefault = _appRepository.GetSingle<Categories>(x => x.Name == id);
                    if (firstOrDefault != null)
                        categoryId = firstOrDefault.CategoryId;
                }
                if (categoryId != 0)
                    subcategoryList =
                        _appRepository.GetAll<Categories>(x => x.UpperCategoryId == categoryId && x.Products.Count > 0)
                            .Select(j => j.Name)
                            .Distinct()
                            .ToList();


                if (categorylist.Contains(id))
                    _shop.Products =
                        _shop.Products.Where(
                            c => c.Category == id || subcategoryList.Contains(c.Category)).ToList();
                else if (optionlist.Contains(id))
                {
                    switch (id)
                    {
                        case "bestseller":
                            _shop.Products = _shop.Products.Where(x => x.Bestseller).ToList();
                            break;
                        case "promocje":
                            _shop.Products = _shop.Products.Where(x => x.Promotion > 0).ToList();
                            break;
                        case "nowość":
                            _shop.Products = _shop.Products.Where(x => x.Novelty).ToList();
                            break;
                        default:
                            _shop.Products = _shop.Products;
                            break;
                    }
                }
                else if (!categorylist.Contains(id) && !optionlist.Contains(id))
                    _shop.Products = _shop.Products.Where(c => c.Name.ToUpper().Contains(id.ToUpper())).ToList();
            }
            subcategoryList.Add("Wszystko");
            var obj = new
            {
                categoryId,
                id,
                productList = _shop.Products,
                subcategoryList
            };
            return Json(obj, JsonRequestBehavior.AllowGet);
        }

        //[DonutOutputCache(Duration=86400,Location = OutputCacheLocation.Server,VaryByParam = "id")]
        public virtual ActionResult Produkty(string id)
        {
            return View((object) id);
        }


        //[DonutOutputCache(Duration = 86400, VaryByParam = "id",Location = OutputCacheLocation.Server)]
        public virtual ActionResult SzczegółyProduktu(int id=1)
        {
            var product = _appRepository.GetSingle<Products>(x => x.ProductId == id && x.Published && !x.WrongModel);
            if (product == null)
                return View(MVC.Sklep.Views.NoProducts);

            var category = _appRepository.GetSingle<Categories>(x => x.CategoryId == product.CategoryId);
            var subCategories = new List<int>();
            if (category.UpperCategoryId == 0)
            {
                subCategories =
                    _appRepository.GetAll<Categories>(m => m.UpperCategoryId == category.CategoryId)
                        .Select(x => x.CategoryId)
                        .ToList();
            }

            var similarProducts =
                _appRepository.GetAll<Products>(
                    x =>
                        (x.CategoryId == product.CategoryId || subCategories.Contains(x.CategoryId??-1)) &&
                        x.ProductId != product.ProductId && x.Published).Select(j => new SimilarProductModel
                        {
                            Id = j.ProductId,
                            ImageName = j.IconName ?? "NoPhoto_small",
                            Name = j.Name,
                            Price = j.Price??0,
                            Available = j.Quantity - j.ReservedQuantity > 0,
                            Promotion = j.Promotion
                        }).OrderBy(k => Guid.NewGuid()).Take(4).ToList();
            foreach (var itemSimilar in similarProducts)
            {
                var priceSimilar = (itemSimilar.Price - ((itemSimilar.Price*itemSimilar.Promotion)/100)) ??
                                   itemSimilar.Price;
                var similarFloored = Math.Floor(priceSimilar*100)/100;
                itemSimilar.PriceAfterDiscount = similarFloored;
            }
            var price = (product.Price - ((product.Price*product.Promotion)/100)) ?? product.Price;
            var priceFloored = Math.Floor((price??0)*100)/100;
            var model = new ProductDetailsViewModel
            {
                Product = new ProductDetailModel
                {
                    Category = category.Name,
                    Id = product.ProductId,
                    ImageName = product.ImageName ?? "NoPhoto_normal",
                    Name = product.Name,
                    Price = product.Price??0,
                    PriceAfterDiscount = priceFloored,
                    Promotion = product.Promotion ?? 0,
                    QuantityInStock = product.Quantity??0,
                    Packing = product.Packing,
                    Description = product.Description,
                    ReservedQuantity = product.ReservedQuantity,
                    IconName = product.IconName ?? "NoPhoto_small"
                },
                SimilarProducts = similarProducts
            };
            return View(model);
        }

        //[DonutOutputCache(Duration = 1800, VaryByParam = "search;method;page", Location = OutputCacheLocation.Client)]
        public virtual ActionResult Wyszukaj(string id)
        {
            ////getallproducts
            //GetAllProducts();

            ////Novelty system
            //_shop.Bestsellers();

            ////bestseller system
            //_shop.NewProducts();

            //ViewBag.SearchString = search;
            //_shop.Products = _shop.Products.Where(c => c.Name.ToUpper().Contains(search.ToUpper())).ToList();

            //if (!_shop.Products.Any())
            //    return View(MVC.Sklep.Views.NoProducts);

            //var paginator = new PagingInfo
            //{
            //    CurrentPage = page,
            //    ItemsPerPage = 12,
            //    TotalItems = _shop.Products.Count()
            //};

            //_shop.SortProducts(method);
            //return View(MVC.Sklep.Views.Produkty, new ProductsListViewModel
            //{
            //    Products = _shop.Products.Select(x => new ProductViewModel
            //    {
            //        Bestseller = x.Bestseller,
            //        Id = x.Id,
            //        ImageName = x.ImageName,
            //        Name = x.Name,
            //        Novelty = x.Novelty,
            //        Price = x.Price.ToString("C"),
            //        PriceAfterDiscount = x.PriceAfterDiscount.ToString("C"),
            //        Promotion = x.Promotion ?? 0,
            //        QuantityInStock = x.QuantityInStock
            //    }).Skip((page - 1)*paginator.ItemsPerPage)
            //        .Take(paginator.ItemsPerPage),
            //    CurrentCategory = null,
            //    CurrentSortMethod = method,
            //    PagingInfo = paginator,
            //    CurrentSubCategory = null,
            //    CurrentSearch = search
            //});
            return View("Produkty", (object) id);
        }

        public virtual JsonResult AskForProduct(int id, string email)
        {
            var prodDemand = new ProductDemands
            {
                Email = email,
                ProductId = id
            };
            var plz = _appRepository.GetSingle<ProductDemands>(x => x.Email == email && x.ProductId == id);
            if(plz==null)
                _dbContext.ProductDemands.AddOrUpdate(prodDemand);
            try
            {
                _dbContext.SaveChanges();
            }
            catch (Exception)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            return Json(true, JsonRequestBehavior.AllowGet);
        }

        public virtual ActionResult Szukaj()
        {
            return !String.IsNullOrEmpty(Request["search"])
                ? RedirectToAction(MVC.Sklep.Wyszukaj(Request["search"]))
                : RedirectToAction(MVC.Sklep.Produkty(null));
        }

        public virtual ActionResult RedirectToLocal(string returnUrl)
        {
            if (Url.IsLocalUrl(returnUrl))
            {
                return Redirect(returnUrl);
            }
            return RedirectToAction(MVC.Home.Index());
        }

        private void GetAllProducts(List<Cart.CartLine> liness )
        {
            _shop.Products = _appRepository.GetAll<Products>(k => k.Published && !k.WrongModel).Select(x => new ProductModel
            {
                Name = x.Name,
                ImageName = x.IconName ?? "NoPhoto_small",
                Price = x.Price??0,
                Promotion = x.Promotion ?? 0,
                Id = x.ProductId,
                PriceAfterDiscount = Math.Floor((x.Price - ((x.Price*x.Promotion)/100) ?? x.Price??0)*100)/100,
                Category = _appRepository.GetSingle<Categories>(c=>c.CategoryId == x.CategoryId).Name,
                DateAdded = x.DateAdded,
                OrdersCount = x.OrdersCount,
                QuantityInStock = (x.Quantity??0) - x.ReservedQuantity,
                CartAmount = 0
            }).ToList();

            foreach (var product in _shop.Products)
            {
                var firstOrDefault = liness.FirstOrDefault(x => x.Id == product.Id);                
                product.CartAmount = firstOrDefault==null?0:firstOrDefault.Quantity;
            }
        }
    }
}