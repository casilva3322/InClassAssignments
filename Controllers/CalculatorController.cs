using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyWebCalculator.Models;

using MathLibrary;

namespace MyWebCalculator.Controllers
{
    public class ConverterController : Controller
    {
        public IActionResult Add(decimal left, decimal right)
        {
            ViewData["Left"] = left;
            ViewData["Right"] = right;
            ViewData["AddResult"] = $"{left} plus {right} is: {MyMathRoutines.Add(left, right)}";
            return View();
        }
        public IActionResult Subtract(decimal left, decimal right)
        {
            ViewData["Left"] = left;
            ViewData["Right"] = right;
            ViewData["SubtractResult"] = $"{left} minus {right} is: {MyMathRoutines.Subtract(left, right)}";
            return View();
        }
        public IActionResult Multiply(decimal left, decimal right)
        {
            ViewData["Left"] = left;
            ViewData["Right"] = right;
            ViewData["MultiplyResult"] = $"{left} times {right} is: {MyMathRoutines.Multiply(left, right)}";
            return View();
        }
        public IActionResult Divide(decimal left, decimal right)
        {
            ViewData["Left"] = left;
            ViewData["Right"] = right;
            ViewData["DivideResult"] = $"{left} divided by {right} is: {MyMathRoutines.Multiply(left, right)}";
            return View();
        }
         public IActionResult Power(double number, double power)
         {
            ViewData["Left"] = number;
            ViewData["Right"] = power;
            ViewData["PowerResult"] = $"{number} to the power of {power} is:{MyMathRoutines.Power(number,power)}";
            return View();
         }

        public string Ceiling(decimal number)
        {
            return $"The ceiling of {number} is {MyMathRoutines.Ceiling(number)}";
        }
        public string Floor(decimal number)
        {
            return $"The Floor of {number} is {MyMathRoutines.Floor(number)}";
        }        
    }
}