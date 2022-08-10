namespace ResolucaoDeProblemas {
    class Program {
        //Quando quiser rodar os exercicios mudar o nome do metodo para Main e trocar o Main atual para Teste
        public static void Main(String[] args) {
            Triangulo x, y;
            double areaX, areaY, m;

            x = new Triangulo();
            y = new Triangulo();

            Console.WriteLine("Digite os lados do primeiro triangulo: ");
            x.A = double.Parse(Console.ReadLine());
            x.B = double.Parse(Console.ReadLine());
            x.C = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite os lados do segundo triangulo: ");
            y.A = double.Parse(Console.ReadLine());
            y.B = double.Parse(Console.ReadLine());
            y.C = double.Parse(Console.ReadLine());

            areaX = Triangulo.CalcArea(x.A, x.B, x.C);
            areaY = Triangulo.CalcArea(y.A, y.B, y.C);


            Console.WriteLine("A área do triangulo x é: " + areaX);
            Console.WriteLine("A área do triangulo y é: " + areaY);

            Triangulo.Maior(areaX, areaY);
        }        
    }
}

