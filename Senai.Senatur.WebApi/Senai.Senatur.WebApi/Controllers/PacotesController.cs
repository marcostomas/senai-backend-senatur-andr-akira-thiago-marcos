using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Senai.Senatur.WebApi.Domains;
using Senai.Senatur.WebApi.Interfaces;
using Senai.Senatur.WebApi.Repositories;

namespace Senai.Senatur.WebApi.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class PacotesController : ControllerBase
    {
        private IPacotesRepository _pacotesRepository;

        public PacotesController()
        {
            _pacotesRepository = new PacotesRepository();
        }


        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_pacotesRepository.ListarTodos());
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok(_pacotesRepository.BuscarPorId(id));
        }

        [HttpPost]
        public IActionResult Insert (TabelaPacotes novoPacote)
        {
            _pacotesRepository.CadastrarPacote(novoPacote);

            return Ok("Pacote criado com sucesso");
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, TabelaPacotes pacoteAtualizado)
        {
            _pacotesRepository.AtualizarPacote(id, pacoteAtualizado);

            return StatusCode(204);
        }
    }
}