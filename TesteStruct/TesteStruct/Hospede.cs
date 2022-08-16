//Manipulação de vetores
namespace TesteStruct {
    internal class Hospede {
        public string Nome { get; set; }
        public string Email { get; set; }        

        public Hospede(string nome, string email) {
            Nome = nome;
            Email = email;            
        }

        public static void QuartosAlugados(int n) {
            Hospede[] hospedes = new Hospede[10];
            string alugados;

            for (int i = 0; i < n; i++) {
                Console.Write("Digite o nome do Hóspede: ");
                string nome = Console.ReadLine();
                Console.Write("Digite o email do Hóspede: ");
                string email = Console.ReadLine();
                Console.Write("Digite o quarto do Hóspede: ");
                int quarto = int.Parse(Console.ReadLine());

                hospedes[quarto] = new Hospede(nome, email);
                Console.WriteLine();
            }

            Console.WriteLine("Quartos alugados:");
            for (int i = 0; i < 10; i++) {
                if (hospedes[i] != null) {
                    alugados = i + ": "
                    + hospedes[i].Nome + ", " + hospedes[i].Email;
                    Console.WriteLine(alugados);
                }
            }
        }
    }
}
