using System;
using System.Collections.Generic;
using System.Text;

namespace achei.comp.domain.orcamentos.Entity
{
    public class Orcamento
    {
        public int ID { get; set; }
        public int PrestadorServicoID { get; set; }
        public string Descricao { get; set; }
        public int OrcamentoStatusID { get; set; }
        public float Valor { get; set; }
    }
}
