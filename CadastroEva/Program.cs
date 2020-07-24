using System;
using CadastroEva.Entities;

namespace CadastroEva
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dtMoment = DateTime.Now;
            //----------------------------------

            try
            {
                Console.WriteLine("Entre com o nome do cliente:");
                string nmClient = Console.ReadLine();
                Console.WriteLine("Entre com os dados do Pedido:");
                Console.WriteLine("-------------------------------");
                Console.WriteLine("-------------------------------");
                Console.WriteLine("Quantos itens deseja cadastrar?");
                int n = int.Parse(Console.ReadLine());
                Console.WriteLine("Entre com a Qtd de Horas Trabalhadas");
                double qtHrtrab = double.Parse(Console.ReadLine());
                Console.WriteLine("Entre com o Desconto:");
                double descPorc = double.Parse(Console.ReadLine());

                Cliente cli = new Cliente(nmClient);

                Pedido pedido = new Pedido(dtMoment, cli, qtHrtrab, descPorc);

                for (int i = 1; i <= n; i++)
                {
                    Console.WriteLine($"Entre com o #{i} item:");

                    Console.WriteLine("Escolha o produto:");
                    Console.WriteLine("(1) Rosa Monique" + "\n"
                                    + "(2) Sepala Pequena" + "\n"
                                    + "(3) Folha de Rosa Grande" + "\n"
                                    + "(4) Flor Desidratada" + "\n"
                                    + "(5) Arame" + "\n"
                                    + "(6) Vaso de Vidro" + "\n"
                                    + "(7) Fita Floral");
                    int idProduto = int.Parse(Console.ReadLine());
                    Console.WriteLine("Entre com a quantidade:");
                    int qtProduto = int.Parse(Console.ReadLine());

                    Produto produto = (new ProdutoPreco(idProduto, qtProduto));

                    //Instancia a classe OrderItem passando o Id do produto e sua quantidade
                    PedidoItem item = new PedidoItem(idProduto, qtProduto, produto);
                    pedido.AdicionaPedido(item);
                }
                //----------------------------------
                Console.WriteLine();
                Console.WriteLine("RESUMO DO PEDIDO:");
                Console.WriteLine(pedido);


            }
            catch(NullReferenceException e)
            {
                Console.WriteLine("Não é aceito dado nulo. " + e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Erro no formato do texto. " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("teste");
            }
            

        }
    }
}
