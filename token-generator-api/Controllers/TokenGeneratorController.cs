using Microsoft.AspNetCore.Mvc;
using System;

namespace token_generator_api.Controllers
{
    public class TokenGeneratorController : Controller
    {
        [HttpGet("/token")]
        public string Index()
        {
            return Guid.NewGuid().ToString("N");
        }
    }
}

//https://dev.to/jtenos/net-guid-formats-3koa
//GUID Formats