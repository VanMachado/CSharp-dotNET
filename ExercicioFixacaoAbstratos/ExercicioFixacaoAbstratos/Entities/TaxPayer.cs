namespace ExercicioFixacaoAbstratos.Entities
{
    abstract class TaxPayer
    {
        public string Name { get; private set; }
        public double AnualCome { get; private set; }

        protected TaxPayer(string name, double anualCome)
        {
            Name = name;
            AnualCome = anualCome;
        }

        public abstract double Tax();
    }
}
