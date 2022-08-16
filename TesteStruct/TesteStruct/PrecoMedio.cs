using System.Globalization;

namespace TesteStruct {
    internal class PrecoMedio {
        public static double MediaPreco(int n) {
            Produto[] produtos = new Produto[n];
            double soma = 0.0;            

            for (int i = 0; i < n; i++) {
                Console.Write("Digite o nome do produto: ");                
                string nome = Console.ReadLine();
                Console.Write("Digite o preço do produto: ");
                double preco = double.Parse(Console.ReadLine()
                    , CultureInfo.InvariantCulture);

                produtos[i] = new Produto(nome, preco);
                Console.WriteLine();
            }

            for (int i = 0; i < n; i++) {
                soma += produtos[i].Preco;
            }

            double media = soma / n;

            return media;
        }
    }
}
