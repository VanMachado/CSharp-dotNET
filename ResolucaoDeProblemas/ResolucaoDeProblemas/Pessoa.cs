namespace ResolucaoDeProblemas {
    internal class Pessoa {
        public string nome;
        public int idade;
        public double salario;

        public int MaisVelha(int num1, int num2, string nome1, string nome2) {
            if (num1 > num2) {
                Console.WriteLine("Pessoa mais velha: {0}", nome1);
            } else {
                Console.WriteLine("Pessoa mais velha: {0}", nome2);
            }

            return 0;
        }

        public double Media(double valor1, double valor2) {
            return (valor1 + valor2) / 2;
        }
    }
}
