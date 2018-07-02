using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExample
{
    class Person
    {
       protected string FirstName;
       protected string LastName;
        protected string Description;

        public Person() { }
        public Person(string _firstname) { }
        public Person(string _firstname, string _lastname) { }

        virtual public string About() {
            return FirstName + " " + LastName + " is working.";
        }
        
    }
}
