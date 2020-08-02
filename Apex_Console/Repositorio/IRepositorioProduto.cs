using Apex_Console.Modelos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Apex_Console.Repositorio
{
    interface IRepositorioProduto
    {

        void Incluir(Produto produto);

        void Exlcuir(int id);

        List<Produto> ObterTodos();

        Produto ObterPeloId(int id);

        List<Produto> ObterPeloIdDoCliente(int idCliente);

    }
}
