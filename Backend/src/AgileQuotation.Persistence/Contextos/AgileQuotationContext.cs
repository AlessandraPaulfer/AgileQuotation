using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AgileQuotation.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using AgileQuotation.Domain.Identity;


namespace AgileQuotation.Persistence.Contextos
{
    public class AgileQuotationContext : IdentityDbContext<User, Role, int, 
                                                       IdentityUserClaim<int>, UserRole, IdentityUserLogin<int>, 
                                                       IdentityRoleClaim<int>, IdentityUserToken<int>>
    {
         public AgileQuotationContext(DbContextOptions<AgileQuotationContext> options) 
            : base(options) { }
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