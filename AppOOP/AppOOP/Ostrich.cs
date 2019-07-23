using System;
using System.Collections.Generic;
using System.Text;
using AppOOP.Interfaces;

namespace AppOOP
{
    public class Ostrich : Bird, IWalk
    {
        public Ostrich(string pName) : base(pName)
        {
        }

        public void Walk(int speed)
        {
            Console.WriteLine($"I am a bird. My name is {Name} and I don't fly, but I walk with {speed} km/h.");
        }
    }
}
