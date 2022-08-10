namespace ResolucaoDeProblemas {
    internal class Exercicios {
        //Quando quiser rodar os exercicios mudar o nome do metodo para Main e trocar o Main atual para Teste
        static void Teste(String[] args) {
            Pessoa h, m, h1, m1;
            double media;

            h = new Pessoa();
            h1 = new Pessoa();
            m = new Pessoa();
            m1 = new Pessoa();

            h.nome = "Joao";
            h.idade = 16;
            m.nome = "Maria";
            m.idade = 17;

            h1.nome = "Carlos Silva";
            h1.salario = 6300.00;
            m1.nome = "Ana Marques";
            m1.salario = 6700.00;

            h.MaisVelha(h.idade, m.idade, h.nome, m.nome);
            media = h.Media(h1.salario, m1.salario);

            Console.WriteLine("Salário médio: R$ {0}", media);
        }             
    }
}
