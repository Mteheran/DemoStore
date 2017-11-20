using DemoStore.Web.Models;
using System;
using System.Threading.Tasks;
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

    

        private async Task LoadDropDownLists()
        {

            var result = await service.GetCategories();

            ViewBag.Categories = new MultiSelectList(result, "Id", "Name");
        }
    }
}
