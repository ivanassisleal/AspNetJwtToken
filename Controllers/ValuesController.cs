using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AspNetJwtToken.Controllers
{

    [Route("api/[controller]")]
    public class ValuesController : Controller
    {

        [Authorize]
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        [Authorize(Policy = "OnlyValidUsers")]
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

    }
}
