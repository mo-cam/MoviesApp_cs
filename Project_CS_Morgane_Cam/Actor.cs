using System.Collections.Generic;

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
