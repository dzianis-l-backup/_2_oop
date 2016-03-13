﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _oop_2
{
    public class Rectangle : Figure
    {        
        private int rightX;
        private int rightY;
        public Rectangle(int xl, int yl,int xr, int yr):base(xl,yl)
        {                   
            rightX = xr;
            rightY = yr;
        }
        public override void Draw()
        {
            //Console.WriteLine("Rectangle:({0},{1},{2},{3})", X, Y, rightX, rightY);
        }
    }
}
