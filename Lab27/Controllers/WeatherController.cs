using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab27.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Lab27.Controllers
{
    public class WeatherController : Controller
    {
        private readonly IWeatherService _weatherService;

        public WeatherController(IWeatherService weatherService)
        {
            _weatherService = weatherService;
        }
        public async Task<IActionResult> Index()
        {
            var model = await _weatherService.GetAll();
            return View(model);
        }
    }
}
