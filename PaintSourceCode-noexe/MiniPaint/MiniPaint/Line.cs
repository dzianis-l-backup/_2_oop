﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace oop_2
{
    public class Line : Figure
    {       
        private int x2;
        private int y2;
        public Line(int x1, int y1, int x2, int y2):base(x1,y1)
        {           
            this.x2 = x2;
            this.y2 = y2;
        }
        public override void Draw()
        {
            //Console.WriteLine("Line:(({0},{1}),({2},{3}))", X, Y, x2, y2);
        }
    }
        
}