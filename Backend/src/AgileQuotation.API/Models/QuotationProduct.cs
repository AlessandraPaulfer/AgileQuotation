using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgileQuotation.API.Models
{
    public class QuotationProduct
    {
        public int QuotationProductId { get; set; }
        public int SKU { get; set; }
        public string Description { get; set; }
        public decimal Weigth { get; set; }
        public Enum Unit { get; set; }
        public decimal LastPurchase { get; set; }
        public DateTime BoardingDate { get; set; }
        public decimal LastValidate { get; set; }
        public string LastMonthValidate { get; set; }
        public string LastSupplier { get; set; }
        public string Group { get; set; }
        public string SubGroup { get; set; }
        public string Category { get; set; }
        public string Brand { get; set; }
        public string SubBrand { get; set; }
        public Enum Situation { get; set; }
        public Enum SKUPositive { get; set; }
        public Enum IndAtac { get; set; }
        public decimal CountBySKU { get; set; }
    }
}