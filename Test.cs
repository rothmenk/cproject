/*
using System;
using System.Collections;
using System.Collections.Generic;

namespace random
{
    internal class Test
    {
        /// <typeparam name="T"> Тип хранимых данных. </typeparam>
        public class Item<T>
        {
            /// Хранимые данные.
            public T Data { get; set; }
            public Item<T> Next { get; set; }

            /// <param name="data"> Сохраняемые данные. </param> новый экземпляр списка
            public Item(T data)
            {
                // input not null
                if (data == null)
                {
                    throw new ArgumentNullException(nameof(data));
                }

                Data = data;
            }


            /// Приведение объекта к строке.
            /// <returns> Хранимые данные. </returns>
            public override string ToString()
            {
                return Data.ToString();
            }
        }
        
        public class LinkedList<T> : IEnumerable<T>
    {
        /// <summary>
        /// Первый (головной) элемент списка.
        /// </summary>
        private Item<T> _head = null;
        
        /// <summary>
        /// Последний элемент списка. 
        /// </summary>
        private Item<T> _tail = null;
 
        /// <summary>
        /// Количество элементов списка.
        /// </summary>
        private int _count = 0;
 
        /// <summary>
        /// Количество элементов списка getter 
        /// </summary>
        public int Count
        {
            get => _count;
        }
        
        public void Add(T data)
        {
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }
 
            // Создаем новый элемент связного списка.
            var item = new Item<T>(data);
 
            if(_head == null)
            {
                _head = item;  //for first
            }
            else
            {
                _tail.Next = item; //следущий
            }
            
            _tail = item; //поставить в конец
            
            _count++;
        }
 
        //удаляется первое вхождение
        public void Delete(T data)
        {
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }
 
            // Текущий элемент списка
            var current = _head;
 
            // Предыдущий элемент списка, перед current.
            Item<T> previous = null;
 
            //перебор
            while(current != null)
            {
                // Если данные обозреваемого элемента совпадают с удаляемыми данными,
                // то выполняем удаление текущего элемента учитывая его положение в цепочке.
                if(current.Data.Equals(data))
                {
                    // Если элемент находится в середине или в конце списка,
                    // выкидываем текущий элемент из списка.
                    // Иначе это первый элемент списка,
                    // выкидываем первый элемент из списка.
                    if (previous != null)
                    {
                        // Устанавливаем у предыдущего элемента указатель на следующий элемент от текущего.
                        previous.Next = current.Next;
 
                        // Если это был последний элемент списка, 
                        // то изменяем указатель на крайний элемент списка.
                        if(current.Next == null)
                        {
                            _tail = previous;
                        }
                    }
                    else
                    {
                        // Устанавливаем головной элемент следующим.
                        _head = _head.Next;
 
                        // Если список оказался пустым,
                        // то обнуляем и крайний элемент.
                        if(_head == null)
                        {
                            _tail = null;
                        }
                    }
 
                    // Элемент был удален.
                    // Уменьшаем количество элементов и выходим из цикла.
                    // Для того, чтобы удалить все вхождения данных из списка
                    // необходимо не выходить из цикла, а продолжать до его завершения.
                    _count--;
                    break;
                }
 
                // Переходим к следующему элементу списка.
                previous = current;
                current = current.Next;
            }
        }
 
        /// <summary>
        /// Очистить список.
        /// </summary>
        public void Clear()
        {
            _head = null;
            _tail = null;
            _count = 0;
        }
 
        /// <summary>
        /// Вернуть перечислитель, выполняющий перебор всех элементов в связном списке.
        /// </summary>
        /// <returns> Перечислитель, который можно использовать для итерации по коллекции. </returns>
        public IEnumerator<T> GetEnumerator()
        {
            // Перебираем все элементы связного списка, для представления в виде коллекции элементов.
            var current = _head;
            while(current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }
 
        /// <summary>
        /// Вернуть перечислитель, который осуществляет итерационный переход по связному списку.
        /// </summary>
        /// <returns> Объект IEnumerator, который используется для прохода по коллекции. </returns>
        IEnumerator IEnumerable.GetEnumerator()
        {
            // Просто возвращаем перечислитель, определенный выше.
            // Это необходимо для реализации интерфейса IEnumerable
            // чтобы была возможность перебирать элементы связного списка операцией foreach.
            return ((IEnumerable)this).GetEnumerator();
        }
    }
        
        private static void Main(string[] args)
        {
            var lockObj = new object();
            //List<int> mylist = new List<int>() { 2, 1, 5, 4, 3, 12 };
            var mylist = new List<int>() { 2, 1, 5, 4, 3, 12 };

            var spisok = new List<int>();

            mylist.AddRange(new int[] { 7, 8, 9 });

            mylist.Insert(0, 771); 
                
            if (!mylist.Contains(0))
            {
                mylist.Add(0);
            }
                
            var first = mylist[0]; 
            
            foreach (var item in mylist)
            {
                Console.Write(item + " ");
            }

            //Console.WriteLine(mylist.Count);

            mylist.Remove(first);

            mylist.RemoveAt(1);

            mylist.Sort();
            
            foreach (var item in mylist)
            {
                Console.Write(item + " ");
            }
        }
    }
}
*/
