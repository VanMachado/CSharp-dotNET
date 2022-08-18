using Enumeracoes.Entities.Enums;

namespace Enumeracoes.Entities
{
    internal class HourContract
    {
        public DateTime Date { get; private set; }
        public double ValuePerHour { get; private set; }
        public int Hours { get; private set; }

        public HourContract (DateTime date, double value, int hours) {
            Date = date;
            ValuePerHour = value;
            Hours = hours;
        }

        public HourContract() {
        }

        public double TotalValue() {
            return Hours * ValuePerHour;
        }

        public override string ToString() {
            return Date + ", R$ " + TotalValue()
                 + ", " + Hours;
        }
    }
}
