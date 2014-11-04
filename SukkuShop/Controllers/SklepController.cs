﻿using System.Linq;
using System.Web.Mvc;
using SukkuShop.Infrastructure.Generic;
using SukkuShop.Models;

namespace SukkuShop.Controllers
{
    public class SklepController : Controller
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly IShop _shop;

        public SklepController(ApplicationDbContext dbContext, IShop shop)
        {
            _dbContext = dbContext;
            _shop = shop;
        }

        // GET: Produkty
        public ActionResult Produkty(string category, SortMethod method = SortMethod.Nowości, string search = null,
            int page = 1)
        {
            var categorylist = _dbContext.Categories.Select(x => x.Name).Distinct().ToList();

            if (!categorylist.Contains(category))
            {
                if (search == null)
                    search = category;
                ViewBag.SearchString = search;
                category = search;
                _shop.Products = _dbContext.Products.Where(c => c.Name.Contains(category));
            }
            else
                _shop.Products = _dbContext.Products.Where(c => category == null || c.Categories.Name == category);

            var paginator = new PagingInfo
            {
                CurrentPage = page,
                ItemsPerPage = 3,
                TotalItems = _shop.Products.Count()
            };

            var viewModel = new ProductsListViewModel
            {
                Products = _shop.SortProducts(_shop.Products, method).Select(x => new ProductViewModel
                {
                    Name = x.Name,
                    ImageName = x.ImageName,
                    Price = x.Price,
                    Promotion = x.Promotion ?? 0,
                    QuantityInStock = x.Quantity,
                    Category = x.Categories.Name,
                    Id = x.ProductId,
                    PriceAfterDiscount = x.Price*x.Promotion ?? 0
                }).Skip((page - 1)*paginator.ItemsPerPage)
                    .Take(paginator.ItemsPerPage),
                CurrentCategory = category,
                CurrentSortMethod = method,
                PagingInfo = paginator
            };
            return View(viewModel);
        }

        public ActionResult SzczegółyProduktu(int id)
        {
            var product = _dbContext.Products.FirstOrDefault(x => x.ProductId == id);
            return View(product);
        }

    }
}