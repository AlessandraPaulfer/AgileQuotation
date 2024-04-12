using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgileQuotation.API.Models
{
    public class ProductSupplier
    {
        public int QuotationProductId { get; set; }
        public int QuotationSupplierId { get; set; }
    }
}