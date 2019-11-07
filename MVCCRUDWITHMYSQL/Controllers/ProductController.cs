using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCCRUDWITHMYSQL.Models;

namespace MVCCRUDWITHMYSQL.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            //show products in database
            List<product> productList = new List<product>();
            using(DBModels dbModel=new DBModels())
            {
                productList = dbModel.products.ToList<product>();
            }
            return View(productList);
        }

        // GET: Product/Details/5
        public ActionResult Details(int id)
        {
            //details of a product
            product productModel = new product();
            using(DBModels dbModel=new DBModels())
            {
                productModel = dbModel.products.Where(x => x.ProductID == id).FirstOrDefault();
            }
            return View(productModel);
        }

        // GET: Product/Create
        public ActionResult Create()
        {
            return View(new product());
        }

        // POST: Product/Create
        [HttpPost]
        public ActionResult Create(product productModel)
        {
            //add new product to database
            using (DBModels dbModel=new DBModels())
            {
                dbModel.products.Add(productModel);
                dbModel.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        // GET: Product/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Product/Edit/5
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

        // GET: Product/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Product/Delete/5
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
