using devPartnerTest.Entities;
using Microsoft.EntityFrameworkCore;

namespace devPartnerTest.Data
{
    public class devPartnerContext : DbContext
    {
        protected devPartnerContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<NotaFiscal> MyProperty { get; set; }
    }
}