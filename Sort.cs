using System;
using System.Collections.Generic;
using System.Text;

namespace random
{
    class Sort
    {
        public static void Eq(int[] listOfElements)
        {
            int act = 0, min = 10000, b, index = 0;
            int temp = 0;

            for (int a = 0; a < listOfElements.Length; a++)
            {
                temp += listOfElements[a];
            }
            temp /= listOfElements.Length;

            //среднее значение в списке
            for (int c = 0; c < listOfElements.Length; c++)
            {
                if (listOfElements[c] == temp)
                {
                    //ставим в конец списка
                    b = listOfElements[^1];
                    listOfElements[^1] = listOfElements[c];
                    listOfElements[c] = b;
                    break;
                }
                else
                {
                    if (min > Math.Abs(listOfElements[c] - temp))
                    {
                        min = Math.Abs(listOfElements[c] - temp);
                        act = listOfElements[c];
                        index = c;

                    }
                }
            }

            //ставим 'min' в конец списке
            b = listOfElements[^1];
            listOfElements[^1] = listOfElements[index];  //kaktus[kaktus.Length - 1] = kaktus[index];
            listOfElements[index] = b;
        }
        // метод для разделения на подсписки
        public static void QuickSort(int[] listOfElements)
        {
            int b = -1;
            int temp = 0;
            var pivot = listOfElements[^1];  

            for (int a = 1; a <= listOfElements.Length - 2; a++)
            {
                if (listOfElements[a] < pivot)
                {
                    b++;
                    if (listOfElements[b] > listOfElements[a])
                    {
                        temp = listOfElements[b];
                        listOfElements[b] = listOfElements[a];
                        listOfElements[a] = temp;
                    }
                }
            }
            temp = pivot;
            pivot = listOfElements[b + 1];
            listOfElements[b + 1] = temp;
            listOfElements[^1] = pivot;
            for (int i = 0; i < listOfElements.Length; i++)
            {
                Console.Write(listOfElements[i] + " ");
            }
        }

        public static void partition(listOfElements[], start, end)
        {
            
            pivot = listOfElements[end];

            i = (start - 1);  

            for (j = start; j <= end - 1; j++)
            {
                if (listOfElements[j] < pivot)
                {
                    i++;    
                    swap arr[i] and arr[j];
                }
            }
            swap listOfElements[i + 1] and arr[end]);
            return (i + 1);
        }

        public static void Main(string[] args)
        {
            int[] listOfElements = { 800, 11, 50, 771, 649, 770, 240, 9 };
            Eq(listOfElements);
            QuickSort(listOfElements);
            Console.ReadKey();
        }
    }
}