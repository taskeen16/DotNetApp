using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SimpleApp.Models;

namespace SimpleApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        List<Product> _products = new List<Product>()
        {
            new Product(){ProductID = 0, ProductName= "Laptop", ProductPrice="500" },
            new Product(){ProductID = 1, ProductName= "TV", ProductPrice="200" }
    };
        public IEnumerable<Product> Get()
        {
            return _products;
        }
    }
}