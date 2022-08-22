namespace ExercicioFixacaoAbstratos.Entities
{
    internal class Individual : TaxPayer
    {
        public double HealthExpenditures { get; private set; }

        public Individual(double health, string name, double anualCome) 
            : base(name, anualCome)
        {
            HealthExpenditures = health;
        }

        public override double Tax()
        {            
            if(AnualCome < 20000)
            {
                if (HealthExpenditures > 0)
                {
                    return AnualCome * 0.15 - HealthExpenditures * .5;
                } else
                {
                    return AnualCome * 0.15;
                }
            } else
            {
                if (HealthExpenditures > 0)
                {
                    return AnualCome * 0.25 - HealthExpenditures * .5;
                }
                else
                {
                    return AnualCome * 0.25;
                }
            }
        }
    }
}
