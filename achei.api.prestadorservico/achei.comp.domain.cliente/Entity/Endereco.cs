using System;
using System.Collections.Generic;
using System.Text;

namespace achei.comp.domain.cliente.Entity
{
    public class Endereco
    {
        public int ID { get; set; }
        public string Logradouro { get; set; }
        public int Numero { get; set; }
        public string Bairro { get; set; }
        public string  CEP { get; set; }
        public string Complemento { get; set; }
        public int CidadeID { get; set; }
    }
}
