using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using WebApi.Models;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        public OrderController()
        {

        }

        [HttpPost("{systemType}")]
        public IActionResult PostOrder(string systemType, [FromBody] OrderData value, CancellationToken cancellationToken)
        {
            return Ok();
        }
    }

}
