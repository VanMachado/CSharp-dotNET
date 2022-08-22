using ExercicioFixacaoAbstratos.Entities;
using System.Globalization;

namespace ExercicioFixacaoAbstratos
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<TaxPayer> lista = new List<TaxPayer>();

            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 0; i < n; i++)
            {
                Console.WriteLine($"Tax payer #{i+1} data:");
                
                Console.Write("Individual or company (i/c)? ");
                char resp = char.Parse(Console.ReadLine()); 

                if(resp == 'i' || resp == 'I')
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Anual income: ");
                    double income = double.Parse(Console.ReadLine(), 
                        CultureInfo.InvariantCulture);
                    Console.Write("Health expenditures: ");
                    double health = double.Parse(Console.ReadLine(),
                       CultureInfo.InvariantCulture);

                    lista.Add(new Individual(health, name, income));
                } else
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Anual income: ");
                    double income = double.Parse(Console.ReadLine(),
                        CultureInfo.InvariantCulture);
                    Console.Write("Number of employees: ");
                    int number = int.Parse(Console.ReadLine(),
                        CultureInfo.InvariantCulture);

                    lista.Add(new Company(number, name, income));
                }
            }

            Console.WriteLine();
            Console.WriteLine("TAXES PAID:");

            foreach(TaxPayer tax in lista)
            {
                Console.Write($"{tax.Name}: $ " +
                    $"{tax.Tax().ToString("F2", CultureInfo.InvariantCulture)}");
                Console.WriteLine();
            }
            
            Console.WriteLine();

            double sum = 0;
            foreach (TaxPayer taxTotal in lista)
            {
                sum += taxTotal.Tax();
            }

            Console.Write("TOTAL TAXES: ");
            Console.WriteLine(sum.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
