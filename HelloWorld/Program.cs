using System;

namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Gebe die 1. Zahl ein");
            var ersteEingabe = Console.ReadLine();
            Console.WriteLine("Gebe die 2. Zahl ein");
            var zweiteEingabe = Console.ReadLine();
            
            int ersteZahl = Convert.ToInt32(ersteEingabe);
            int zweiteZahl = Convert.ToInt32(zweiteEingabe);

            int summe = ersteZahl + zweiteZahl;
            Console.WriteLine("Dein Ergebnis ist: " + summe);
            
            Console.ReadKey();
        }
    }
}