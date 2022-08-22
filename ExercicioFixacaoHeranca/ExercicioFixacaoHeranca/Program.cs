using ExercicioFixacaoHeranca.Entities;
using System.Globalization;

namespace ExercicioFixacaoHeranca
{
    class Program
    {
        public static void Main(string[] arg)
        {
            List<Product> lista = new List<Product>();

            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Product #{i + 1} data:");
                Console.Write("Common, used or imported (c/u/i)? ");
                char resp = char.Parse(Console.ReadLine());

                if (resp == 'c' || resp == 'C')
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Price: ");
                    double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Product produto = new Product(name, price);
                    lista.Add(produto);
                }
                else if (resp == 'i' || resp == 'I')
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Price: ");
                    double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Customs fee: ");
                    double fee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    ImportedProduct imported = new ImportedProduct(name, price, fee);
                    lista.Add(imported);
                }
                else
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Price: ");
                    double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime date = DateTime.Parse(Console.ReadLine());

                    UsedProduct used = new UsedProduct(name, price, date);
                    lista.Add(used);
                }
            }

            Console.WriteLine();
            Console.WriteLine("PRICE TAGS:");

            foreach (Product produto in lista)
            {
                Console.WriteLine(produto.PriceTag());
            }
        }
    }
}
