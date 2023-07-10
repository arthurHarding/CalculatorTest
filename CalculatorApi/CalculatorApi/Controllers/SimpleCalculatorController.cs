using Microsoft.AspNetCore.Mvc;
using CalculatorTest;

namespace CalculatorWebService.Controllers
{
    [Route("api/simplecalculator")]
    [ApiController]
    public class SimpleCalculatorController
    {
        [HttpGet("add/{start}/{amount}")]
        public int Add(int start, int amount)
        {
            var calculator = new SimpleCalculator();
            return calculator.Add(start, amount);
        }

        [HttpGet("subtract/{start}/{amount}")]
        public int Subtract(int start, int amount)
        {
            var calculator = new SimpleCalculator();
            return calculator.Subtract(start, amount);
        }
    }
}
