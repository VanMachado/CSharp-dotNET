using System.Globalization;

//Para testar determinada função, deixar apenas ela descomentada
namespace TesteStruct {
    class Program {
        static void Main(string[] args) {
            //Explicação sobre null e ponteiros
            //Exemplo de utilização e inicialização de struct
            /*
            Ponteiros.TestePonteiros();         
            */
            //Operação com vetores utilizando funções estaticas
            /*                                   
            Console.WriteLine("Digite o tamanho do vetor: ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("AVERAGE HEIGTH = " + 
                AlturaMedia.MediaAltura(num).ToString("F2", CultureInfo.InvariantCulture));            
            */

            //Operação com vetores utilizando objetos como referência
            /*
            Console.Write("Digite o tamanho do vetor: ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("O preço médio é = R$ " + 
                PrecoMedio.MediaPreco(num).ToString("F2", CultureInfo.InvariantCulture));
            */

            /*
            //Chamado do método QuartosAlugados
            Console.Write("Quantos quartos serão alugados: ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Hospede.QuartosAlugados(num);
            */

            //Utilização de Ref e Out, lembrando que ambos são code smells
            /*
            RefEOut.TesteRefEOut();
            */
            /*
            //Uso de listas
            Listas.TesteListas();
            */
        }
    }
}