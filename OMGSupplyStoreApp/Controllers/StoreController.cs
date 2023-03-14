using DAL.DataContext;
using Invoices.DAL.Interfaces;
using Invoices.DAL.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OMGSupplyStoreApp.Data;
using OMGSupplyStoreApp.Models;
using OMGSupplyStoreApp.Repositories;
using System.Diagnostics;

namespace OMGSupplyStoreApp.Controllers
{
    public class StoreController : Controller
    {
        private readonly IRepositoryAsync<Product> _product;
        private readonly ApplicationDbContext _db;

        public StoreController(IRepositoryAsync<Product> product, ApplicationDbContext db)
        {
            _product = product;
            _db = db;
        }

        // GET: StoreController

        //Index method original line
        //public ActionResult Index()
        //{
        //    return View();
        //}

        //Index method Version 2

        public IActionResult Index()
        {
            var dbItem = _db.Products.ToList();

            //IEnumerable<Product> productList = dbItem;
            IEnumerable<Product> productList2 = _db.Products.ToList();
            return View(productList2);
        }
        //EROR: InvalidOperationException: Unable to resolve service for type 'Invoices.DAL.Interfaces.IRepositoryAsync`1[Invoices.DAL.Models.Product]' while attempting to activate 'OMGSupplyStoreApp.Controllers.StoreController'.


        //ERROR: InvalidOperationException: Unable to resolve service for type 'Invoices.DAL.Interfaces.IRepositoryAsync`1[Invoices.DAL.Models.Product]' while attempting to activate 'OMGSupplyStoreApp.Controllers.StoreController'.


        //GET: product list 
        //public IActionResult ProducList()
        //{
        //    IEnumerable<Product> productList = _product.Products.ToList();
        //    return View(productList);
        //}


        //this is the same method in the file invoices.DAL.Controller.ProductController
        public async Task<IEnumerable<Product>> GetProducts()
        {
            return await _product.GetAll();
        }



        //The method "productList" dont work maybe for a dependency injection issue

        //public async Task<IActionResult> ProductList(int productId)
        //{
        //    IEnumerable<Product> product = await _product.GetProducts(productId);
        //    ProductDisplayModel productModel = new ProductDisplayModel
        //    {
        //        Products = product,
        //    };
        //    return View(productModel);
        //}






        // GET: StoreController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: StoreController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: StoreController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: StoreController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: StoreController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: StoreController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: StoreController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
