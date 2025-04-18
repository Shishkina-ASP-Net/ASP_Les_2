using Microsoft.AspNetCore.Mvc;
using ClassLibrary1;
using ASP_Les_2.Models;
namespace ASP_Les_2.Controllers
{
    public class CalculatorController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View(new Calculator());
        }
        [HttpPost]
        public IActionResult Index(Calculator calculator)
        {
            var class1 = new Class1();
            switch (calculator.Operator)
            {
                case OperationType.Addition:
                    calculator.Result = class1.Add(calculator.FirstNumber, calculator.SecondNumber);
                    break;
                case OperationType.Subtraction:
                    calculator.Result = class1.Subtract(calculator.FirstNumber, calculator.SecondNumber);
                    break;
                case OperationType.Multiplication:
                    calculator.Result = class1.Multiply(calculator.FirstNumber, calculator.SecondNumber);
                    break;
                case OperationType.Division:
                    calculator.Result = class1.Divide(calculator.FirstNumber, calculator.SecondNumber);
                    break;
                default:
                    ModelState.AddModelError("", "Такой операции не существует");
                    break;
            }
            return View(calculator);
        }
    }

}
