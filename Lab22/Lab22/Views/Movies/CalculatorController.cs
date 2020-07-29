using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MockAssessment5.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MockAssessment5.Controllers
{
    public class CalculatorController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }
       
        public IActionResult Result(Calculator calculator)
        {
            if(calculator.Operation == OperationType.Plus)
            {
                ViewBag.Result = calculator.Num1 + calculator.Num2;
            }
            else if (calculator.Operation == OperationType.Minus)
            {
                ViewBag.Result = calculator.Num1 - calculator.Num2;
            }
            else if (calculator.Operation == OperationType.Multiply)
            {
                ViewBag.Result = calculator.Num1 * calculator.Num2;
            }
            else if (calculator.Operation == OperationType.Divide)
            {
                ViewBag.Result = calculator.Num1 / calculator.Num2;
            }

            ViewBag.Operation = calculator.Operation;

            return View(calculator);
        }
    }
}
