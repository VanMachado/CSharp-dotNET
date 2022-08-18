namespace TopicosEspeciais {
    internal class Produto {
        public string Nome { get; set; }    
        public int Sku { get; set; }    
        public double Preco { get; set; }

        public Produto(string name, int size, double price) {
            Nome = name;
            Sku = size;
            Preco = price;
        }

        public override string ToString() {
            return Nome + ", SKU: " + Sku
                + ", Preço: " + Preco.ToString("F2");
        }
    }
}
