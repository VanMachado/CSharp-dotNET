using System.Globalization;
using System.Text;

namespace Heranca.Entities
{
    internal class Employee
    {
        public string Name { get; private set; }
        public int Hours { get; private set; }
        public double ValuePerHour { get; private set; }

        public Employee()
        {
        }

        public Employee(string name, int hours, double valuePerHour)
        {
            Name = name;
            Hours = hours;
            ValuePerHour = valuePerHour;
        }

        public virtual double Payment()
        {
            return ValuePerHour * Hours;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();            
            sb.Append(Name + " - $ " + Payment().ToString("F2", CultureInfo.InvariantCulture));

            return sb.ToString();  
        }
    }
}
