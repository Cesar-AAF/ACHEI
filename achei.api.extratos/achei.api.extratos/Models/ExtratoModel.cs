using System;

namespace achei.api.extratos.Models
{
    public class ExtratoModel
    {
        public DateTime? DataCriacao { get; set; }
        public int Id { get; set; }
        public int SaldoID { get; set; }
        public decimal ValorAnterior { get; set; }
        public decimal ValorPosterior { get; set; }
        public decimal ValorOperacao { get; set; }
        public int TipoOperacaoID { get; set; }
        public DateTime DataOperacao { get; set; }
    }
}