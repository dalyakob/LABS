using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GiphyAPI.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GiphyAPI.Controllers
{
    public class GiphyController : Controller
    {
        private readonly IGiphyService _giphyService;

        public GiphyController(IGiphyService giphyService)
        {
            _giphyService = giphyService;
        }

        // GET: /<controller>/
        public async Task<IActionResult> IndexAsync()
        {
            var model = await _giphyService.GetAll();

            return View(model);
        }
    }
}
