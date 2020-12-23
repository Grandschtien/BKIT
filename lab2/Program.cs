using System;

namespace lab2
{

    interface Iprint
    {
         void print();
    }


    abstract class figure 
    {
        public string name { get; protected set; }
        protected double S;

        public figure(string name)
        {
            this.name = name;
        }
        public abstract double area();
        
    }

    class rectangle : figure, Iprint
    {
        public double wide { get; protected set; }
        public double high { get; protected set; }
       // private double S;
        public rectangle(string name, double wide, double high):base(name)
        {
            this.wide = wide;
            this.high = high;
        }

        public override double area()
        {
            S = this.high * this.wide;
            return S;
            //Console.WriteLine(S);
        }

        public override string ToString()
        {
            return $"Площадь {name} со сторонами {wide} {high} равна {S}";
        }

        public virtual void print()
        {
            Console.WriteLine(this.ToString());
        }

    }

    class square : rectangle
    {
        public int side { get; private set; }
       // private double S;
        public square(string name, int side):base(name, side, side)
        {
            this.side = side;
        }

        public override double area()
        {
            S = side * side;
            return S;
        }
        public override string ToString()
        {
            return $"Площадь {name} со стороной {side} равна {S}";
        }
        public override void print()
        {
           // this.area();
           Console.WriteLine(this.ToString());
        }
    }
    class circle : figure, Iprint
    {
        public int radius { get; private set; }
       // private double S;
        public circle(string name, int radius):base(name)
        {
            this.radius = radius;
        }
        public override double area()
        {
            double pi = 3.14;
            S = pi * radius * radius;
            return S;
        }

        public override string ToString()
        {
            return $"Площадь {name} с радиусом {radius} и площадью {S}";
        }
        public void print()
        {
            Console.WriteLine(this.ToString());
        }

    }
   
    class Program
    {
        static void Main(string[] args)
        {
            rectangle ret = new rectangle("Прямоугольника", 5, 7);
            ret.area();
            ret.print();
            
            square sq = new square("Квадрат", 5);
            sq.area();
            sq.print();

            circle cir = new circle("Круга", 8);
            cir.area();
            cir.print();

        }
    }
}
