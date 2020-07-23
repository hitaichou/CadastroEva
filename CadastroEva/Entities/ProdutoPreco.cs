using System;
using System.Collections.Generic;
using System.Text;

namespace CadastroEva.Entities
{
    class ProdutoPreco :Produto
    {
        public double Preco { get; set; }
        private double _vlPrice = 0;
        

        public ProdutoPreco()
        {
        }

        //CONSTRUTOR chamando parâmetros da superclasse
        public ProdutoPreco(int id, int quantidade, double preco)
            :base(id, quantidade)
        {
            Preco = preco;
        }

        public override double CalculaPreco(int id)
        {

            //-------------------------------------
            //METODO PARA APLICAR VALOR DO PRODUTO
            //-------------------------------------

            switch (id)
            {
                case 1:
                    //Rosa Monique
                    double _rosaMonique = 0.1;
                    _vlPrice = _rosaMonique;
                    break;
                case 2:
                    //Sepala Pequena
                    double _sepalaPequena = 0.05;
                    _vlPrice = _sepalaPequena;
                    break;
                case 3:
                    //Folha Rosa Grande
                    double _folhaRosaGrande = 0.1;
                    _vlPrice = _folhaRosaGrande;
                    break;
                case 4:
                    //Folha Desidratada
                    double _folhaDesidratada = 0.05;
                    _vlPrice = _folhaDesidratada;
                    break;
                case 5:
                    //Arame
                    double _arame = 1.00;
                    _vlPrice = _arame;
                    break;
                case 6:
                    //Vaso Vidro
                    double _vasoVidro = 8.00;
                    _vlPrice = _vasoVidro;
                    break;
                case 7:
                    //Fita Floral
                    double _fitaFloral = 0.20;
                    _vlPrice = _fitaFloral;
                    break;
                default:
                    _vlPrice = 0;
                    break;
            }
            return _vlPrice;
            
        }

        public override string ProcuraNome(int id)
        {
            throw new NotImplementedException();
        }
    }
}
