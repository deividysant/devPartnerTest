using devPartnerTest.Models;
using Microsoft.EntityFrameworkCore;

namespace devPartnerTest.Data
{
    public class devPartnerContext : DbContext
    {
        public devPartnerContext(DbContextOptions<devPartnerContext> options) : base(options)
        {}

        public DbSet<NotaFiscal> NotaFiscais { get; set; }
    }
}