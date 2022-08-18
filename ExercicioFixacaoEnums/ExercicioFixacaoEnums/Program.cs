using ExercicioFixacaoEnums.Entities;
using ExercicioFixacaoEnums.Entities.Enums;

namespace ExercicioFixacaoEnums
{
    class Program
    {
        public static void Main(string[] args) {
            Console.WriteLine("Enter cliente data:");

            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date: ");
            DateTime birthday = DateTime.Parse(Console.ReadLine());                        

            Console.WriteLine("Enter order status");

            Console.Write("Status: ");
            OrderStatus os = Enum.Parse<OrderStatus>(Console.ReadLine());        

            Client cliente = new Client(name, email, birthday);
            Order order = new Order(DateTime.Now, os, cliente);

            Console.Write("How many items to this order?: ");
            int response = int.Parse(Console.ReadLine());

            for (int i = 0; i < response; i++)
            {
                Console.WriteLine($"Enter #{i + 1} item data;");

                Console.Write("Product name: ");
                string productName = Console.ReadLine();
                Console.Write("Product price: ");
                double productPrice = double.Parse(Console.ReadLine());
                Console.Write("Product quantity: ");
                int productQuantity = int.Parse(Console.ReadLine());

                Product product = new Product(productName, productPrice);
                OrderItem item = new OrderItem(productQuantity, product);

                order.AddItem(item);
            }

            Console.WriteLine();
            Console.WriteLine("ORDER SUMMARY;");

            Console.WriteLine(order);
        }
    }
}
