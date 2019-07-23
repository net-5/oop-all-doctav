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

        public int FlySpeed { get; set; }

        public void Fly(int speed)
        {
            if (speed < FlySpeed)
            {
                Console.WriteLine($"I am a bat. My name is {Name} and I fly with {speed} km/h.");
            }
            else
            {
                Console.WriteLine($"I am a bat. My name is {Name} and my maximum speed is {FlySpeed} km/h.");
            }
        }
    }
}
