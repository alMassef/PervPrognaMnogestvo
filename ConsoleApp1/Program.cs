using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var set1 = new GoodSet<int>(new int[] { 1, 2, 3, 4, 5 });
            var set2 = new GoodSet<int>(new int[] { 4, 5, 6, 7, 8 });
            var i = 9;

            Console.Write("Union: ");
            foreach (var item in set1.Union(set2))
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            Console.Write("Intersection: ");
            foreach (var item in set1.Intersection(set2))
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            Console.Write("Difference A \\ B: ");
            foreach (var item in set1.Difference(set2))
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            Console.Write("Difference B \\ A: ");
            foreach (var item in set2.Difference(set1))
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            Console.Write("Add: ");
            set1.Add(i);
            Console.Write(set1);
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
