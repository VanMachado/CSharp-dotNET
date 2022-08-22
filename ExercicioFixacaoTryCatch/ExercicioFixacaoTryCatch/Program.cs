using ExercicioFixacaoTryCatch.Entities;
using ExercicioFixacaoTryCatch.Entities.Exceptions;
using System.Globalization;

try
{
    Console.WriteLine("Enter account data");

    Console.Write("Number: ");
    int number = int.Parse(Console.ReadLine());
    Console.Write("Holder: ");
    string name = Console.ReadLine();
    Console.Write("Initial balance: ");
    double balance = double.Parse(Console.ReadLine(),
        CultureInfo.InvariantCulture);
    Console.Write("WithDraw limit: ");
    double limit = double.Parse(Console.ReadLine(),
        CultureInfo.InvariantCulture);

    Account account = new Account(number, name, balance, limit);

    Console.WriteLine();
    Console.Write("Enter amount for withdraw: ");
    double amount = double.Parse(Console.ReadLine(), 
        CultureInfo.InvariantCulture);

    account.WithDraw(amount);

    Console.WriteLine("New balance: $ " +
        account.Balance.ToString("F2", CultureInfo.InvariantCulture));
}
catch (DomainException e)
{
    Console.WriteLine(e.Message);
}
catch (FormatException e)
{
    Console.WriteLine("Format error! " + e.Message);
}