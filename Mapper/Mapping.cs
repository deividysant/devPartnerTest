using AutoMapper;
using devPartnerTest.Models;
using devPartnerTest.Models.ViewModel;

namespace devPartnerTest.Mapper
{
    public class Mapping : Profile 
    {
        public Mapping()
        {
            CreateMap<NotaFiscalPostViewModel, NotaFiscal>();
        }
    }
}