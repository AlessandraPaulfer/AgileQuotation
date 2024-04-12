using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AgileQuotation.API.Models;
using Microsoft.EntityFrameworkCore;

namespace AgileQuotation.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<QuotationSupplier> QuotationSupplier { get; set; }
        public DbSet<QuotationProduct> QuotationProduct { get; set; }
    }
}