using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgileQuotation.Domain
{
    public class ProductSupplier
    {
        public int QuotationProductId { get; set; }
        public QuotationProduct QuotationProduct { get; set; }
        public int QuotationSupplierId { get; set; }
        public QuotationSupplier QuotationSupplier { get; set; }
    }
}