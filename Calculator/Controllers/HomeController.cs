using Calculator.Models;
using Microsoft.AspNetCore.Mvc;

namespace Calculator.Controllers
{
    public class HomeController : Controller
    {
        // GET
        public IActionResult Index(Operations calc )
        {
            return View(calc);
        }
        
        
        [HttpPost]
        public IActionResult Calculate(Operations calc)
        {
            calc.result = CalculateResult(calc);

            return RedirectToAction("Index", calc);


        }

        private double CalculateResult(Operations calc)
        {
            double result = 0;
            switch (calc.operation)
            {
                case "+":
                {
                    result = calc.firstNum + calc.secondNum;
                }
                    break;
                case "-":
                {
                    result = calc.firstNum - calc.secondNum;
                }
                    break;
                case "*":
                {
                    result = calc.firstNum * calc.secondNum;
                }
                    break;
                case "/":
                {
                    result = calc.firstNum / calc.secondNum;
                }
                    break;

            }

            return result;
        }
    }
}