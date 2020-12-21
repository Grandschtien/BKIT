using System;

namespace lab6
{
    public delegate string delegate1(int name1, string name2); // тип_возвщаемого_значения имя_делегата(тип_возващ_аргум агумент)
    class Program
    {
         
        static void Main(string[] args)
        {
            
            string str = Console.ReadLine();
            int a = Convert.ToInt32(Console.ReadLine());
            delegate1 mydelegate = method1;
            mydelegate(a, str);

            Console.WriteLine("----------------- Секция обычных делегатов ------------------");

            method2(a, str, mydelegate);

            Console.WriteLine("-----------------------------------");

            delegate1 delegate2 = (x, y) => y + " " + x.ToString();
            Console.WriteLine(delegate2(a, str));

            Console.WriteLine("------------- Секция Action -------------");

            Action<int, string> action_delegate = (x, y) => Console.WriteLine(x.ToString() + " " + str);
            Action<int, string> action_delegate2 = method3;

            action_delegate(a, str);
            action_delegate2(a, str);

            Console.WriteLine("------------------- Секция Func ----------------------");

            Func<int, string, string> funcdelegat = method1;

            method_func(str, a, funcdelegat);

        }

        
         public static string method1(int a, string str)
         {
            string result = str + " " + a.ToString();
            Console.WriteLine(result);
            return result;
         }

        public static string method4(int a, string str1)
        {
            return str1;
        }
        public static void method3(int a, string str)
        {
            string result = str + " " + a.ToString();
            Console.WriteLine(result);
            
        }
        public static void method2(int a, string str1, delegate1 mydeleg)
        {
            mydeleg(a, str1);
        }

        public static void method_func(string str, int a, Func<int, string, string> func)
        {
            string i = str + func(a, str);
        }

        //public void Method_del(string st, delegate1(string str, int a))
        //{

        //}

    }
}
