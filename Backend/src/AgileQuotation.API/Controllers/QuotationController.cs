using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AgileQuotation.API.Data;
using AgileQuotation.API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace AgileQuotation.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class QuotationController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        // private readonly ILogger<QuotationController> _logger;

        public QuotationController(ILogger<QuotationController> logger)
        {
            
        }

        // public QuotationController(ILogger<QuotationController> logger)
        // {
        //     _logger = logger;
        // }
        
        private readonly DataContext _context;
        public QuotationController (DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<ProductSupplier> Get()
        {
            return _context.ProductSupplier;
        }
    }
}
