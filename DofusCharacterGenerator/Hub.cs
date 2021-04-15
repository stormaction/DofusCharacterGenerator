﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace DofusCharacterGenerator
{    class Hub
    {

        private static void displayHelp()
        {
            Console.WriteLine("\nPour créer un nouveau personnage : ADD\n" +
                "Pour selectionner un personnage : Pseudonyme de votre personnage\n" +
                "Pour supprimer un personnage: SUPP puis suivre les instructions");

        }

        private static Character NewCharacter()
        {

            Console.WriteLine("\nChoisissez le type de votre personnage");
            string type = Console.ReadLine();
            Console.WriteLine("\nChoisissez votre sexe");
            string sexe = Console.ReadLine();
            Console.WriteLine("\nChoisissez votre pseudonyme *OBLIGATOIRE");
            string pseudonyme = Console.ReadLine();
            if (pseudonyme == null)
            {
                NewCharacter();
            }
            Character newCharacter = new Character(pseudonyme, type, sexe);
            return newCharacter;
        }

        private static void DeleteCharacter(List<Character> Characters)
        {
            Console.WriteLine("Rentrez le pseudonyme du joueur à supprimer");
            string op = Console.ReadLine();
            var item = Characters.SingleOrDefault(character => character.Pseudonym == op);
            if (item != null) { 
                Characters.Remove(item);
                Console.WriteLine("Personne {0} à bien été supprimé\n", item.Pseudonym);
                PersonnageSelection(Characters);
            } else
            {
                Console.WriteLine("Personnage non trouvé veuillez réssayer\n");
                DeleteCharacter(Characters);
            }
        }

        private static string SelectedCharacter(List<Character> Characters, string op)
        {
            var item = Characters.SingleOrDefault(character => character.Pseudonym == op);
            if (item == null)
            {
                return "";
            }
            return op;
        }

        private static void displayCharacterInfo(string op)
        {
            throw new NotImplementedException();
        }

        public static void PersonnageSelection([Optional] List<Character> updatedList)
        {
            List<Character> Characters = updatedList != null ? new List<Character>(updatedList) : new List<Character>();
            Console.WriteLine("\nSi vous avez besoin d'aider tapez la commande : HELP");
            if (Characters.Capacity == 0)
            {
                Console.WriteLine("Vous n'avez pas de personnage veuillez en créer un");
            } else
            {
                Console.WriteLine("Voici vos personnage. Choisissez en un en tapant son Pseudonyme\n");
                foreach (Character character in Characters)
                {
                    Console.WriteLine("\n Pseudonyme : {0}, Class: {1} ", character.Pseudonym, character.Type);
                }
            }

            string op = Console.ReadLine();
            string test = SelectedCharacter(Characters, op);

            switch (op.ToLower())
            {
                case "add":
                    Character newCharacter = NewCharacter();
                    Characters.Add(newCharacter);
                    PersonnageSelection(Characters);
                    break;
                case "help":
                    displayHelp();
                    PersonnageSelection(Characters);
                    break;
                case "supp":
                    DeleteCharacter(Characters);
                    break;
                case test:
                    displayCharacterInfo(op);
                    break;
                default :
                    PersonnageSelection(Characters);
                    break;
            }
        }

    }
}