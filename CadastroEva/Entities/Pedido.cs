using System;
using System.Globalization;
using System.Collections.Generic;
using System.Text;

namespace CadastroEva.Entities
{
    class Pedido
    {
        public Cliente Cliente { get; set; }
        public DateTime Momento { get; set; }
        public double QtMaoDeObra { get; set; }
        public double VlDesconto { get; set; }
        public HoraTrabalho HoraTrabalho { get; set; } = new HoraTrabalho();
        public List<PedidoItem> Items { get; set; } = new List<PedidoItem>();
        private double _vlBasePrice;
        private double _vlTotal;

        //------------------------------
        //CONSTRUTORES
        //------------------------------
        public Pedido()
        {
        }
        public Pedido(DateTime momento, Cliente cliente, double qtmaodeobra, double vldesconto)
        {
            Momento = momento;
            Cliente = cliente;
            QtMaoDeObra = qtmaodeobra;
            VlDesconto = vldesconto;
        }
        //------------------------------
        //MÉTODOS
        //------------------------------

        public void AdicionaPedido(PedidoItem item)
        {
            Items.Add(item);
        }
        public void RemovePedido(PedidoItem item)
        {
            Items.Remove(item);
        }
        public double Total()
        {
            double soma = 0;
            foreach(PedidoItem item in Items)
            {
                soma += item.SubTotal();
            }
            _vlTotal = HoraTrabalho.CalculaPreco(QtMaoDeObra, soma, VlDesconto);
            return _vlTotal;
        }


    }
}
