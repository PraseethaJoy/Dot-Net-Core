using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace WebApplication2.Controllers
{
    [Route("api/default")]
    [ApiController]
    public class DefaultController : ControllerBase
    {
        private readonly Address _addressConfig;
        private readonly Configurations _config;

        public DefaultController(IOptions<Address>addconfig, IOptions<Configurations>config)
        {
            _addressConfig = addconfig.Value;
            _config = config.Value;
        }
        [HttpGet]
        [Route("product")]
        public void TestMethod()
        {
           Address ad = _addressConfig;
            Address ad2 = _config.Address;
            int a = 10;
        }
    }
}