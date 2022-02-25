using System;

namespace Aula3
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());

            int[] guardaValor = new int[5];
            int result = 0;
            while (x > 0)
            {
                
                if (x % 2 == 0)
                {
                    guardaValor[0] = x;
                    guardaValor[1] = x + 2;
                    guardaValor[2] = x + 4;
                    guardaValor[3] = x + 6;
                    guardaValor[4] = x + 8;
                    result = guardaValor[0] + guardaValor[1] + guardaValor[2] + guardaValor[3]
                        + guardaValor[4];
                    Console.WriteLine(result);
                }
                else
                {
                    guardaValor[0] = x + 1;
                    guardaValor[1] = x + 3;
                    guardaValor[2] = x + 5;
                    guardaValor[3] = x + 7;
                    guardaValor[4] = x + 9;
                    result = guardaValor[0] + guardaValor[1] + guardaValor[2] + guardaValor[3]
                        + guardaValor[4];
                    Console.WriteLine(result);
                }
                x = int.Parse(Console.ReadLine());
            }



        }
    }
}
