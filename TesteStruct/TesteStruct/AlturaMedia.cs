using System.Globalization;

//Explora a criação de arrays e manipulação dos mesmos
namespace TesteStruct {
    internal class AlturaMedia {
        public static double MediaAltura(int n) {
            double[] alturas = new double[n];
            double soma = 0.00;

            for (int i = 0; i < n; i++) {
                Console.Write("Digite a altura: ");
                alturas[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine();
            }

            for (int i = 0; i < n; i++) {
                soma += alturas[i];
            }

            double media = soma / n;

            return media;
        }      
    }
}
