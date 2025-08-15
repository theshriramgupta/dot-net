using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq; // Needed for Take()

namespace YourNamespace.Controllers
{
    public class CalculatorController : Controller
    {
        public IActionResult Index()
        {
            // Load recent calculations from Session
            var recent = HttpContext.Session.GetObjectFromJson<List<string>>("RecentCalcs") ?? new List<string>();
            ViewBag.Recent = recent;
            return View();
        }

        [HttpPost]
        public IActionResult Index(double number1, double number2, string operation)
        {
            double result = 0;
            switch (operation)
            {
                case "Add": result = number1 + number2; break;
                case "Subtract": result = number1 - number2; break;
                case "Multiply": result = number1 * number2; break;
                case "Divide": result = number2 != 0 ? number1 / number2 : 0; break;
            }

            // Retrieve old list from Session
            var recent = HttpContext.Session.GetObjectFromJson<List<string>>("RecentCalcs") ?? new List<string>();

            // Add the new calculation to the top
            recent.Insert(0, $"{number1} {operation} {number2} = {result}");

            // Keep only the last 5 entries
            if (recent.Count > 5)
                recent = recent.Take(5).ToList();

            // Save back to Session
            HttpContext.Session.SetObjectAsJson("RecentCalcs", recent);

            ViewBag.Result = result;
            ViewBag.Recent = recent;
            return View();
        }
    }
}
