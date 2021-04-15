using System;
using System.Collections.Generic;
using System.Text;

namespace DofusCharacterGenerator
{
    class Character
    {
        private string pseudonym;
        private string type;
        private string sexe;
        private string[] allowedType = { "xelor", "iop", "cra", "enutrof", "feca", "sram" };
        private string[] sexes = { "femelle", "male" };
        public Character(string pseudonym, string type, string sexe)
        {
            Random randSexe = new Random();
            Random randType = new Random();

            this.pseudonym = pseudonym;
            this.type = type == "" ? allowedType[randType.Next(5)] : type;
            this.sexe = sexe == "" ? sexes[randSexe.Next(1)] : sexe;
        }

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
