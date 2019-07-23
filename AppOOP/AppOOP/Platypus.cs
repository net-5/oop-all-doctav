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

        public int WalkSpeed { get; set; }
        public int SwimSpeed { get; set; }

        public void Swim(int speed)
        {
            if (speed < SwimSpeed)
            {
                Console.WriteLine($"I am a platypus. My name is {Name} and I swim with {speed} km/h.");
            }
            else
            {
                Console.WriteLine($"I am a platypus. My name is {Name} and my maximum swim speed is {SwimSpeed} km/h.");
            }
        }

        public void Walk(int speed)
        {
            if (speed < WalkSpeed)
            {
                Console.WriteLine($"I am a platypus. My name is {Name} and I walk with {speed} km/h");
            }
            else
            {
                Console.WriteLine($"I am a platypus. My name is {Name} and may maximum walk speed is {WalkSpeed} km/h");
            }
        }
    }
}
