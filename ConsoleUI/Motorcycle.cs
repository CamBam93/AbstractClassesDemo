﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    class Motorcycle : Vehicle
    {
        public bool HasSideCart { get; set; } = false;
        public override void DriveAbstract()
        {
            Console.WriteLine("Motorcycle in drive");
        }
        public override void DriveVirtual()
        {
            Console.WriteLine($"{GetType().Name} is a {GetType().BaseType.Name} that is virtual");
        }
    }
}