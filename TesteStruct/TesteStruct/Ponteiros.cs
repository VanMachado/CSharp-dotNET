//Utilização de ponteiros e nullables
namespace TesteStruct {
    internal class Ponteiros {
        public static void TestePonteiros() {
            Point p;
            p.x = 10;
            p.y = 20;

            //Sintaxe para definir que algum atributo pode ser nulo
            double? a = null;
            double? b = 10.0;

            double? c = null;
            double? d = 15.0;

            double e = c ?? 5.0;
            double f = d ?? 5.0;

            //Retorna o seu valor ou o default
            Console.WriteLine(a.GetValueOrDefault());
            Console.WriteLine(b.GetValueOrDefault());
            Console.WriteLine();

            Console.WriteLine(e);
            Console.WriteLine(f);
            Console.WriteLine();

            //Checa se tem algum valor e retorna um booleano
            Console.WriteLine(a.HasValue);
            Console.WriteLine(b.HasValue);
            Console.WriteLine();

            Console.WriteLine(p);
            Console.WriteLine();
        }
    }
}