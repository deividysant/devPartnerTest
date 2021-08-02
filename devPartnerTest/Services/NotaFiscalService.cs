using System.Collections.Generic;
using System.Threading.Tasks;
using devPartnerTest.Data;
using devPartnerTest.Models;
using devPartnerTest.Repositories;

namespace devPartnerTest.Services
{
    public class NotaFiscalService : INotaFiscalService
    {
        private readonly IBaseRepository<NotaFiscal> _repository;

        public NotaFiscalService(IBaseRepository<NotaFiscal> repository)
        {
            _repository = repository;
        }

        public NotaFiscal GetById(int id)
        {
            return _repository.GetById(id);
        }

        public IEnumerable<NotaFiscal> GetAll()
        {
            return _repository.GetAll();
        }

        public bool Create(NotaFiscal notaFiscal)
        {
            return _repository.Add(notaFiscal) == true;
        }

        public bool Update(NotaFiscal notaFiscal)
        {
            return _repository.Update(notaFiscal) == true;
        }

        public bool Delete(int id)
        {
            return _repository.Delete(id) == true;
        }
    }
}