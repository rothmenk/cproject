using System;

namespace random
{
    class Notebook
    {
        static int partition(int[] listOfElements, int start, int end)
        {
            int pivot = listOfElements[end];

            int i = (start - 1);
            for (int j = start; j < end; j++)
            {
                if (listOfElements[j] < pivot)
                {
                    i++;

                    int temp = listOfElements[i];
                    listOfElements[i] = listOfElements[j];
                    listOfElements[j] = temp;
                }
            }

            int temp2 = listOfElements[i + 1];
            listOfElements[i + 1] = listOfElements[end];
            listOfElements[end] = temp2;

            return i + 1;
        }

        //start --> Starting index, 
        //end --> Ending index 
        static void quickSort(int[] listOfElements, int start, int end)
        {
            if (start < end)
            {
                // установили в нужное место
                int pivot = partition(listOfElements, start, end);

                /*Recursively sort elements before partition and after partition */
                quickSort(listOfElements, start, pivot - 1);
                quickSort(listOfElements, pivot + 1, end);
            }
        }
        static void printArray(int[] listOfElements, int len)
        {
            for (int i = 0; i < len; ++i)
                Console.Write(listOfElements[i] + " ");
        }

        public static void Main()
        {
            int[] listOfElements = { 800, 11, 50, 771, 649, 770, 240, 9 };
            int len = listOfElements.Length; /*не обязательно */
            quickSort(listOfElements, 0, len - 1);
            Console.WriteLine("Sorted array ");
            printArray(listOfElements, len);
            Console.ReadKey();
        }
    }
}
