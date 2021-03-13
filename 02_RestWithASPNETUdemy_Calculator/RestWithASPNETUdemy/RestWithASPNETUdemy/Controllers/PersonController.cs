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
    public class PersonController : ControllerBase
    {
        private readonly ILogger<PersonController> _logger;


        public PersonController(ILogger<PersonController> logger)
        {
            _logger = logger;
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
            if (decimal.TryParse(strNumber, out decimalValue))
            {
                return decimalValue;
            }
            return 0;
        }

        [HttpGet("{operation}/{firstNumber}/{secondNumber}")]
        public IActionResult Operation(string operation, string firstNumber, string secondNumber)
        {
            
            return BadRequest("Invalid Input");
        }
    }
}