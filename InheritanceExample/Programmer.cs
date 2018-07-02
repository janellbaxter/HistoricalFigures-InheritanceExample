using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExample
{
    class Programmer: Person
    {
        public Programmer(string _firstname) {
            FirstName = _firstname;
        }

        public Programmer(string _firstname, string _lastname)
        {
            FirstName = _firstname;
            LastName = _lastname;
        }

        public Programmer(string _firstname, string _lastname, string _description)
        {
            FirstName = _firstname;
            LastName = _lastname;
            Description = _description;
        }

        override public string About()
        {
            return FirstName + " " + LastName + " (known for " + Description + ") worked as a programmer.";
        }
    }
}
