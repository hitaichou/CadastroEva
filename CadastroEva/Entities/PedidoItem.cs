using System.Globalization;

namespace CadastroEva.Entities
{
    class PedidoItem
    {
        public int Id { get; set; }
        public int Quantidade { get; set; }
        public Produto ProdutoPreco { get; set; } = new ProdutoPreco();
        //public Produto ProdutoNome { get; set; } = new ProdutoNome();

        //------------------------------
        //CONSTRUTORES
        //------------------------------
        public PedidoItem()
        {
        }
        public PedidoItem(int id, int quantidade, Produto produtopreco/*, Produto produtonome*/)
        {
            Id = id;
            Quantidade = quantidade;
            //ProdutoNome = produtonome;
            ProdutoPreco = produtopreco;
        }
        //------------------------------
        //MÉTODOS
        //------------------------------
        public double SubTotal()
        {
            //multiplico a quantidade pelo produto na subclasse CalculaPreco
            //passando o ID como parâmetro
            return Quantidade * ProdutoPreco.CalculaPreco(Id);
        }




    }
}
