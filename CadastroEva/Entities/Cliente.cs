using System;
using System.Collections.Generic;
using System.Text;

namespace CadastroEva.Entities
{
    class Cliente
    {
        public string Nome { get; set; }

        public Cliente()
        {
        }
        public Cliente(string nome)
        {
            Nome = nome;
        }

        public override string ToString()
        {
            return Nome;
        }
    }
}
