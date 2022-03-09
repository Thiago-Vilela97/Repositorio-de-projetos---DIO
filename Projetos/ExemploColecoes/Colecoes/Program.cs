using System;
using Colecoes.helper;

namespace Colecoes

{
    class Program
    {
        static void Main(string[] args)
        {

            OperacoesArray op = new OperacoesArray();
            int [] array = new int[5] {6, 3, 8, 1, 9}; 

            System.Console.WriteLine("Array original: ");
            op.ImprimirArray(array);

            op.OrdenarBubbleSort(ref array);
            System.Console.WriteLine("Array ordenado: ");
            op.ImprimirArray(array);

            // int[,] matriz = new int[4,2] {
            //     {8, 8},
            //     {10, 20},
            //     {50,100},
            //     {90,200}
            // };

            // for (int i = 0; i < matriz.GetLength(0); i++)
            // {
            //     for (int j = 0; j < matriz.GetLength(1); j++)
            //     {
            //         Console.WriteLine(matriz[i,j]);
            //     }
            // }

            // int[] arrayInteiros = new int[3];


            // arrayInteiros[0] = 10;
            // arrayInteiros[1] = 20;
            // arrayInteiros[2] = 30;

            // for (int i = 0; i < arrayInteiros.Length; i++) {
            //     Console.WriteLine(arrayInteiros[i]);
            // }

            // System.Console.WriteLine(   "-------------------------------");

            // foreach (var item in arrayInteiros)
            // {
            //     Console.WriteLine(item);
            // }
        }
    }
}