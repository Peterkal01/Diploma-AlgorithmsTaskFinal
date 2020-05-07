using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AlgorithmsTaskFinal
{
    class Binary
    {
        void sort(List<int> arr)
        {
            int n = arr.Count;
            for (int i = 1; i < n; ++i)
            {
                int key = arr[i];
                int j = i - 1;
                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }
                arr[j + 1] = key;
            }
        }
        static void printArray(List<int> arr)
        {
            foreach (int i in arr)
            {
                Console.Write(i.ToString() + "  ");
            }
        }
        public static void BinarySearch()
        {
            List<int> arr;
            List<int> aList = new List<int>();
            var fileStream = new System.IO.FileStream("C:/Users/peter/Documents/unsorted_numbers.csv", FileMode.Open, FileAccess.Read);
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
            Binary ob = new Binary();
            ob.sort(arr);
            Console.WriteLine("Numbers sorted with Insertion Sort");
            printArray(arr);
            Console.WriteLine(" ");
            Console.WriteLine("Type 1 to begin Binary Search for 575154, 182339, 17132, 773788, 296934, 991395, 303270, 45231, 580, 629822");
            var userdecision = Console.ReadLine();
            if (userdecision == "1")
            {
                int b = arr.BinarySearch(575154);
                Console.WriteLine("575154 is in position " + b + " of the list");
                b = arr.BinarySearch(182339);
                Console.WriteLine("182339 is in position " + b + " of the list");
                b = arr.BinarySearch(17132);
                Console.WriteLine("17132 is in position " + b + " of the list");
                b = arr.BinarySearch(773788);
                Console.WriteLine("773788 is in position " + b + " of the list");
                b = arr.BinarySearch(296934);
                Console.WriteLine("296934 is in position " + b + " of the list");
                b = arr.BinarySearch(991395);
                Console.WriteLine("991395 is in position " + b + " of the list");
                b = arr.BinarySearch(303270);
                Console.WriteLine("303270 is in position " + b + " of the list");
                b = arr.BinarySearch(45231);
                Console.WriteLine("45231 is in position " + b + " of the list");
                b = arr.BinarySearch(580);
                Console.WriteLine("580 is in position " + b + " of the list");
                b = arr.BinarySearch(629822);
                Console.WriteLine("629822 is in position " + b + " of the list");
            }

            Console.ReadKey();
        }
    }
}