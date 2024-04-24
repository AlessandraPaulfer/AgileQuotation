using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using AgileQuotation.Persistence.Contextos;
using AgileQuotation.Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace AgileQuotation.API.Controllers
{
    [Authorize]
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
        
        private readonly AgileQuotationContext _context;
        public QuotationController (AgileQuotationContext context)
        {
            _context = context;
        }

        // [HttpGet]
        // public IEnumerable<ProductSupplier> Get()
        // {
        //     return _context.ProductSupplier;
        // }
    }
}
