﻿using EntityFrameworkHW.Models;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EntityFrameworkHW.Controllers
{
    public class ProductsController : Controller
    {
        ApplicationDbContext db = new ApplicationDbContext();
        // GET: Products
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Sort()
        {
            var _products = db.Products.Join(db.ProductTypes,
                p => p.ProductId,
                c => c.ProductId,
                (p, c) => new ProductInfo
                {
                    prId = p.ProductId,
                    prName = p.ProductName,
                    prPrice = p.ProductPrice,
                    prType = c.Name,
                    
                }).OrderByDescending(z => z.prPrice).ToList();

            int count = -1;
            foreach (var item in _products)
            {
                count++;
            }

            for (int i = count; i > 0; i--)
            {
                if (_products[i].prId == _products[i - 1].prId)
                {
                    _products[i - 1].prType += ", " + _products[i].prType;
                    _products.Remove(_products[i]);
                }
            }

            return PartialView(_products);

        }

        [HttpPost]
        public ActionResult Sort(string name)
        {
            
                var _products = db.Products.Where(q => q.ProductName.ToLower().Contains(name.ToLower()))
                                        .Join(db.ProductTypes,
                            p => p.ProductId,
                            c => c.ProductId,
                            (p, c) => new ProductInfo
                            {
                                prId = p.ProductId,
                                prName = p.ProductName,
                                prPrice = p.ProductPrice,
                                prType = c.Name,

                            }).ToList();


            int count = -1;
            foreach (var item in _products)
            {
                count++;
            }

            for (int i = count; i > 0; i--)
            {
                if (_products[i].prId == _products[i - 1].prId)
                    {
                    _products[i-1].prType += ", " + _products[i].prType;
                    _products.Remove(_products[i]);
                }
            }

                return PartialView(_products);
            
            
          
        }

        public dynamic Combine(object item1, object item2)
        {
            if (item1 == null || item2 == null)
                return item1 ?? item2 ?? new ExpandoObject();

            dynamic expando = new ExpandoObject();
            var result = expando as IDictionary<string, object>;
            foreach (System.Reflection.PropertyInfo fi in item1.GetType().GetProperties())
            {
                result[fi.Name] = fi.GetValue(item1, null);
            }
            foreach (System.Reflection.PropertyInfo fi in item2.GetType().GetProperties())
            {
                result[fi.Name] = fi.GetValue(item2, null);
            }
            return result;
        }


        // GET: Products/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Products/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Products/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Products/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Products/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Products/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
