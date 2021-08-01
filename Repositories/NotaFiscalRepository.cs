using devPartnerTest.Data;
using devPartnerTest.Entities;

namespace devPartnerTest.Repositories
{
    public class NotaFiscalRepository : BaseRepository<NotaFiscal>, IBaseRepository<NotaFiscal>
    {
        public NotaFiscalRepository(devPartnerContext context) : base(context)
        {
        }
    }
}