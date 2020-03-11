using Senai.Senatur.WebApi.Domains;
using Senai.Senatur.WebApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Senatur.WebApi.Repositories
{
    public class PacotesRepository : IPacotesRepository
    {

        SenaTurContext ctx = new SenaTurContext();




        public List<TabelaPacotes> ListarTodos()
        {
            return ctx.TabelaPacotes.ToList();
        }

        public TabelaPacotes BuscarPorId(int id)
        {
            return ctx.TabelaPacotes.FirstOrDefault(t=>t.IdPacote == id);
        }

        public void CadastrarPacote(TabelaPacotes novoPacote)
        {
            ctx.TabelaPacotes.Add(novoPacote);

            ctx.SaveChanges();

        }

        public void AtualizarPacote(int id, TabelaPacotes pacoteAtualizado)
        {
            TabelaPacotes pacoteBuscado =  ctx.TabelaPacotes.Find(id);

            pacoteBuscado.NomePacote = pacoteAtualizado.NomePacote;
            pacoteBuscado.Descricao = pacoteAtualizado.Descricao;
            pacoteBuscado.DataIda = pacoteAtualizado.DataIda;
            pacoteBuscado.DataVolta = pacoteAtualizado.DataVolta;
            pacoteBuscado.Valor = pacoteAtualizado.Valor;
            pacoteBuscado.Ativo = pacoteAtualizado.Ativo;
            pacoteBuscado.NomeCidade = pacoteAtualizado.NomeCidade;

            ctx.TabelaPacotes.Update(pacoteAtualizado);
            ctx.SaveChanges();
        }
    }
}
