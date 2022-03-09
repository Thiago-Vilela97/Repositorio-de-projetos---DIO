using System;
using System.Collections.Generic;

namespace Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> estados = new Dictionary<string, string>();

            estados.Add("SP", "São Paulo");
            estados.Add("MG", "Minas");
            estados.Add("BA", "Bahia");

            foreach (KeyValuePair<string, string> item in estados)
            {
                Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
            }

            Console.WriteLine();

            string valorProcurado = "BA";

            Console.WriteLine($"Removendo o valor: {valorProcurado}");

            estados.Remove(valorProcurado);

            foreach (KeyValuePair<string, string> item in estados)
            {
                Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
            }

            //Console.WriteLine("Valor original: ");
            //Console.WriteLine(estados[valorProcurado]);

            //estados[valorProcurado] = "BA - Teste atualização";
            //Console.WriteLine("Valor atualizado");
            //Console.WriteLine(estados[valorProcurado]);
        }
    }
}
