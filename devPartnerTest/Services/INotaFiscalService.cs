using System.Collections.Generic;
using System.Threading.Tasks;
using devPartnerTest.Models;

namespace devPartnerTest.Services
{
    public interface INotaFiscalService
    {
        NotaFiscal GetById(int id);
        IEnumerable<NotaFiscal> GetAll();
        bool Create(NotaFiscal notaFiscal);
        bool Update(NotaFiscal notaFiscal);
        bool Delete(int id);
    }
}