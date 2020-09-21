using System;

namespace lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1, x2;
            double A = ReadDouble("Введите коэф. А: ");
            Console.WriteLine("Коэф. А = "+ A);

            double B = ReadDouble("Введите коэф.В: ");
            Console.WriteLine("Коэф. В = " + B);

            double C = ReadDouble("Введите коэф. С: ");
            Console.WriteLine("Коэф. С = " + C);
            double D = B * B - 4 * A * C;
            if(D < 0)
            {
                Console.WriteLine("Корней нет");
            }
            if(D == 0)
            {
                x1 = -B / (2 * A);
                Console.WriteLine("Корень один и равен - " + x1);
            }
            if(D > 0)
            {
                x1 = (-B + Math.Sqrt(D)) / (2 * A);
                x2 = (-B - Math.Sqrt(D)) / (2 * A);
                Console.WriteLine("Существуют 2 корня и они равны - " + x1 + ", " + x2);
            }

        }

        static double ReadDouble(string message)
        {
            string resultString;
            double resultDouble;
            bool flag;
            do
            {
                Console.Write(message);
                resultString = Console.ReadLine();
                //Первый способ преобразования строки в число
                flag = double.TryParse(resultString, out resultDouble);
               
            if (!flag)
                {
                    Console.WriteLine("Необходимо ввести вещественное число");
                }
            }
            while (!flag);
            return resultDouble;
        }
    }
}
