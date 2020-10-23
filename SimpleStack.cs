using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab3
{
    /// Элемент списка
    public class SimpleListItem<T>
    {
        public T data { get; set; } /// Данные

        public SimpleListItem<T> next { get; set; } /// Следующий элемент
                                                    
        public SimpleListItem(T param) // конструктор
        {
            this.data = param;
        }
    }
    /// Список
    public class SimpleList<T> : IEnumerable<T>
        where T : IComparable
    {
        /// Первый элемент списка
        protected SimpleListItem<T> first = null;
        /// Последний элемент списка
        protected SimpleListItem<T> last = null;
        /// Количество элементов
        public int Count
        {
            get { return _count; }
            protected set { _count = value; }
        }
        int _count;
    

    virtual public void Add(T element)
    {
        SimpleListItem<T> newItem = new SimpleListItem<T>(element);
        this.Count++;
        //Добавление первого элемента
        if (last == null)
        {
            this.first = newItem;
            this.last = newItem;
        }
        //Добавление следующих элементов
        else
        {
            //Присоединение элемента к цепочке
            this.last.next = newItem;
            //Просоединенный элемент считается последним
            this.last = newItem;
        }
    }
    public SimpleListItem<T> GetItem(int number)
    {
        if ((number < 0) || (number >= this.Count))
        {
        //Можно создать собственный класс исключения
        throw new Exception("Выход за границу индекса");
        }
        SimpleListItem<T> current = this.first; 
        int i = 0;
        //Пропускаем нужное количество элементов
        while (i < number)
        {
            //Переход к следующему элементу
            current = current.next;
            //Увеличение счетчика
            i++;
        }
        return current;
    }
/// <summary>
/// Чтение элемента с заданным номером /// </summary>
public T Get(int number)
{
    return GetItem(number).data;
}
        /// <summary>
        /// Для перебора коллекции
        /// </summary>
        public IEnumerator<T> GetEnumerator()
        {
            SimpleListItem<T> current = this.first;
            //Перебор элементов
            while (current != null)
            {
                //Возврат текущего значения
                yield return current.data;
                //Переход к следующему элементу current = current.next;
                current = current.next;
            }
        }
        //Реализация обощенного IEnumerator<T> требует реализации необобщенного интерфейса
        //Данный метод добавляется автоматически при реализации интерфейса
        System.Collections.IEnumerator
        System.Collections.IEnumerable.GetEnumerator()
            {
                return GetEnumerator();
            }
        /// Cортировка
        public void Sort()
        {
            Sort(0, this.Count - 1);
        }
        
        /// Реализация алгоритма быстрой сортировки 
        private void Sort(int low, int high)
        {
            int i = low;
            int j = high;
            T x = Get((low + high) / 2);
            do
            {
                while (Get(i).CompareTo(x) < 0) ++i; while (Get(j).CompareTo(x) > 0) --j; if (i <= j)
                {
                    Swap(i, j);
                    i++; j--;
                }
            }
            while (i <= j);
            if (low < j) Sort(low, j);
            if (i < high) Sort(i, high);
        }

        /// <summary>
        /// Вспомогательный метод для обмена элементов при сортировке /// </summary>
        private void Swap(int i, int j)
        {
            SimpleListItem<T> ci = GetItem(i);
            SimpleListItem<T> cj = GetItem(j);
            T temp = ci.data;
            ci.data = cj.data;
            cj.data = temp;
        }
    }

    class SimpleStack<T>:SimpleList<figure>, IEnumerable<T>
    {
        SimpleListItem<T> head;
        public SimpleStack():base()
        {

        }
        
        public void push(T element)
        {
            SimpleListItem<T> node = new SimpleListItem<T>(element);
            node.next = head;
            head = node;
            Count++;
        }

        public T pop()
        {
            if(Count == 0) throw new Exception("Стек пустой");
            SimpleListItem<T> temp = head;
            head = head.next;
            Count--;
            return temp.data;
        }
        public IEnumerator<T> GetEnumerator()
        {
            SimpleListItem<T> current = this.head;
            //Перебор элементов
            while (current != null)
            {
                //Возврат текущего значения
                yield return current.data;
                //Переход к следующему элементу current = current.next;
                current = current.next;
            }
        }
        System.Collections.IEnumerator
        System.Collections.IEnumerable.GetEnumerator()
            {
                return GetEnumerator();
            }
    }
}