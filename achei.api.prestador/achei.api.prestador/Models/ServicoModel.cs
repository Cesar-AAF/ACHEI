using System;

namespace achei.api.prestador.Models
{
    public class ServicoModel
	{
		public int Id { get; set; }
		public string CNPJ { get; set; }
		public string Nome { get; set; }
		public string Email { get; set; }
		public string Senha { get; set; }
		public string DDD { get; set; }
		public string Telefone { get; set; }
		public string Status { get; set; }
		public int EnderecoID { get; set; }
		public string Descricao { get; set; }
		public int PrestadorServicoAvaliacaoID { get; set; }
		public int SaldoID { get; set; }
    }
}
