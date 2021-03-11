using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestWithASPNETUdemy.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculatorController : ControllerBase
    {
        private readonly ILogger<CalculatorController> _logger;
        

        public CalculatorController(ILogger<CalculatorController> logger)
        {
            _logger = logger;
        }

        [HttpGet("{operation}/{firstNumber}/{secondNumber}")]
        public IActionResult Get(string operation, string firstNumber, string secondNumber)
        {
            if(IsNumeric(firstNumber) && IsNumeric(secondNumber))
            {
                switch (operation)
                {
                    case "sum":
                        var sum = ConvertToDecimal(firstNumber) + ConvertToDecimal(secondNumber);
                        return Ok(sum.ToString());
                    case "sub":
                        var sub = ConvertToDecimal(firstNumber) - ConvertToDecimal(secondNumber);
                        return Ok(sub.ToString());
                    case "mult":
                        var mult = ConvertToDecimal(firstNumber) * ConvertToDecimal(secondNumber);
                        return Ok(mult.ToString());
                    case "div":
                        var div = ConvertToDecimal(firstNumber) / ConvertToDecimal(secondNumber);
                        return Ok(div.ToString());
                    default:
                        return BadRequest("Invalid Input");
                }
            }
            return BadRequest("Invalid Input");
        }

        private bool IsNumeric(string strNumber)
        {
            double number;
            bool IsNumber = double.TryParse
                (
                strNumber, 
                System.Globalization.NumberStyles.Any, 
                System.Globalization.NumberFormatInfo.InvariantInfo, 
                out number
                );
            return IsNumber;
        }

        private decimal ConvertToDecimal(string strNumber)
        {
            decimal decimalValue;
            if(decimal.TryParse(strNumber, out decimalValue))
            {
                return decimalValue;
            }
            return 0;
        }
    }
}