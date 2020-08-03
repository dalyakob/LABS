using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Week4Capstone.Data;
using Week4Capstone.Models;
using Newtonsoft.Json;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Week4Capstone.Controllers
{
    public class StoreController : Controller
    {
        private readonly StoreContext _context;
        //private readonly ILogger<StoreController> _logger;
        private readonly ISession _session;

        public StoreController(StoreContext context, IHttpContextAccessor accessor)
        {
            _context = context;
            //_logger = logger;
            _session = accessor.HttpContext.Session;

        }

        // GET: /<controller>/
        public async Task<IActionResult> Index()
        {
            ViewData["Title"] = "Our Products";

            List<Product> list = _session.Keys.Any(x => x == "Cart")
                ? JsonConvert.DeserializeObject<List<Product>>(_session.GetString("Cart"))
                : new List<Product>();
            
            ViewBag.Count = list.Count.ToString();

            return View(await _context.Products.ToListAsync());
        }

        public async Task<IActionResult> AddToCart(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Products
                .FirstOrDefaultAsync(x => x.ProductID == id);
            if (product == null)
            {
                return NotFound();
            }

            List<Product> list = _session.Keys.Any(x => x == "Cart")
                ? JsonConvert.DeserializeObject<List<Product>>(_session.GetString("Cart"))
                : new List<Product>();

            list.Add(product);

            _session.SetString("Cart", JsonConvert.SerializeObject(list));

            TempData["Success"] = $"Successfully added {product.Name} to cart!";

            return RedirectToAction("Index");
        }

        public IActionResult CheckOut()
        {
            ViewData["Title"] = "Checkout";

            List<Product> list = _session.Keys.Any(x => x == "Cart")
            ? JsonConvert.DeserializeObject<List<Product>>(_session.GetString("Cart"))
            : new List<Product>();

            ViewBag.Total = 0.0;

            foreach (var item in list)
            {
                ViewBag.Total = list.Sum(i => i.Price);
            }


            return View(list);
        }
    }
}
