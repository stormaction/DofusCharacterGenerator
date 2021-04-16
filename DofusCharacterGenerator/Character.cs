using System;
using System.Collections.Generic;
using System.Text;

namespace DofusCharacterGenerator
{
    // Character class
    class Character
    {
        // Character infomations
        private string pseudonym;
        private string type;
        private string sexe;

        // Preset Types and sexes in case of empty answer
        private string[] allowedType = { "xelor", "iop", "cra", "enutrof", "feca", "sram" };
        private string[] sexes = { "femelle", "male" };

        // Character creation with sexe and type randomization when answer is empty
        public Character(string pseudonym, string type, string sexe)
        {
            Random randSexe = new Random();
            Random randType = new Random();

            this.pseudonym = pseudonym;
            this.type = type == "" ? allowedType[randType.Next(5)] : type;
            this.sexe = sexe == "" ? sexes[randSexe.Next(1)] : sexe;
        }

        // Get and set function for each 
        public string Pseudonym
        {
            get { return pseudonym; }
            set { pseudonym = value; }
        }

        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        public string Sexe
        {
            get { return sexe; }
            set { sexe = value; }
        }
    }
}
