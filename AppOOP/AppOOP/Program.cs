using System;

namespace AppOOP
{
    class Program
    {
        //Make an application where to model a animals keeping in mind that:

        //any kind you model is an animal
        //any animal has a name
        //there are multiple animal categories like : mammals, fish, birds, reptile, insects
        //no matter the category, animal are : flying, walking, swim or crawl.
        //depending on the way they move, they have a maximum speed.
        //there are animals that can swim and walk (Platypus)
        //there are animals that can swim, fly and walk (Wild Duck)
        //Not any animal that can fly is a bird, the bat is a mammal that flys, and not evey bird flys - the ostrich is a bird but doesn't fly
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! Here we have some amazing animals!");

            Bat myBat = new Bat("BatMan");
            myBat.Fly(100);

            WildDuck myDuck = new WildDuck("Duffy Duck");
            myDuck.Fly(30);
            myDuck.Swim(80);
            myDuck.Walk(10);

            Platypus myPlatypus = new Platypus("Small platypus");
            myPlatypus.Swim(40);
            myPlatypus.Walk(5);

            Ostrich myOstrich = new Ostrich("Long Neck");
            myOstrich.Walk(200);
        }
    }
}
