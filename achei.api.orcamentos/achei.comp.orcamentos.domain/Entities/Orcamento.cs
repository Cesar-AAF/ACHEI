namespace achei.comp.orcamentos.domain.Entities
{
    public class Orcamento : Base
    {
		public int OrcamentoServicoID { get; set; }
		public string Descricao { get; set; }
		public int StatusID { get; set; }
		public decimal Valor { get; set; }
	}
}
