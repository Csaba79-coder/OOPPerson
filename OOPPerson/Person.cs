using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPerson
{
    class Person
    {
        private int dateOfBirth;
        private string name;
        private bool isMale;

        public Person(string name, int dateOfBirth, bool isMale)
        {
            this.name = name;
            this.dateOfBirth = dateOfBirth;
            this.isMale = isMale;
        }

        public string getName()
        {
            return name;
        }

        public int getDateOfBirth()
        {
            return dateOfBirth;
        }

        public bool getIsMale()
        {
            return isMale;
        }

        public int getAge()
        {
            return System.DateTime.Now.Year - dateOfBirth;
        }
    }
}
