using Invoices.DAL.Interfaces;
using Invoices.DAL.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OMGSupplyStoreApp.Models;
using OMGSupplyStoreApp.Repositories;
using System.Diagnostics;

namespace OMGSupplyStoreApp.Controllers
{
    public class StoreController : Controller
    {
        private readonly IProductRepository _product;

        public StoreController(IProductRepository product)
        {
            _product = product;
        }

        // GET: StoreController
        public ActionResult Index()
        {
            return View();
        }

        //GET: product list 
        public IActionResult ProducList()
        {
            IEnumerable<Product> productList = _product.GetAll().ToList();
            return View(productList);
        }


        //public async Task<IActionResult> ProductList(int productId)
        //{
        //    IEnumerable<Product> product = await _product.GetAll(productId);
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
