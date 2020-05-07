using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsTaskFinal
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Select 1 to view CSV");
            Console.WriteLine("Select 2 for Insertion Sort");
            Console.WriteLine("Select 3 for Shell Sort");
            Console.WriteLine("Select 4 for Binary Search");
            Console.WriteLine("Select 5 for Linear Search");
            var choice = int.Parse(Console.ReadLine());


            if (choice == 1)
            {
                CSV.runCSV();
 
            }


            else if (choice == 2)
            {
                Insertion_Sort.InsertionSort.RunInsertionSort();
                Console.WriteLine();
                Console.WriteLine("Numbers sorted with Insertion Sort");
            }

            else if (choice == 3)
            {
                Shell_Sort.ShellSort.RunShellSort();
                Console.WriteLine();
                Console.WriteLine("Numbers sorted with Shell Sort");
            }

            else if (choice == 4)
            {
                Binary.BinarySearch();
                Console.WriteLine();
                Console.WriteLine("Numbers searched using Binary Search");
            }

            else if (choice == 5)
            {
                Linear_Search.Linear.LinearSearch();
                Console.WriteLine();
                Console.WriteLine("Numbers searched using Linear Search");
            }

            Console.ReadKey();
            
        }
      




    }
}
