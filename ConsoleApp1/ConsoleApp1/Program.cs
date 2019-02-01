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
            string[] arr = Console.ReadLine().Split();
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            { sum += int.Parse(arr[i]); }
            Console.WriteLine(sum);
        }
    }
}
