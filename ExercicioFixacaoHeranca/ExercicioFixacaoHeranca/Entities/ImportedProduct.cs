using System.Text;
using System.Globalization;

namespace ExercicioFixacaoHeranca.Entities
{
    internal class ImportedProduct : Product
    {
        public double CustomFee { get; set; }

        public ImportedProduct()
        {
        }

        public ImportedProduct(string name, double price, double customFee) 
            : base(name, price)
        {
            CustomFee = customFee;
        }

        public double TotalPrice()
        {
            return Price + CustomFee;
        }

        public override string PriceTag()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Name + " $ " + 
               TotalPrice().ToString("F2", CultureInfo.InvariantCulture) +
                " (Customs fee: $ " + CustomFee + ")");
            
            return sb.ToString();
        }
    }
}
