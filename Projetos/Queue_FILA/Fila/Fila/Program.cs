using System;
using System.Collections.Generic;

namespace Fila
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> fila = new Queue<string>();

            fila.Enqueue("Thiago");
            fila.Enqueue("Leo");
            fila.Enqueue("Biel");

            Console.WriteLine($"Pessoas na fila: {fila.Count}");
            while (fila.Count > 0)
            {
                Console.WriteLine($"vez de: {fila.Peek()}");
                Console.WriteLine($"{fila.Dequeue()} atendido");
            }

            Console.WriteLine($"Pessoas na fila: {fila.Count}");
        }
    }
}
