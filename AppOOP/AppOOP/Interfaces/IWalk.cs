using System;
using System.Collections.Generic;
using System.Text;

namespace AppOOP.Interfaces
{
    interface IWalk
    {
        void Walk(int speed);
        int WalkSpeed { get; set; }
    }
}
