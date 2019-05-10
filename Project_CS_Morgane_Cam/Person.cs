using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_CS_Morgane_Cam
{
    public abstract class Person
    {
        public string name { get; set; }
        protected int age { get; set; }
        protected string nationality { get; set; }

        protected Person(string n, int a, string nat)
        {
            name = n;
            age = 2019 - a;
            nationality = nat;
        }

        public bool Equals(Person other)
        {
            return (other.name == this.name) && (other.age == this.age) && (other.nationality == this.nationality);
        }
    }
}
