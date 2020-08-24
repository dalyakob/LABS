using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinalCapstoneProject.Models;
using FinalCapstoneProject.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FinalCapstoneProject.Controllers
{
    public class CarsController : Controller
    {
        private readonly ICarService _service;

        public CarsController(ICarService service)
        {
            _service = service;
        }
        // GET: CarsController
        public async Task<ActionResult> Index()
        {
            var model = await _service.GetAll();
            return View(model);
        }

        // GET: CarsController/Details/5
        public async Task<ActionResult> Details(int id)
        {
            var model = await _service.Get(id);

            return View(model);
        }

        // GET: CarsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CarsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind("CarID,Make,Model,Year,Color")] Car car)
        {
            if(ModelState.IsValid)
            {
                await _service.Create(car);
                return RedirectToAction(nameof(Index));
            }
            
            return View();
        }

        // GET: CarsController/Edit/5
        public async Task<ActionResult> Edit(int id)
        {
            var model = await _service.Get(id);
            return View(model);
        }

        // POST: CarsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(int id, [Bind("CarID,Make,Model,Year,Color")] Car car)
        {
            if (ModelState.IsValid)
            {
                await _service.Edit(id, car);
                return RedirectToAction(nameof(Index));
            }
            
            return View();
            
        }

        // GET: CarsController/Delete/5
        public async Task<ActionResult> Delete(int id)
        {
            var model = await _service.Get(id);
            return View(model);
        }

        // POST: CarsController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Delete(int id, IFormCollection collection)
        {
            try
            {
                await _service.Delete(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
