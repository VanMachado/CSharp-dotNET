namespace TesteStruct {
    internal class RefEOut {
        public static void TesteRefEOut() {
            int num = 5;
            int triplo;
            Console.WriteLine(Calculadora.Soma(5, 2, 1));
            Console.WriteLine();
            Calculadora.Triplicar(ref num);
            Console.WriteLine(num);
            Console.WriteLine();
            Calculadora.TriplicarOut(num, out triplo);
            Console.WriteLine(triplo);
        }
    }
}
