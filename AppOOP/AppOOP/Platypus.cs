using System;
using System.Collections.Generic;
using System.Text;
using AppOOP.Interfaces;

namespace AppOOP
{
    public class Platypus : Mammal, ISwim, IWalk
    {
        public Platypus(string pName) : base(pName)
        {
        }

        public void Swim(int speed)
        {
            Console.WriteLine($"I am a platypus. My name is {Name} and I swim with {speed} km/h.");
        }

        public void Walk(int speed)
        {
            Console.WriteLine($"I am a platypus. My name is {Name} and I walk with {speed} km/h");
        }
    }
}
