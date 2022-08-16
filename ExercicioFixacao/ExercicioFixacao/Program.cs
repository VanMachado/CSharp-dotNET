namespace ExercicioFixacao {
    class Program {
        static void Main(string[] args) {
            string decisao;
            double depoInicial;
            double depo;
            double saque;

            Console.WriteLine("Entre o número da conta: ");
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o titular da conta: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Deseja fazer um depósito inicial? (s/n): ");
            decisao = Console.ReadLine();

            if (decisao == "s") {
                Console.WriteLine("Entre com o valor do depósito inicial: ");
                depoInicial = double.Parse(Console.ReadLine());
                Console.WriteLine();
            } else {
                depoInicial = 0.00;
                Console.WriteLine();
            }                       
            
            Conta conta = new Conta(num, nome, depoInicial);
            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(conta);
            Console.WriteLine();

            Console.WriteLine("Entre com um valor para deposito: ");
            depo = double.Parse(Console.ReadLine());
            conta.Deposita(depo);
            Console.WriteLine();
            Console.WriteLine("Dados da conta atualizado: ");
            Console.WriteLine(conta);
            Console.WriteLine();

            Console.WriteLine("Entre com um valor para saque: ");
            saque = double.Parse(Console.ReadLine());
            conta.Saca(saque);
            Console.WriteLine("Dados da conta atualizado: ");
            Console.WriteLine(conta);                        
        }
    }
}