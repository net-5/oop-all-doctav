using System;
using System.Collections.Generic;
using System.Text;
using AppOOP.Interfaces;

namespace AppOOP
{
    public class Bat : Animal, IFly
    {
        public Bat(string pName) : base(pName)
        {
        }

        public void Fly(int speed)
        {
            Console.WriteLine($"I am a bat. My name is {Name} and I fly with {speed} km/h.");
        }
    }
}
