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

        public int SwimSpeed { get; set; }
        public int WalkSpeed { get; set; }
        public int FlySpeed { get; set; }

        public void Fly(int speed)
        {
            if (speed < FlySpeed)
            {
                Console.WriteLine($"I am a bird. My name is {Name} and I fly with {speed} km/h.");
            }
            else
            {
                Console.WriteLine($"I am a bird. My name is {Name} and my maximum fly speed is {FlySpeed} km/h.");
            }
        }

        public void Swim(int speed)
        {
            if (speed < SwimSpeed)
            {
                Console.WriteLine($"I am a bird. My name is {Name} and I swim with {speed} km/h.");
            }
            else
            {
                Console.WriteLine($"I am a bird. My name is {Name} and my maximum swim speed is {SwimSpeed} km/h.");
            }
        }

        public void Walk(int speed)
        {
            if (speed < WalkSpeed)
            {
                Console.WriteLine($"I am a bird. My name is {Name} and I walk with {speed} km/h.");
            }
            else
            {
                Console.WriteLine($"I am a bird. My name is {Name} and my maximum walk speed is {WalkSpeed} km/h.");
            }
        }
    }
}
