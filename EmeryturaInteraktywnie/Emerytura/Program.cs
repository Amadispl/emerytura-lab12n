using System;

namespace Emerytura
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Witaj!");

            Console.Write("Podaj imie:");
            string imie;
            imie=Console.ReadLine();

            Console.Write("Podaj nazwisko:");
            string nazwisko;
            nazwisko=Console.ReadLine();
            Console.WriteLine("Witaj " +" "+ imie +" "+ nazwisko + " !");
            Console.WriteLine("Witaj {0} {1}!", imie, nazwisko);
            Console.WriteLine("Witaj {imie} {nazwisko}!");

        }
    }
}
