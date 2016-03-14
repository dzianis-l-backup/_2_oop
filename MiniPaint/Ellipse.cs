﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2_oop
{
    public class Ellipse : Figure
    {
        public int a { get; set; }
        public int b { get; set; }
        public Ellipse(int x, int y,int a, int b )
            : base(x, y)
        {
            this.a = a;
            this.b = b;           
        }        
    }
}
