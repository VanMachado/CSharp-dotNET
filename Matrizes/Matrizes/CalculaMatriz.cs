namespace Matrizes {
    internal class CalculaMatriz {
        public static void CalcMat(int n) {
            int[,] mat = new int[n, n];
            int count = 0;

            Console.WriteLine("Digite os valores da matriz: ");

            for (int i = 0; i < n; i++) {
                string[] valor = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++) {
                    mat[i, j] = int.Parse(valor[j]);                     
                }
            }
            
            Console.WriteLine();
            Console.Write("Diagonal principal: ");

            for (int i = 0; i < n; i++) {
                for (int j = 0; j < n; j++) {
                    if(i == j) {
                        Console.Write(mat[i, j] + " ");
                    }
                }
            }

            Console.WriteLine();

            //Imprime a diagonal secundária
            Console.Write("Diagonal secundária: ");
            for (int i = 0; i < n; i++) {
                for (int j = 0; j < n; j++) {
                    if (i == i && j == (n - 1 - i)) {
                        Console.Write(mat[i, j] + " ");
                    }
                }
            }

            Console.WriteLine();

            for (int i = 0; i < n; i++) {
                for (int j = 0; j < n; j++) {
                    if (mat[i, j] < 0) { 
                    count += 1;
                    }
                }
            }

            Console.WriteLine("Existem {0} números negativos", count);
        }
    }
}
