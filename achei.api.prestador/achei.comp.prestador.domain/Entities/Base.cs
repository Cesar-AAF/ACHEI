﻿using System;

namespace achei.comp.prestador.domain.Entities
{
    public class Base
    {
        public int Id { get; set; }

        private DateTime? _DataCriacao { get; set; }

        public DateTime? DataCriacao
        {
            get
            {
                return _DataCriacao.HasValue ? _DataCriacao.Value : DateTime.Now;
            }
            set { _DataCriacao = value; }
        }
    }
}
