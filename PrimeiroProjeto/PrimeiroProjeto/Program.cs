//Alguns exemplos de metodos de entrada de dados e operadores logicos em CSharp
namespace PrimeiroProjeto {
    class Program {
        static void Main(string[] args) {
            int senha;
            int maior = 0;
            int a, b, c, i;



            //Aquele Olá mundo pra dar sorte...
            Console.WriteLine("Hello, World!");

            //Quando uso esse metodo de entrada de dados sempre vai receber uma string
            string[] v = Console.ReadLine().Split(' ');

            string nome = v[0];
            string inicial = v[1];
            //entao preciso fazer esse casting para nao dar erro
            int idade = int.Parse(v[2]);
            double altura = double.Parse(v[3]);

            Console.WriteLine("Para acessar as informações, insira a senha");
            senha = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite 3 números: ");
            string[] n = Console.ReadLine().Split(' ');

            //maneira de receber um vetor em string e transformar em int
            for (i = 0; i < 2; i++) {
                if (maior < int.Parse(n[i])) {
                    maior = int.Parse(n[i]);
                }
            }

            while (senha != 2002) {
                Console.WriteLine("Senha incorreta, digite de novo");
                senha = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Você digitou esses seguintes valores: ");
            Console.WriteLine(nome);
            Console.WriteLine(inicial);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2"));
            Console.WriteLine(maior);
        }
    }
}
