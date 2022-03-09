using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Text.Json;

namespace Shop.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ShoppingcartController : ControllerBase
    {
        private readonly List<Product> _productCart = new List<Product>();
        private readonly ILogger<ShoppingcartController> _logger;

        public ShoppingcartController(ILogger<ShoppingcartController> logger)
        {
            _logger = logger;
        }
        
        [HttpGet ("{productName}/{productPrice}")]
        public string AddToCart(String productName, double productPrice)
        {
            _productCart.Add(new Product(productName, productPrice));

            return JsonSerializer.Serialize(_productCart);
        }
    }
}