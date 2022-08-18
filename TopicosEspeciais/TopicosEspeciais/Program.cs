namespace TopicosEspeciais {
    class Program {
        static void Main(string[] args) {
            string nome = "Banana";
            int tam = 32;
            double preco = 9.90;

            string nome1 = "Maca";
            int tam1 = 45;
            double preco1 = 4.50;

            List<Produto> produtos = new List<Produto>();

            produtos.Add(new Produto(nome, tam, preco));
            produtos.Add(new Produto(nome1, tam1, preco1));

            //Manipulação de lista buscando um "Nome" que comece com 'B'
            Produto teste = produtos.Find(x => x.Nome[0] == 'B');

            //Exmplo de operador ternário
            string msg = (teste != null) ? "Esse é o teste 1: " + teste : "Produto não encontrado!";

            Console.WriteLine(msg);            
            Console.WriteLine();
            foreach (Produto p in produtos) {
                Console.WriteLine(p);
            }

        }
    }
}