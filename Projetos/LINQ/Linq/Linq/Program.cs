using System;
using System.Linq;

namespace Linq
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] arrayNumeros = new int[5] { 1, 4, 8, 15, 19 };

            var numerosParesQuery = 
                from num in arrayNumeros
                where num % 2 == 0
                orderby num
                select num;

            var numerosParesMetodo = arrayNumeros.Where(x => x % 2 == 0).OrderBy(x => x).ToList();

            Console.WriteLine("Numeros pares query: "+ String.Join(", ", numerosParesQuery));
            Console.WriteLine("Numeros pares método: "+ String.Join(", ", numerosParesMetodo));
        }
    }
}
