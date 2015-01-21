﻿#region

using System;
using System.Collections.ObjectModel;
using System.Data.Entity.Migrations;
using System.IO;
using System.Linq;
using System.Web.Mvc;
using ImageResizer;
using SukkuShop.Areas.Admin.Models;
using SukkuShop.Models;

#endregion

namespace SukkuShop.Areas.Admin.Controllers
{
    public partial class AdminProductController : Controller
    {
        private readonly ApplicationDbContext _dbContext;

        public AdminProductController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        // GET: Admin/AdminProduct
        
        public virtual ActionResult Index()
        {
            return View();
        }

        public virtual JsonResult GetProductList()
        {
            var products = _dbContext.Products.Select(x => new
            {
                x.ProductId,
                x.Name,
                x.Published,
                x.WrongModel,
                x.IsComplete,
                x.CategoryId,
                upper=x.Categories.UpperCategoryId
            });

            var categories = _dbContext.Categories.Where(x => x.UpperCategoryId == 0).Select(k => new
            {
                k.CategoryId,
                k.UpperCategoryId,
                k.Name,
                subcategories = _dbContext.Categories.Where(m => m.UpperCategoryId == k.CategoryId).Select(p => new
                {
                    p.CategoryId,
                    p.UpperCategoryId,
                    p.Name,
                })
            });
            var data = new
            {
                products,
                categories
            };
            return Json(data, JsonRequestBehavior.AllowGet);
        }

        public virtual ActionResult UploadFile(ProductUploadModel model)
        {
            if (ModelState.IsValid)
            {
                var product = new Products
                {
                    Quantity = model.Quantity,
                    CategoryId = model.Category,
                    Name = model.Title,
                    DateAdded = DateTime.Now,
                    Description = model.Description,
                    Published = false,
                    Packing = model.Packing,
                    Promotion = model.Promotion,
                    Price = Convert.ToDecimal(model.Price.Replace(".",",")),
                    ReservedQuantity = 0
                };
                _dbContext.Products.AddOrUpdate(product);
                _dbContext.SaveChanges();
                var prod = _dbContext.Products.OrderByDescending(x => x.ProductId).First();
                if (model.ImageBig != null && model.ImageBig.ContentLength != 0)
                {
                    var pathForSaving = Server.MapPath("~/Content/Images/Shop/");
                    var imageBig = new ImageJob(model.ImageBig, pathForSaving + prod.ProductId + "_normal",
                        new Instructions("maxwidth=700&maxheight=700&format=jpg"))
                    {
                        CreateParentDirectory = true,
                        AddFileExtension = true
                    };
                    imageBig.Build();
                    var imageSmall = new ImageJob(model.ImageBig, pathForSaving + prod.ProductId + "_small",
                        new Instructions("maxwidth=127&maxheight=127&format=jpg"))
                    {
                        CreateParentDirectory = true,
                        AddFileExtension = true
                    };
                    imageSmall.Build();
                }
                prod.IconName = prod.ProductId + "_small";
                prod.ImageName = prod.ProductId + "_normal";
                prod.Published = false;
                prod.IsComplete = true;
                foreach (var prop in product.GetType().GetProperties().Where(prop => prop.GetValue(prod, null) == null))
                    prod.IsComplete = false;
                if (prod.Price == null || prod.CategoryId == null || prod.Packing == null)
                {
                    prod.WrongModel = true;
                    prod.IsComplete = false;
                }   
                _dbContext.Products.AddOrUpdate(prod);
                _dbContext.SaveChanges();
            }
            return View("Index", model);
        }

        [HttpGet]
        public virtual ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public virtual ActionResult Create(Products model)
        {
            if (ModelState.IsValid)
            {
                var item = new Products
                {
                    DateAdded = DateTime.Now,
                    CategoryId = model.CategoryId,
                    ImageName = model.ImageName,
                    Name = model.Name,
                    OrderDetails = new Collection<OrderDetails>(),
                    OrdersCount = 0,
                    Packing = model.Packing,
                    Price = model.Price,
                    Promotion = model.Promotion
                };
                if (item.Quantity < 0)
                    item.Quantity = 0;
                _dbContext.Products.Add(item);
                _dbContext.SaveChanges();

                return RedirectToAction("Index", "Home", new {area = "Admin"});
            }
            return View(model);
        }

        [HttpGet]
        public virtual ActionResult Delete(int id)
        {
            var item = _dbContext.Products.Find(id);
            return View(item);
        }

        [HttpPost]
        [ActionName("Delete")]
        public virtual ActionResult DeletePost(int id)
        {
            var item = _dbContext.Products.Find(id);
            if (item == null)
            {
                return HttpNotFound();
            }
            _dbContext.Products.Remove(item);
            _dbContext.SaveChanges();

            return RedirectToAction("Index", "Home", new {area = "Admin"});
        }

        public virtual ActionResult Edit(int id)
        {
            var item = _dbContext.Products.Find(id);
            if (item == null)
            {
                return HttpNotFound();
            }
            return View(item);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public virtual ActionResult Edit(Products model)
        {
            var item = _dbContext.Products.Find(model.ProductId);
            item.Price = model.Price;
            item.Quantity = model.Quantity;
            item.CategoryId = model.CategoryId;
            item.Name = model.Name;
            item.ImageName = model.ImageName;
            item.Packing = model.Packing;
            item.Promotion = model.Promotion;

            _dbContext.SaveChanges();

            return RedirectToAction("Index", "Home", new {area = "Admin"});
        }

        [HttpGet]
        public virtual ActionResult Details(int id)
        {
            var prod = _dbContext.Products.Find(id);

            return View(prod);
        }

        private bool CreateFolderIfNeeded(string path)
        {
            var result = true;
            if (!Directory.Exists(path))
            {
                try
                {
                    Directory.CreateDirectory(path);
                }
                catch (Exception)
                {
                    result = false;
                }
            }
            return result;
        }
    }
}