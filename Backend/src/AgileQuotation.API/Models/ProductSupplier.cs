using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgileQuotation.API.Models
{
    public class ProductSupplier
    {
        public int ProductSupplierId { get; set; }
        public DateTime Date { get; set; }
        public int SKU { get; set; }
        public string Description { get; set; }
        public decimal UnitBox { get; set; }
        public decimal Weigth { get; set; }
        public TypeUnit TypeUnit { get; set; }
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
        public TypeSituation TypeSituation { get; set; }
        public TypeSKUPositive TypeSKUPositive { get; set; }
        public TypeIndAtac TypeIndAtac { get; set; }
        public decimal CountBySKU { get; set; }
        public StatusProduct StatusProduct { get; set; }
        public List<QuotationSupplier> QuotationSupplier { get; set; }
    }

    public enum TypeUnit
    {

    }
    public enum TypeSituation
    {

    }
    public enum TypeSKUPositive
    {

    }
    public enum TypeIndAtac
    {

    }

    public enum StatusProduct
    {

    }
}