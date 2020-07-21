using System;
using System.Collections.Generic;
using System.Text;

namespace CadastroEva.Entities
{
    class ProdutoNome :Produto
    {
        public string Nome { get; set; }
        private string _nmProduto;

        public ProdutoNome()
        {
        }

        public ProdutoNome(int id, string nome)
            :base(id)
        {
            Nome = nome;
        }

        public override double CalculaPreco(int id)
        {
            throw new NotImplementedException();
        }

        public override string ProcuraNome(int id)
        {
            //-------------------------------------
            //METODO PARA APLICAR NOME DO PRODUTO
            //-------------------------------------

            switch (id)
            {
                case 1:
                    _nmProduto = "Rosa Monique";
                    break;
                case 2:
                    _nmProduto = "Sepala Pequena";
                    break;
                case 3:
                    _nmProduto = "Folha Rosa Grande";
                    break;
                case 4:
                    _nmProduto = "Folha Desidratada";
                    break;
                case 5:
                    _nmProduto = "Arame";
                    break;
                case 6:
                    _nmProduto = "Vaso Vidro";
                    break;
                case 7:
                    _nmProduto = "Fita Floral";
                    break;
                default:
                    _nmProduto = "NAO EXISTE";
                    break;
            }
            return _nmProduto;
        }
    }
}
