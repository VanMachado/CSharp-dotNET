using System.Globalization;
using Heranca.Entities;

namespace Heranca
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<Employee> lista = new List<Employee>();

            Console.Write("Type how many employee will be add: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Employee #{i+1} data:");
                Console.WriteLine("Outsourcede (y/n)? ");
                char resp = char.Parse(Console.ReadLine());
                if(resp == 'y' || resp == 'Y')
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Hours: ");
                    int hours = int.Parse(Console.ReadLine());
                    Console.Write("Value per hour: ");
                    double value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Charge: ");
                    double charge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    OutsourcedEmployee outEmp = new OutsourcedEmployee
                        (name, hours, value, charge);
                    lista.Add(outEmp);
                } else
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Hours: ");
                    int hours = int.Parse(Console.ReadLine());
                    Console.Write("Value per hour: ");
                    double value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Employee emp = new Employee(name, hours, value);
                    lista.Add(emp);
                }
            }
            
            Console.WriteLine();
            Console.WriteLine("PAYMENTS");

            foreach(Employee emp in lista)
            {
                Console.WriteLine(emp);
            }
        }
    }
}