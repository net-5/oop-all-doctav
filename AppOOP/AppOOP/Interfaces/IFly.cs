using System;
using System.Collections.Generic;
using System.Text;

namespace AppOOP.Interfaces
{
    interface IFly
    {
        void Fly(int speed);
        int FlySpeed { get; set; }
    }
}
