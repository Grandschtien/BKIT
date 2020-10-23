using System;
using System.Collections.Generic;

namespace lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            rectangle ret = new rectangle("Прямоугольника", 5, 7);
            square sq = new square("Квадрат", 5);
            circle cir = new circle("Круга", 8);


            List<figure> arrayList = new List<figure>();


            arrayList.Add(ret);
            arrayList.Add(sq);
            arrayList.Add(cir);

            for (int i = 0; i < arrayList.Count; i++)
            {
                Console.WriteLine(arrayList[i]);
            }

            Console.WriteLine("--------------------------------------------------------");

            arrayList.Sort();

            for (int i = 0; i < arrayList.Count; i++)
            {
                Console.WriteLine(arrayList[i]);
            }

            Console.WriteLine("--------------------------------------------------------");

            // трехмерный массив
            // : сделать нормальный вывод
            Matrix<figure> matrixXYZ = new Matrix<figure>(3, 3, 3, sq);
            matrixXYZ[0, 0, 0] = new rectangle("Rectangle", 5, 7);
            matrixXYZ[1, 1, 1] = new circle("Circle", 6);
            matrixXYZ[2, 2, 2] = new square("Square", 5);
            matrixXYZ.print();


           Console.WriteLine("-----------------------------------------------");

           SimpleList<figure> list = new SimpleList<figure>();
           list.Add(ret);
           list.Add(cir);

           SimpleStack<figure> stack = new SimpleStack<figure>();
           stack.push(ret);
           stack.push(cir);
           stack.push(sq);

           foreach (var item in stack)
           {
               Console.WriteLine(item);
           }

           stack.pop();
            Console.WriteLine("------------------------------------------------");
           foreach (var item in stack)
           {
               Console.WriteLine(item);
           }
        }
    }
}
