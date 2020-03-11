using Senai.Senatur.WebApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Senatur.WebApi.Interfaces
{
    interface IPacotesRepository
    {
        List<TabelaPacotes> ListarTodos();

        TabelaPacotes BuscarPorId(int id);

        void CadastrarPacote(TabelaPacotes novoPacote);

        void AtualizarPacote(int id, TabelaPacotes pacoteAtualizado);

        //EXTRA

        List<TabelaPacotes> ListaAtivos(bool status);
    }
}
