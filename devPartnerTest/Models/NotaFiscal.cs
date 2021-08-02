using System;

namespace devPartnerTest.Models
{
    public class NotaFiscal : BaseEntity
    {
        public int numeroNf { get; set; }
        public double valorTotal { get; set; }
        public DateTime dataNf { get; set; }
        public string cnpjEmissorNf { get; set; }
        public string cnpjDestinatarioNf { get; set; }
    }
}