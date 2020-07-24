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
        public ProdutoPreco ProdutoPreco { get; set; } = new ProdutoPreco();
        public List<PedidoItem> Items { get; set; } = new List<PedidoItem>();
        private double _vlBasePrice;
        //private double _vlTotal = 0;

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
            double _vlTotal = 0;
            foreach (PedidoItem item in Items)
            {
                soma += item.SubTotal();
            }
            _vlTotal = ProdutoPreco.CalculaPrecoTotal(QtMaoDeObra, soma, VlDesconto);
            return _vlTotal;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Data/Hora Pedido: " + Momento.ToString("dd/MM/yyyy HH:mm:ss"));            
            sb.AppendLine("Cliente: " + Cliente);
            sb.AppendLine("Items do Pedido:");
            foreach (PedidoItem item in Items)
            {
                sb.AppendLine(item.ToString());
            }
            sb.AppendLine("Preco Total: $ " + Total().ToString("F2", CultureInfo.InvariantCulture));
            return sb.ToString();
        }


    }
}
