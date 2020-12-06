using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Random
{
    class Participant
    {
        private string pseudo;

        public Participant()
        {
        }

        public Participant(string unPseudo)
        {
            this.pseudo = unPseudo;
        }


        public string Pseudo { get; set; }

        public override string ToString()
        {
            return pseudo;
        }
    }
}
