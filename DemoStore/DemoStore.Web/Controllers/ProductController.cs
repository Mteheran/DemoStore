using DemoStore.Web.Models;
using DemoStore.Web.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace DemoStore.Web.Controllers
{
    public class ProductController : Controller
    {
        Services.StoreService service { get; set; }

        public ProductController()
        {
            service = new Services.StoreService();
        }


        // GET: Product
        public async Task<ActionResult> Index()
        {
            await LoadDropDownLists();

            return View(await service.GetProducts());
        }

        // GET: Product/Details/5
        public async Task<ActionResult> Details(int id)
        {
            return View();
        }

        // GET: Product/Create
        public async Task<ActionResult> Create()
        {
            await LoadDropDownLists();
            return View();
        }

        // POST: Product/Create
        [HttpPost]
        public async Task<ActionResult> Create(ProductViewModel product)
        {
            try
            {
                await LoadDropDownLists();

                await service.SaveProduct(product);

                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                return View();
            }
        }

        // GET: Product/Edit/5
        public async Task<ActionResult> Edit(int id)
        {
            return View();
        }

        // POST: Product/Edit/5
        [HttpPost]
        public async Task<ActionResult> Edit(Product product)
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
        public ActionResult Delete()
        {
            return View();
        }

        // POST: Product/Delete/5
        [HttpPost]
        public ActionResult Delete(int id)
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

        private async Task LoadDropDownLists()
        {

            var result = await service.GetCategories();

            ViewBag.Categories = new MultiSelectList(result, "Id", "Name");
        }
    }
}
