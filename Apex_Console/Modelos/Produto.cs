using System;
using System.Collections.Generic;
using System.Text;

namespace Apex_Console.Modelos
{
    class Produto
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public double Valor { get; set; }
        public int IdCliente { get; set; }

        public Produto(int id, string descricao, double valor, int idCliente)
        {
            Id = id;
            Descricao = descricao;
            Valor = valor;
            IdCliente = idCliente;
        }

        public override string ToString()
        {
            return "**** ID: " + Id + " - Descrição: " + Descricao + " - Valor: R$ " + Valor.ToString("F2");
        }
    }
}
