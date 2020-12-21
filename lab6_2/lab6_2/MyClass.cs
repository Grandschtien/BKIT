using System;
using System.Collections.Generic;
using System.Text;

namespace lab6_2
{
    [MyClassAttribute(5)]
    class MyClass
    {
        public int x { get; private set; }
        public int y { get; private set; }

        public MyClass()
        {
            this.x = 0;
            this.y = 0;
        }
        public MyClass(int x)
        {
            this.x = x;
            this.y = 0;
        }
        public MyClass(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public string getXY()
        {
            return x.ToString() + " " + y.ToString();
        }

        public void setX(int X)
        {
            this.x = X;
        }

        public void setY(int Y)
        {
            this.y = Y;
        }
    }
}
