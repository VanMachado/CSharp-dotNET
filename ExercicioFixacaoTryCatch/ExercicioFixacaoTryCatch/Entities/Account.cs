using ExercicioFixacaoTryCatch.Entities.Exceptions;

namespace ExercicioFixacaoTryCatch.Entities
{
    internal class Account
    {
        public int Number { get; private set; }
        public string Holder { get; private set; }
        public double Balance { get; private set; }
        public double WithDrawLimit { get; private set; }

        public Account()
        {
        }

        public Account(int number, string holder, double balance, double withDrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithDrawLimit = withDrawLimit;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public void WithDraw(double amount)
        {
            if(WithDrawLimit < amount)
            {
                throw new DomainException("Withdraw error: The amount exceeds withdraw limit");
            }
            if(Balance < amount)
            {
                throw new DomainException("Withdraw error: Not enough balance");
            }

            Balance -= amount;
        }
    }
}
