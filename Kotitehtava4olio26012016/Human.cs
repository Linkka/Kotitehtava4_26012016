﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kotitehtava4olio26012016
{
    public class Human : Creature
    {
        public int Height { get; set; }


        // override base class ToString()-method
        public override string ToString()
        {
            return base.ToString() + " " + Height;
        }
    }
}
