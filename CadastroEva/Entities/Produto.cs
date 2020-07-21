using System;
using System.Collections.Generic;
using System.Text;

namespace CadastroEva.Entities
{
    abstract class Produto
    {
        public int Id { get; set; }        
        public int Quantidade { get; set; }

        public Produto()
        {
        }
        public Produto(int id)
        {
            Id = id;
        }
        public Produto(int id, int quantidade)
        {
            Id = id;
            Quantidade = quantidade;
        }

        //Declaro método abstrato
        public abstract double CalculaPreco(int id);


        public abstract string ProcuraNome(int id);
    }
}
