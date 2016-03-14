﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace _2_oop
{
    public abstract class Figure
    {
        private int x;
        private int y;
        public int X
        {
            get
            {
                return this.x;
            }
            private set
            {                
                if (value <= 0)
                    throw new Exception("Invalid parameter: less than zero!");
                this.x = value;
            }
        }
        public int Y
        {
            get
            {
                return this.y;
            }
            private set
            {
                if (value <= 0)
                    throw new Exception("Invalid parameter: less than zero!");
                this.y = value;
            }
        }
        protected Figure(int x, int y)
        {
            X = x;
            Y = y;
        }             
    }
    public interface Painter
    {
        void Draw(Figure figure, MouseEventArgs e, int length, int height);
    }
}