using System;

namespace achei.api.orcamentosservico.Models
{
    public class OrcamentoModel
    {

        public int OrcamentoServicoID { get; set; }
        public string Descricao { get; set; }
        public int StatusID { get; set; }
        public decimal Valor { get; set; }
    }
}
