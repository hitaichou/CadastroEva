using System;
using System.Collections.Generic;
using System.Text;

namespace CadastroEva.Entities
{
    class ProdutoPreco :Produto
    {
        public double Preco { get; set; }
        private double _vlPreco = 0;
        private double _vlMaoDeObra = 1; //valor hr mao de obra, ex: R$ 1,00/hora
        private double _vlMaoDeObraTotal; //valor total mao de obra
        private double _vlInsumo = 1; //valor fixo insumo energia/agua/etc        
        private double _vlLucro = 2; //valor fixo para calculo lucro
        private double _vlPrecoBruto;
        private double _vlPrecoTotal;

        
        public ProdutoPreco()
        {
        }

        //CONSTRUTOR chamando parâmetros da superclasse
        public ProdutoPreco(int id, int quantidade, double preco)
            :base(id, quantidade)
        {
            Preco = preco;
        }
        public ProdutoPreco(int id, int quantidade)
            : base(id, quantidade)
        {
            
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
                    _vlPreco = _rosaMonique;
                    break;
                case 2:
                    //Sepala Pequena
                    double _sepalaPequena = 0.05;
                    _vlPreco = _sepalaPequena;
                    break;
                case 3:
                    //Folha Rosa Grande
                    double _folhaRosaGrande = 0.1;
                    _vlPreco = _folhaRosaGrande;
                    break;
                case 4:
                    //Folha Desidratada
                    double _folhaDesidratada = 0.05;
                    _vlPreco = _folhaDesidratada;
                    break;
                case 5:
                    //Arame
                    double _arame = 1.00;
                    _vlPreco = _arame;
                    break;
                case 6:
                    //Vaso Vidro
                    double _vasoVidro = 8.00;
                    _vlPreco = _vasoVidro;
                    break;
                case 7:
                    //Fita Floral
                    double _fitaFloral = 0.20;
                    _vlPreco = _fitaFloral;
                    break;
                default:
                    _vlPreco = 0;
                    break;
            }
            return _vlPreco;
            
        }

        public double CalculaPrecoTotal(double qtmaodeobra, double vlprecocusto, double vldesconto)
        {
            _vlPrecoBruto = (vlprecocusto + _vlInsumo) * _vlLucro;
            _vlMaoDeObraTotal = _vlMaoDeObra * qtmaodeobra;
            _vlPrecoTotal = (_vlPrecoBruto - (_vlPrecoBruto * (vldesconto / 100))) + _vlMaoDeObraTotal;
            return _vlPrecoTotal;
        }

        public override string ProcuraNome(int id)
        {
            throw new NotImplementedException();
        }
    }
}
