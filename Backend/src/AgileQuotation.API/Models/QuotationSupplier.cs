using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgileQuotation.API.Models
{
    public class QuotationSupplier
    {
        public int QuotationSupplierId { get; set; }
        public string Name { get; set; }
        public bool State { get; set; }
        public decimal Price { get; set; }
        public List<QuotationProduct> Products { get; set; }
        public QuotationSupplier()
        {
            Products = new List<QuotationProduct>();
        }
    }
}