using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Linear_Search
{
    class Linear
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

        public static void LinearSearch()
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

            Linear ob = new Linear();
            ob.sort(arr);

            Console.WriteLine("Type 1 to being Linear Search for 575154, 182339, 17132, 773788, 296934, 991395, 303270, 45231, 580, 629822?");
            var userdecision = Console.ReadLine();
            if (userdecision == "1")
            {
                int n = 575154;
                int l = arr.IndexOf(n);
                Console.WriteLine("\n575154 is in position " + l + " of the list");

                n = 182339;
                l = arr.IndexOf(n);
                Console.WriteLine("182339 is in position " + l + " of the list");

                n = 17132;
                l = arr.IndexOf(n);
                Console.WriteLine("17132 is in position " + l + " of the list");

                n = 773788;
                l = arr.IndexOf(n);
                Console.WriteLine("773788 is in position " + l + " of the list");

                n = 296934;
                l = arr.IndexOf(n);
                Console.WriteLine("296934 is in position " + l + " of the list");

                n = 991395;
                l = arr.IndexOf(n);
                Console.WriteLine("991395 is in position " + l + " of the list");

                n = 303270;
                l = arr.IndexOf(n);
                Console.WriteLine("303270 is in position " + l + " of the list");

                n = 45231;
                l = arr.IndexOf(n);
                Console.WriteLine("45231 is in position " + l + " of the list");

                n = 580;
                l = arr.IndexOf(n);
                Console.WriteLine("580 is in position " + l + " of the list");

                n = 629822;
                l = arr.IndexOf(n);
                Console.WriteLine("629822 is in position " + l + " of the list");
            }

            Console.ReadKey();
        }
    }
}