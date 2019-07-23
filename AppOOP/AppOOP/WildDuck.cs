using System;
using System.Collections.Generic;
using System.Text;
using AppOOP.Interfaces;

namespace AppOOP
{
    public class WildDuck : Bird, ISwim, IFly, IWalk
    {
        public WildDuck(string pName) : base(pName)
        {
        }

        public void Fly(int speed)
        {
            Console.WriteLine($"I am a bird. My name is {Name} and I fly with {speed} km/h.");
        }

        public void Swim(int speed)
        {
            Console.WriteLine($"I am a bird. My name is {Name} and I swim with {speed} km/h.");
        }

        public void Walk(int speed)
        {
            Console.WriteLine($"I am a bird. My name is {Name} and I walk with {speed} km/h.");
        }
    }
}
