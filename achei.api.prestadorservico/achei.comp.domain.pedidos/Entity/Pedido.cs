using System;
using System.Collections.Generic;
using System.Text;

namespace achei.comp.domain.pedidos.Entity
{
    public class Pedido
    {
        public int ID { get; set; }
        public string Descricao { get; set; }
        public int ClienteID { get; set; }
        public int PedidoStatusID { get; set; }
    }
}
