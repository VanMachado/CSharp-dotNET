using Enumeracoes.Entities;
using Enumeracoes.Entities.Enums;

namespace Enumeracoes
{
    class Program
    {
        static void Main(string[] args) {
            Console.Write("Enter Departament: ");
            string dep = Console.ReadLine();

            Console.WriteLine("Enter worker data:");

            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Level: ");
            WorkerLevel lv = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.Write("Base salary: ");
            double salary = double.Parse(Console.ReadLine());

            Departament departament = new Departament(dep);
            Worker worker = new Worker(name, lv, salary, departament);

            Console.Write("How many contrats to this worker?: ");
            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                Console.WriteLine($"Enter #{i} contract data:");
                Console.Write("Date (DD/MM/YYYY): ");
                DateTime d = DateTime.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double price = double.Parse(Console.ReadLine());
                Console.Write("Duration (hours)");
                int hours = int.Parse(Console.ReadLine());

                HourContract contract = new(d, price, hours);

                worker.AddContract(contract);
            }

            Console.WriteLine();

            Console.Write("Enter month and year to calcule income (MM/YYYY): ");
            string monthAnyear = Console.ReadLine();
            int mes = int.Parse(monthAnyear.Substring(0, 2));
            int ano = int.Parse(monthAnyear.Substring(3));

            Console.WriteLine($"Worker: {worker.Name}");
            Console.WriteLine($"Departament: {worker.Departament}");
            Console.WriteLine($"Income for {monthAnyear}: {worker.Income(ano, mes):F2}");
        }
    }
}