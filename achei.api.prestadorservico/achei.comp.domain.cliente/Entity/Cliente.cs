﻿using System;
using System.Collections.Generic;
using System.Text;

namespace achei.comp.domain.cliente.Entity
{
    public class Cliente
    {
        public int ID { get; set; }
        public string CPF { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string DDD { get; set; }
        public string Telefone { get; set; }
        public string Status { get; set; }
        public int EnderecoID { get; set; }
        public DateTime DataCriacao { get; set; }
    }
}
