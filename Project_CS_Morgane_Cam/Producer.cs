using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_CS_Morgane_Cam
{
    public class Producer : Person
    {
        private string company;

        public Producer(string n, int a, string nat, string comp) : base(n, a, nat)
        {
            company = comp;
        }

    }
}
