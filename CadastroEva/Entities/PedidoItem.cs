using System.Globalization;

namespace CadastroEva.Entities
{
    class PedidoItem
    {
        public int Id { get; set; }
        public int Quantidade { get; set; }
        public Produto Produto { get; set; } = new Produto();

        //------------------------------
        //CONSTRUTORES
        //------------------------------
        public PedidoItem()
        {
        }
        public PedidoItem(int id, int quantidade, Produto produto)
        {
            Id = id;
            Quantidade = quantidade;
            Produto = produto;
        }
        //------------------------------
        //MÉTODOS
        //------------------------------
        public double SubTotal()
        {
            //multiplico a quantidade pelo produto na subclasse CalculaPreco
            //passando o ID como parâmetro
            return Quantidade * Produto.CalculaPreco(Id);
        }
        public override string ToString()
        {
            return Produto.ProcuraNome(Id) //busco o nome do produto                   
                + ", R$"
                + Produto.CalculaPreco(Id).ToString("F2", CultureInfo.InvariantCulture) //busco o valor do produto
                + ", Quantity: "
                + Quantidade
                + ", Subtotal: $"
                + SubTotal().ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
