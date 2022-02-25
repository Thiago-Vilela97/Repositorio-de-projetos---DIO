using System;

namespace jogoRPG
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Knight arus = new Knight("Arus", 23, "Knight");
            Wizard wizard = new Wizard("Jenica", 23, "White wizard");
            Ninja wedge = new Ninja("Wedge", 42, "Ninja");

            Console.WriteLine(arus.Attack());
            Console.WriteLine(wizard.Attack());
            Console.WriteLine(wizard.Attack(5));
            Console.WriteLine(wedge);
        }
    }
}
