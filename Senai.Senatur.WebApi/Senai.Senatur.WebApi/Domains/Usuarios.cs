using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Senai.Senatur.WebApi.Domains
{
    public partial class Usuarios
    {
        public int IdUsuario { get; set; }
        [Required(ErrorMessage ="Informe o e-mail")]
        [DataType(DataType.EmailAddress)]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage ="Informe um email válido...")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Informa a sua senha")]
        [DataType(DataType.Password)]
        [StringLength(12, MinimumLength = 6, ErrorMessage ="O campo senha precisa ter no mínimo 6 caracteres")]
        public string Senha { get; set; }
        public int? IdTipoUsuario { get; set; }

        public TipoUsuario IdTipoUsuarioNavigation { get; set; }
    }
}
