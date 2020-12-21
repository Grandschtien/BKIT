using System;
using System.Reflection;

namespace lab6_2
{
    class Program
    {
        static void Main(string[] args)
        {
           
            ConstructorInfo[] constr = typeof(MyClass).GetConstructors();

            for(int i = 0; i < constr.Length; i++)
            {
                Console.WriteLine(constr[i]);
            }

            MyClass myclass1 = new MyClass(1, 6);
            MyClass myClass = new MyClass(6, 1);
            bool myClassIsValid = ValidXorY(myClass);
            bool myClass1IsValid = ValidXorY(myclass1);

            Console.WriteLine($"Реультат валидации myClass: {myClassIsValid}");
            Console.WriteLine($"Реультат валидации myclass1: {myClass1IsValid}");
        }

        static bool ValidXorY(MyClass myclass)
        {
            Type t = typeof(MyClass);
            object[] attrs = t.GetCustomAttributes(false);
            foreach (MyClassAttribute attr in attrs)
            {
                if (myclass.x >= attr.x) return true;
                else return false;
            }
            return true;
        }
    }
}
