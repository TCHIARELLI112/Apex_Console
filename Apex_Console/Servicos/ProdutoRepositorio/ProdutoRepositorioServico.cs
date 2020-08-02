using Apex_Console.Modelos;
using Apex_Console.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Apex_Console.Servicos.ProdutoRepositorio
{
    class ProdutoRepositorioServico : IRepositorioProduto
    {

        public 
            List<Produto> ListaDeProdutos = new List<Produto>();


        public void Exlcuir(int id)
        {
            ListaDeProdutos.RemoveAll(prod => prod.Id == id);
        }

        public void Incluir(Produto produto)
        {
            ListaDeProdutos.Add(produto);
        }

        public Produto ObterPeloId(int id)
        {
            return ListaDeProdutos.Where(prod => prod.Id == id).FirstOrDefault();
        }

        public List<Produto> ObterPeloIdDoCliente(int idCliente)
        {
            return ListaDeProdutos.Where(prod => prod.IdCliente == idCliente).ToList();
        }

        public List<Produto> ObterTodos()
        {
            return ListaDeProdutos;
        }
    }
}
