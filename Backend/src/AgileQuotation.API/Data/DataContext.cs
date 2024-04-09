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
        public DbSet<ProductSupplier> ProductSupplier { get; set; }
        public DbSet<QuotationSupplier> QuotationSupplier { get; set; }
    }
}