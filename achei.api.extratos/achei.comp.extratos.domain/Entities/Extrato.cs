using System;

namespace achei.comp.extratos.domain.Entities
{
    public class Extrato : Base
    {
		public int SaldoID { get; set; }
		public decimal ValorAnterior { get; set; }
		public decimal ValorPosterior { get; set; }
		public decimal ValorOperacao { get; set; }
		public int TipoOperacaoID { get; set; }
		public DateTime DataOperacao { get; set; }
	}
}
