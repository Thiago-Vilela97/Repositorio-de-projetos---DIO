using System;
using System.Collections.Generic;

namespace Stack_PILHA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<string> pilhaLivros = new Stack<string>();

            pilhaLivros.Push(".Dnet");
            pilhaLivros.Push("DDD");
            pilhaLivros.Push("Codigo limpo");

            Console.WriteLine($"Livros para leitura: {pilhaLivros.Count}");
            while (pilhaLivros.Count > 0)
            {
                Console.WriteLine();
                Console.WriteLine($"Próximo livro para leitura: {pilhaLivros.Peek()}");
                Console.WriteLine($"Livro lido com sucesso: {pilhaLivros.Pop()}");
            }
            Console.WriteLine();
            Console.WriteLine($"Livros para leitura: {pilhaLivros.Count}");
        }
    }
}
