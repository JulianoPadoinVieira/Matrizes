using System;

namespace _81_Matrizes_Exercico_de_Fixação {
    //Fazer um programa para ler dois números inteiros M e N, e depois ler uma matriz de M linhas por N colunas contendo números inteiros,
    //podendo haver repetições.Em seguida, 
    //Ler um número inteiro X que pertence à matriz.Para cada ocorrência de X, mostrar os valores à
    //esquerda, acima, à direita e abaixo de X, quando houver, conforme exemplo.
    class Program {
        static void Main(string[] args) {

            //Vetor para pegar o tamanho da Matriz
            string[] tamanho = new string[2];
            //Pegar o tamanho e armazenar no vetor
            tamanho = Console.ReadLine().Split(' ');
            //Inserir os valores da linha e da coluna
            int m = int.Parse(tamanho[0]);
            int n = int.Parse(tamanho[1]);
            //Cria a matriz
            int[,] matriz = new int[m, n];

            for (int i = 0; i < m; i++) {
                //Armazenar os valores em suas respectivas posições
                string[] linha = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++) {
                    matriz[i, j] = int.Parse(linha[j]);
                }
            }
            //Ler um número inteiro x
            int x = int.Parse(Console.ReadLine());

            for (int i = 0; i < m; i++) {
                for (int j = 0; j < n; j++) {

                    if (x == matriz[i, j]) {
                        Console.WriteLine("Position " + i + "," + j + ":");
                        if (j - 1 >= 0)
                            Console.WriteLine("Left: " + matriz[i, j - 1]);
                        if (i - 1 >= 0)
                            Console.WriteLine("Up: " + matriz[i - 1, j]);
                        if (j + 1 < n)
                            Console.WriteLine("Right: " + matriz[i, j + 1]);
                        if (i + 1 < m)
                            Console.WriteLine("Down: " + matriz[i + 1, j]);
                    }
                }
            }
        }
    }
}
