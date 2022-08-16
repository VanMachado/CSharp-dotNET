namespace Matrizes {
    internal class ExercicioFixacao {
        public static void AoRedor(int n, int m) {
            int[,] matriz = new int[n, m];            

            Console.WriteLine("Preencha a matriz: ");

            for (int i = 0; i < n; i++) {
                string[] valor = Console.ReadLine().Split(' ');
                for (int j = 0; j < m; j++) {
                    matriz[i, j] = int.Parse(valor[j]);
                }
            }

            Console.WriteLine();
            Console.Write("Digite um número da matriz: ");
            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++) {
                for (int j = 0; j < m; j++) {                    
                    if (num == matriz[i, j]) {                        
                        Console.Write("Posicao " + i
                            + "," + j + ":");
                        
                        Console.WriteLine();
                        Console.WriteLine();

                        if (j > 0) {
                            int esquerda = matriz[i, j - 1];
                            Console.WriteLine("Esquerda: " + esquerda);
                        }                                                                      

                        if (j < m-1) {
                            int direita = matriz[i, j + 1];
                            Console.WriteLine("Direita: " + direita);
                        }

                        if(i>0) {
                            int cima = matriz[i - 1, j];
                            Console.WriteLine("Cima: " + cima);
                        }


                        if (i < n-1) {
                            int baixo = matriz[i + 1, j];
                            Console.WriteLine("Baixo: " + baixo);
                        }

                        Console.WriteLine();
                    }
                }
            }
            Console.WriteLine();
        }        
    }
}
