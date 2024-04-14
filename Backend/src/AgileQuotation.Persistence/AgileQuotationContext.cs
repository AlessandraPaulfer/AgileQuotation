using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AgileQuotation.Domain;
using Microsoft.EntityFrameworkCore;

namespace AgileQuotation.Persistence
{
    public class  AgileQuotationContext: DbContext
    {
        public AgileQuotationContext(DbContextOptions<AgileQuotationContext> options) : base(options) { }
        public DbSet<QuotationSupplier> QuotationSuppliers { get; set; }
        public DbSet<QuotationProduct> QuotationProducts { get; set; }
        public DbSet<ProductSupplier> ProductSuppliers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        // Configurar o mapeamento das relações entre as entidades aqui

        // Mapeamento da classe ProductSupplier
        modelBuilder.Entity<ProductSupplier>()
            .HasKey(PE => new { PE.QuotationProductId, PE.QuotationSupplierId });
        }
    }
}