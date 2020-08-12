namespace achei.comp.domain.prestadorservico.Entity
{
    public class PrestadorServico
    {
		public string CNPJ { get; set; }
		public string Nome { get; set; }
		public string Email { get; set; }
		public string Senha { get; set; }
		public string DDD { get; set; }
		public string Telefone { get; set; }
		public string Status { get; set; }
		public int EnderecoID { get; set; }
		public string Descricao { get; set; }
		public string PrestadorServicoAvaliacaoID { get; set; }
		public string SaldoID { get; set; }
	}
}
