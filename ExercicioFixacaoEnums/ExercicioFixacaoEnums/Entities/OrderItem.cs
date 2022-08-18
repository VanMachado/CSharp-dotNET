namespace ExercicioFixacaoEnums.Entities
{
    internal class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; private set; }
        public Product Product { get; set; }

        public OrderItem() {
        }

        public OrderItem(int quantity, Product produto) {
            Quantity = quantity;
            Product = produto;
        }

        public double SubTotal() {
            Price = 0;
            Price += Product.Price * Quantity;
            
            return Price;
        }

        public override string ToString() {
            return Product.Name + ", "
                + "R$ " + Product.Price + ", Quantity: "
                + Quantity + ", Subtotal: R$ " + SubTotal();
        }
    }
}
