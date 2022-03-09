using System;
using System.Collections.Generic;

namespace List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            List<string> estados = new List<string>();
            estados.Add("SP");
            estados.Add("MG");
            estados.Add("BA");

            Console.WriteLine($"Quantidade de elementos na lista {estados.Count}");

            foreach (var item in estados)
            {
                Console.WriteLine(item);
            }

        }
    }
}
