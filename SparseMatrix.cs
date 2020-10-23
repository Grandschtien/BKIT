using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;

namespace lab3
{
    public class Matrix<T>
    {

        Dictionary<string, T> _matrix = new Dictionary<string, T>();    // Словарь для хранения значений

        int maxX;   // Количество элементов по горизонтали (максимальное количество столбцов)
        int maxY;   //Количество элементов по вертикали (максимальное количество строк)
        int maxZ;
        T nullElement;  //Пустой элемент, который возвращается если элемент с нужными координатами не был задан

        public Matrix(int px, int py, T nullElementParam)
        {
            this.maxX = px;
            this.maxY = py;
            this.nullElement = nullElementParam;
        }
        public Matrix(int px, int py, int pz, T nullElementParam)
        {
            this.maxX = px;
            this.maxY = py;
            this.maxZ = pz;
            this.nullElement = nullElementParam;
        }


        public T this[int x, int y] // Индексатор для доступа к данных
        {
            get
            {
                CheckBounds(x, y);
                string key = DictKey(x, y);
                if (this._matrix.ContainsKey(key))
                {
                    return this._matrix[key];
                }
                else
                {
                    return this.nullElement;
                }
            }
            set
            {
                CheckBounds(x, y);
                string key = DictKey(x, y); this._matrix.Add(key, value);
            }
        }

        public T this[int x, int y, int z] // Индексатор для доступа к данных XYZ
        {
            get
            {
                CheckBounds(x, y, z);
                string key = DictKey(x, y, z);
                if (this._matrix.ContainsKey(key))
                {
                    return this._matrix[key];
                }
                else
                {
                    return this.nullElement;
                }
            }
            set
            {
                CheckBounds(x, y, z);
                string key = DictKey(x, y, z); this._matrix.Add(key, value);
            }
        }


        void CheckBounds(int x, int y)  // Проверка границ
        {
            if (x < 0 || x >= this.maxX) throw new Exception("x=" + x + " выходит за границы");
            if (y < 0 || y >= this.maxY) throw new Exception("y=" + y + " выходит за границы");
        }

        void CheckBounds(int x, int y, int z)  // Проверка границ для трех мерной матрицы
        {
            if (x < 0 || x >= this.maxX) throw new Exception("x=" + x + " выходит за границы");
            if (y < 0 || y >= this.maxY) throw new Exception("y=" + y + " выходит за границы");
            if (z < 0 || z >= this.maxZ) throw new Exception("z=" + z + " выходит за границы");
        }

        string DictKey(int x, int y)    // Формирование ключа XY
        {
            return x.ToString() + "_" + y.ToString();
        }

        string DictKey(int x, int y, int z)    // Формирование ключа XYZ
        {
            return x.ToString() + "_" + y.ToString() + "_" + z.ToString();
        }

         public override string ToString()   // Приведение к строке
        {

            StringBuilder b = new StringBuilder();
            
                for (int j = 0; j < maxX; j++)
                {
                    b.Append("[");
                    for (int i = 0; i < maxY; i++)
                    {
                        for (int k = 0; k < maxZ; k++)
                        {
                            if (k > 0) b.Append("\n");

                        b.Append(this[i, j, k].ToString());
                        }
                        b.Append("]\n");
                    }
                }
                
            
            return b.ToString();
        }

        public void print()
        {
            Console.WriteLine(this.ToString());
        }


    }
} 
