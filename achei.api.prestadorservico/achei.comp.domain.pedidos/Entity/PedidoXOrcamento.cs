using System;
using System.Collections.Generic;
using System.Text;

namespace achei.comp.domain.pedidos.Entity
{
    public class PedidoXOrcamento
    {
        public int ID { get; set; }
        public int PedidoID { get; set; }
        public int OrcamentoID { get; set; }
    }
}
