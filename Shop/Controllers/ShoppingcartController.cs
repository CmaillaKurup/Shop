using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Shop.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ShoppingcartController : ControllerBase
    {
        //private readonly ILogger<ShoppingcartController> _logger;
        private readonly IHttpContextAccessor _httpContextAccessor = new HttpContextAccessor();
        private ISession _session => _httpContextAccessor.HttpContext?.Session;
        public ShoppingcartController()
        {
            
        }
        
        [HttpGet ]
        public IEnumerable<Person> AddToCart(string productName, string lastname)
        {
            return Enumerable.Range(1,1).Select(index => new Person(productName, lastname)
            {
                Name = productName,
                Lastname = lastname
            }).ToArray();
        }
    }
}