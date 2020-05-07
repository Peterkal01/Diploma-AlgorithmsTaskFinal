﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Shell_Sort
{
    class ShellSort
    {
        int sort(List<int> arr)
        {
            int n = arr.Count;
            for (int gap = n / 2; gap > 0; gap /= 2)
            {
                for (int i = gap; i < n; i += 1)
                {
                    int temp = arr[i];
                    int j;
                    for (j = i; j >= gap && arr[j - gap] > temp; j -= gap)
                        arr[j] = arr[j - gap];
                    arr[j] = temp;
                }
            }
            return 0;
        }

        static void printArray(List<int> arr)
        {
            int n = arr.Count;
            for (int i = 0; i < n; ++i)
                Console.Write(arr[i] + " ");

            Console.WriteLine();
        }

        public static void RunShellSort()
        {
            List<int> arr;
            List<int> aList = new List<int>();

            var fileStream = new FileStream("C:/Users/peter/Documents/unsorted_numbers.csv", FileMode.Open, FileAccess.Read);
            using (var streamReader = new StreamReader(fileStream))
            {
                int line;
                while ((line = Convert.ToInt32(streamReader.ReadLine())) != 0)
                {
                    aList.Add(line);
                }
            }

            arr = aList.ToList();
            for (int i = 0; i < arr.Count; i++)
            {
                Console.WriteLine(arr[i]);
            }

            ShellSort ob = new ShellSort();
            ob.sort(arr);

            Console.Write("\nSorted Numbers");
            printArray(arr);

            Console.ReadKey();
        }
    }
}
