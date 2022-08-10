namespace ResolucaoDeProblemas {
    internal class Produto {
        public string nome;
        public double preco;
        public int quantidade;

        public double ValoroTotalEmEstoque() {
            double total = preco * quantidade;
            Console.WriteLine("Dados do produto: " + ToString());

            return total;
        }

        public void AdicionarProdutos(int quant) { 
            quantidade += quant;
            double total = preco * quantidade;

            Console.WriteLine("Produtos atualizados: " + ToString());
        }

        public void RemoverProduto(int quant) { 
            quantidade -= quant;
            double total = preco * quantidade;

            Console.WriteLine("Produtos atualizados: " + ToString());
        }

        override public string ToString() {
            return nome + ", R$" + preco + ", " 
                + quantidade + " Unidades, Total: R$ " + preco * quantidade;
        }

    }
}
