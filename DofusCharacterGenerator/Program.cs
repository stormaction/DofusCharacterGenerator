using System;

namespace DofusCharacterGenerator
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Bienvenue sur DofusCharacterGenerator merci d'appuyer sur ENTRER pour lancer le jeu");
            if (Console.ReadKey().Key == ConsoleKey.Enter)
            {
                Hub.PersonnageSelection();
            }
        }
    }
}
