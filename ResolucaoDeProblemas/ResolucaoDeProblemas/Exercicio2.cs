namespace ResolucaoDeProblemas {
    internal class Exercicio2 {
        static void Teste(string[] arg) {
            Produto prod;
            int num;
            prod = new Produto();

            prod.nome = "TV";
            prod.preco = 900;
            prod.quantidade = 10;

            prod.ValoroTotalEmEstoque();

            Console.WriteLine("Digite o número de itens a serem adicionados: ");
            num = int.Parse(Console.ReadLine());
            prod.AdicionarProdutos(num);

            Console.WriteLine("Digite o número de itens a serem retirados: ");
            num = int.Parse(Console.ReadLine());
            prod.RemoverProduto(num);
        }
    }
}
