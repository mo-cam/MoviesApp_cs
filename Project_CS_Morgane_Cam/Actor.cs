using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_CS_Morgane_Cam
{
    public class Actor : Person
    {
        private List<string> characters;

        public Actor(string n, int a, string nat) : base(n,a,nat)
        {
            characters = new List<string>();
        }

    }
}
