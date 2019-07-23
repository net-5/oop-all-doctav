using System;
using System.Collections.Generic;
using System.Text;

namespace AppOOP
{
    public abstract class Animal
    {
        private string name;

        public string Name
        {
            get { return name; }
            private set { name = value; }
        }

        public Animal(string pName)
        {
            Name = pName;
        }

    }
}
