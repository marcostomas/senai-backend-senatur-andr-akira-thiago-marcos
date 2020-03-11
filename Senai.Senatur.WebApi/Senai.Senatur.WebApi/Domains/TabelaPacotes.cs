using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Senai.Senatur.WebApi.Domains
{
    public partial class TabelaPacotes
    {
        public int IdPacote { get; set; }
        [Required]
        public string NomePacote { get; set; }
        public string Descricao { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime DataIda { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime DataVolta { get; set; }
        [Required]
        [DisplayFormat(DataFormatString ="{0,c}")]
        public float Valor { get; set; }
        public bool Ativo { get; set; }
        public string NomeCidade { get; set; }
    }
}
