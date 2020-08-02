using Apex_Console.Modelos;
using Apex_Console.Repositorio;
using Apex_Console.Servicos.ProdutoRepositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Apex_Console.Servicos.ClienteRepositorio
{
    class ClienteRepositorioServico : IRepositorioCliente
    {

        public List<Cliente> ListaDeClientes = new List<Cliente>();


        public void Exlcuir(int id)
        {
            ListaDeClientes.RemoveAll(cli => cli.Id == id);
        }

        public void Incluir(Cliente cliente)
        {
            ListaDeClientes.Add(cliente);
        }

       
        public Cliente ObterPeloId(int id)
        {
            return ListaDeClientes.Where(cli => cli.Id == id).FirstOrDefault();
        }

        public List<Cliente> ObterTodos()
        {
            return ListaDeClientes;
        }

        public string ObterClienteEListaDeProdutos(int idCliente, ProdutoRepositorioServico produtoServico)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var cliente in ListaDeClientes.Where(clie => clie.Id == idCliente))
            {

                sb.AppendLine("-------------------------------------------------------");
                sb.AppendLine("CLIENTE");
                sb.AppendLine("-------------------------------------------------------");
                sb.AppendLine(cliente.ToString());
                sb.AppendLine("-------------------------------------------------------");
                sb.AppendLine("PRODUTOS");
                sb.AppendLine("-------------------------------------------------------");

                foreach(var produto in produtoServico.ObterPeloIdDoCliente(idCliente))
                {
                    sb.AppendLine(produto.ToString());
                }
                                
            }
            return sb.ToString();
        }
    }
}
