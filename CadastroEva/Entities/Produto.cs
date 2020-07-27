
namespace CadastroEva.Entities
{
    class Produto
    {
        public int Id { get; set; }
        public int Quantidade { get; set; }
        public string Nome { get; set; }
        public double Preco { get; set; }
        private double _vlPreco = 0;
        private double _vlMaoDeObra = 1; //valor hr mao de obra, ex: R$ 1,00/hora
        private double _vlMaoDeObraTotal; //valor total mao de obra
        private double _vlInsumo = 1; //valor fixo insumo energia/agua/etc        
        private double _vlLucro = 2; //valor fixo para calculo lucro
        private double _vlPrecoBruto;
        private double _vlPrecoTotal;


        public Produto()
        {
        } 
        
        //Alterado para private para ninguém ter acesso
        public Produto(int id,  int quantidade)
        {
            Id = id;
            Nome = ProcuraNome(id);
            Quantidade = quantidade;
        }      


        public string ProcuraNome(int id)
        {
            //Desta forma, é colocado os produtos dentro das posições do vetor
            //economizando memória e ajudando na performance do programa.
            //para localizar qual é o produto, basta localizar pela posição da variável.
            //Obs: A posição começa a partir do 0 (zero)
            string[] nome = { "Rosa Monique", //0
                              "Sepala Pequena", // 1
                              "Folha Rosa Grande", //2
                              "Folha Desidratada", //3
                              "Arame", //3
                              "Vaso Vidro", //4
                              "Fita Floral" //5
                            };
            return nome[id];
        }

        public double CalculaPreco(int id)
        {

            //-------------------------------------
            //METODO PARA APLICAR VALOR DO PRODUTO
            //-------------------------------------

            switch (id)
            {
                case 0:
                    //Rosa Monique
                    double _rosaMonique = 0.1;
                    _vlPreco = _rosaMonique;
                    break;
                case 1:
                    //Sepala Pequena
                    double _sepalaPequena = 0.05;
                    _vlPreco = _sepalaPequena;
                    break;
                case 2:
                    //Folha Rosa Grande
                    double _folhaRosaGrande = 0.1;
                    _vlPreco = _folhaRosaGrande;
                    break;
                case 3:
                    //Folha Desidratada
                    double _folhaDesidratada = 0.05;
                    _vlPreco = _folhaDesidratada;
                    break;
                case 4:
                    //Arame
                    double _arame = 1.00;
                    _vlPreco = _arame;
                    break;
                case 5:
                    //Vaso Vidro
                    double _vasoVidro = 8.00;
                    _vlPreco = _vasoVidro;
                    break;
                case 6:
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
    }
}
