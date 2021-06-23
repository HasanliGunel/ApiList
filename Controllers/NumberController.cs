using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api_list.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NumberController : ControllerBase
    {


        [HttpGet]
        public IActionResult Get()
        {
            Number num = new Number();
            num.numbers = new List<int>() { 1, 2, 3 };
            num.numbers.Add(1);
            num.numbers.Add(5);
            for (int i = 0; i < num.numbers.Count; i++)
            {
                num.numbers[i] = num.numbers[i] + 5;
            }
            return Ok(num.numbers);
        }

        
    }
}
