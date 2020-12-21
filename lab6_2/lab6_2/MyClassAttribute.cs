using System;
using System.Collections.Generic;
using System.Text;

namespace lab6_2
{
    public class MyClassAttribute : System.Attribute
    {
        public int x { get; set; }
        public MyClassAttribute()
        { }
        public MyClassAttribute(int X)
        {
            x = X;
        }
    }

}
