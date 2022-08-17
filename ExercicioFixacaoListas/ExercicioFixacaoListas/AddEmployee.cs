using System.Globalization;

namespace ExercicioFixacaoListas {
    internal class AddEmployee {
        public static void AddEmp() {
            List<Employee> employees = new List<Employee>();

            Console.Write("How many employees will be registred?: ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int i = 0; i < num; i++) {
                Console.WriteLine("Employee #" + (i + 1));
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                
                while (employees.Find(x => x.Id == id) != null) {
                    Console.Write("Id invalido, digite novamente: ");
                    id = int.Parse(Console.ReadLine());
                }

                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salaray = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                employees.Add(new Employee(id, name, salaray));
                Console.WriteLine();
            }

            Console.Write("Enter the employee id that will be have salary increase: ");
            int idEmp = int.Parse(Console.ReadLine());

            Employee emp = employees.Find(x => x.Id == idEmp);
            //Usando solução baseada nos metodos das listas
            if (emp != null) {
                Console.Write("Enter the percent: ");
                double percent = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine();
                emp.IncreaseSalary(percent);

                //Usando um for
                /*
                for (int i = 0; i < num; i++) {
                    if (employees[i].Id == idEmp) {
                    employees[i].IncreaseSalary(percent);
                    }
                }
                    */
            } else {
                Console.WriteLine("This Id doesn't exist!");
                Console.WriteLine();
            }

            Console.WriteLine("Update employee list:");

            foreach (Employee e in employees) {
                Console.WriteLine(e);
            }

        }


    }
}