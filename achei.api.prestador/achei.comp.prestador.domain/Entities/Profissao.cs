namespace achei.comp.prestador.domain.Entities
{
    public class Profissao : Base
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
		public string PrestadorAvaliacaoID { get; set; }
		public string SaldoID { get; set; }
	}
}
