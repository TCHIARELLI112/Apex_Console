using Apex_Console.Modelos;
using System;
using System.Collections.Generic;
using System.Text;
using Apex_Console.Repositorio;
using Apex_Console.Servicos.ProdutoRepositorio;

namespace Apex_Console.Repositorio
{
    interface IRepositorioCliente
    {
        void Incluir(Cliente cliente);

        void Exlcuir(int id);

        List<Cliente> ObterTodos();

        Cliente ObterPeloId(int id);


        string ObterClienteEListaDeProdutos(int idCliente, ProdutoRepositorioServico produtoServico);
    }
}
