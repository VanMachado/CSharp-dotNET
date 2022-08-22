namespace ExercicioFixacaoAbstratos.Entities
{
    internal class Company : TaxPayer
    {        
        public int NumberOfEmployees { get; private set; }

        public Company(int employees, string name, double anualCome)
            : base(name, anualCome)
        {
            NumberOfEmployees = employees;
        }

        public override double Tax()
        {
            if(NumberOfEmployees <= 10)
            {
                return AnualCome * 0.16;
            } else
            {
                return AnualCome * 0.14;
            }
        }
    }
}
