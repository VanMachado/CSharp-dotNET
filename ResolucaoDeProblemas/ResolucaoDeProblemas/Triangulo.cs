namespace ResolucaoDeProblemas {
    internal class Triangulo {
        public double A;
        public double B;
        public double C;

        public static double CalcArea(double a, double b, double c) {
            double p;
            double area;

            p = (a + b + c) / 2;
            area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

            return area;
        }

        public static void Maior(double num1, double num2) {

            if (num1 > num2) {
                Console.WriteLine("O triangulo maior é: X");
            } else {
                Console.WriteLine("O triangulo maior é: Y");
            }            
        }
    }
}
