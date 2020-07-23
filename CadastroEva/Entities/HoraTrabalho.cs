using System;
using System.Collections.Generic;
using System.Text;

namespace CadastroEva.Entities
{
    class HoraTrabalho
        /*TRANSFORMAR ESTA CLASSE EM SUBCLASSE DE PRODUTO.
         * ELA POSSUI SOMENTE O CALCULO FINAL DO PRODUTO.
         */

    {
        private double _vlMaoDeObra = 1; //valor hr mao de obra, ex: R$ 1,00/hora
        private double _vlMaoDeObraTotal; //valor total mao de obra
        private double _vlInsumo = 1; //valor fixo insumo energia/agua/etc        
        private double _vlLucro = 2; //valor fixo para calculo lucro
        private double _vlPrecoBruto;
        private double _vlPrecoTotal;
        //public double QtMaoDeObra { get; set; }
        //public double VlPrecoCusto { get; set; }
       // public double VlDesconto { get; set; }
        //public Produto ProdutoPreco { get; set; } = new ProdutoPreco();

        //------------------------------
        //CONSTRUTORES
        //------------------------------
        public HoraTrabalho()
        {
        }
        /*
        public HoraTrabalho(int id, double qtMaoDeObra, double vlDesconto)
        {
            QtMaoDeObra = qtMaoDeObra;
            VlPrecoCusto = ProdutoPreco.CalculaPreco(id);
            VlDesconto = vlDesconto;
        }
        */
        //------------------------------
        //MÉTODOS
        //------------------------------
        public double CalculaPreco(double qtmaodeobra, double vlprecocusto, double vldesconto)
        {
            _vlPrecoBruto = (vlprecocusto + _vlInsumo) * _vlLucro;
            _vlMaoDeObraTotal = _vlMaoDeObra * qtmaodeobra;
            _vlPrecoTotal = (_vlPrecoBruto - (_vlPrecoBruto * (vldesconto / 100))) + _vlMaoDeObraTotal;
            return _vlPrecoTotal;
        }
        
    }
}
