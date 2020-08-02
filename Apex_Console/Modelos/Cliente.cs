using System;
using System.Collections.Generic;
using System.Text;

namespace Apex_Console.Modelos
{
    class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public Cliente(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }

        public override string ToString()
        {
            return "**** ID: "+ Id + " - Nome: "+ Nome;
        }
    }
}
