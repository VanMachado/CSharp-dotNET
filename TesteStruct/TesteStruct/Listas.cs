//Criação e manipulação de listas
namespace TesteStruct {
    internal class Listas {
        public static  void TesteListas() {
            List<string> list = new List<string>();

            Console.WriteLine("Digite os nomes da lista: ");
            for (int i = 0; i < 5; i++) {
                list.Add(Console.ReadLine());
            }

            list.Insert(1, "Daniel");

            Console.WriteLine();

            //Uso do foreach para mostrar os dados
            foreach (string s in list) {
                Console.WriteLine(s);
            }

            Console.WriteLine();

            //Posso usar a função Teste ou uma expressao lambda
            string teste = list.Find(s => s[0] == 'A');
            Console.WriteLine("Primeiro nome com A: " + teste);

            string teste2 = list.FindLast(Teste);
            Console.WriteLine("Ultimo nome com A: " + teste2);

            int x = list.FindIndex(s => s[0] == 'A');
            Console.WriteLine("First index: " + x);

            int y = list.FindLastIndex(s => s[0] == 'A');
            Console.WriteLine("Last index: " + y);

            List<string> list2 = list.FindAll(x => x.Length >= 5);

            Console.WriteLine("----------------");

            foreach (string s in list2) {
                Console.WriteLine(s);
            }

            Console.WriteLine("----------------");

            list.Remove("Alex");
            foreach (string s in list) {
                Console.WriteLine(s);
            }
        }
        static bool Teste(string s) {
            return s[0] == 'A';
        }
    }
}
