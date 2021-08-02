using System;

namespace devPartnerTest.Models.ViewModel
{
    public class NotaFiscalPostViewModel
    {
        public int numeroNf { get; set; }
        public double valorTotal { get; set; }
        public string cnpjEmissorNf { get; set; }
        public string cnpjDestinatarioNf { get; set; }
    }
}