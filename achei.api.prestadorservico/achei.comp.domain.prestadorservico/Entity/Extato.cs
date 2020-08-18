using System;
using System.Collections.Generic;
using System.Text;

namespace achei.comp.domain.prestadorservico.Entity
{
    public class Extato
    {
        public int ID { get; set; }
        public int SaldoID { get; set; }
        public float ValorAnterior { get; set; }
        public float ValorPosterior { get; set; }
        public float ValorOperacao { get; set; }
        public int TipoOperacaoID { get; set; }
        public DateTime DataOperacao { get; set; }
    }
}
