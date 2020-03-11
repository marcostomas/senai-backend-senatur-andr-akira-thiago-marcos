using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Senai.Senatur.WebApi.Interfaces;
using Senai.Senatur.WebApi.Repositories;

namespace Senai.Senatur.WebApi.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        private IUsuarioRepository _usuarioRepository;

        public UsuariosController()
        {
            _usuarioRepository = new UsuarioRepository();
        }


        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_usuarioRepository.Listar());
        }

        [HttpGet("{tipo}")]
        public IActionResult GetTodos()
        {
            return Ok(_usuarioRepository.ListarTipoUsuario());
        }
    }
}