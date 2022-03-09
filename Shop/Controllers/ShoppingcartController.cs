using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Shop.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ShoppingcartController : ControllerBase
    {
        private readonly ILogger<ShoppingcartController> _logger;

        public ShoppingcartController(ILogger<ShoppingcartController> logger)
        {
            _logger = logger;
        }
        
        [HttpGet ("{productName}/{productPrice}")]
        public IEnumerable<Product> AddToCart(String productName, double productPrice)
        {
            return Enumerable.Range(1,1).Select(index => new Product(productName, productPrice)
            {
                Name = productName,
                Price = productPrice
            }).ToArray();
        }
    }
}