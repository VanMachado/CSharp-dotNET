//Utilizando arrays e alguns metodos pertinentes ao tipo e metodos com Ref e Out
namespace TesteStruct {
    internal class Calculadora {
        public static int Soma(params int[] num) {
            int soma = 0;
            for (int i = 0; i < num.Length; i++) { 
                soma += num[i];
            }

            return soma;
        }

        public static void Triplicar(ref int x) {
            x = x * 3;            
        }

        public static void TriplicarOut(int x, out int receba) {
            receba = x * 3;
        }
    }
}