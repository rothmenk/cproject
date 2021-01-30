﻿using System;
using System.Collections.Generic;
using System.Text;

namespace random
{
    class Sort
    {
            public static void Eq(int[] kaktus)
            {
                int act = 0, min = 10000, b, index = 0;
                int temp = 0;

                //среднее арифметическое
                for (int a = 0; a < kaktus.Length; a++)
                {
                    temp = temp + kaktus[a];
                }
                temp = temp / kaktus.Length;

                //среднее значение в списке
                for (int c = 0; c < kaktus.Length; c++)
                {
                    if (kaktus[c] == temp)
                    {
                        //ставим в конец списка
                        b = kaktus[kaktus.Length - 1];
                        kaktus[kaktus.Length - 1] = kaktus[c];
                        kaktus[c] = b;
                        break;
                    }
                    else
                    {
                        if (min > Math.Abs(kaktus[c] - temp))
                        {
                            min = Math.Abs(kaktus[c] - temp);
                            act = kaktus[c];
                            index = c;

                        }
                    }
                }
                //Console.WriteLine(min+" "+ act+" "+ index) ;
                //ставим 'min' в конец списке
                b = kaktus[kaktus.Length - 1];
                kaktus[kaktus.Length - 1] = kaktus[index];
                kaktus[index] = b;
                // выписать список в консоль
                for (int i = 0; i < kaktus.Length; i++)
                {
                    Console.Write(kaktus[i] + " ");
                }


            }
            // метод для разделения на подсписки
            public static void QuickSort(int[] kaktus)
            {
                int b = -1;
                int temp = 0;
                int pivot = kaktus[kaktus.Length - 1];
                for (int a = 1; a <= kaktus.Length - 2; a++)
                {
                    if (kaktus[a] < pivot)
                    {
                        b++;
                        if (kaktus[b] > kaktus[a])
                        {
                            temp = kaktus[b];
                            kaktus[b] = kaktus[a];
                            kaktus[a] = temp;
                        }
                    }
                }
                temp = pivot;
                pivot = kaktus[b + 1];
                kaktus[b + 1] = temp;

                for (int i = 0; i < kaktus.Length; i++)
                {
                    Console.Write(kaktus[i] + " ");
                }
            }
            public static void Main(string[] args)
            {
                int[] kaktus = { 800, 11, 50, 771, 649, 770, 240, 9 };

                Eq(kaktus);

                QuickSort(kaktus);

                Console.ReadKey();
        }
        }
    }