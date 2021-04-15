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
            this.pseudonym = pseudonym;
            this.type = type;
            this.sexe = sexe;
        }

        public Character(string pseudonym)
        {
            Random randSexe = new Random(1);
            Random randType = new Random(5);

            this.pseudonym = pseudonym;
            this.type = allowedType[randType.Next()];
            this.sexe = sexes[randSexe.Next()];
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
