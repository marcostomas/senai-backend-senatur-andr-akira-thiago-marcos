using System;
using System.Collections.Generic;

namespace Senai.Senatur.WebApi.Domains
{
    public partial class TabelaPacotes
    {
        public int IdPacote { get; set; }
        public string NomePacote { get; set; }
        public string Descricao { get; set; }
        public DateTime DataIda { get; set; }
        public DateTime DataVolta { get; set; }
        public float Valor { get; set; }
        public bool Ativo { get; set; }
        public string NomeCidade { get; set; }
    }
}
