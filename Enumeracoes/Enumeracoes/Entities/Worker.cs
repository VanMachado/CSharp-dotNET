using Enumeracoes.Entities.Enums;

namespace Enumeracoes.Entities
{
    internal class Worker
    {
        public string Name { get; private set; }
        public WorkerLevel Level { get; private set; }
        public double BaseSalary { get; private set; }
        public Departament Departament { get; private set; }
        //Isso é uma associação um para muitos
        public List<HourContract> Contracts { get; set; } = new List<HourContract>();

        public Worker() {
        }

        public Worker(string name, WorkerLevel level, double basicSalary, Departament departament) {
            Name = name;
            Level = level;
            BaseSalary = basicSalary;
            Departament = departament;
        }

        public void AddContract(HourContract contract) {
            Contracts.Add(contract);
        }

        public void RemoveContract(HourContract contract) {
            Contracts.Remove(contract);
        }

        public double Income(int year, int month) {
            double sum = BaseSalary;          

            foreach (HourContract contract in Contracts) {
                if (contract.Date.Year == year && contract.Date.Month == month) {
                    sum += contract.TotalValue();
                }
            }
            return sum;
        }
    }    
}
