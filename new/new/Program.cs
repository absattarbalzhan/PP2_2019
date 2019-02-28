using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace @new
{
    class Program

    {
        public static void  Ex(int a, int b, int c)
        {
            int k = 0;
            k = a + b + c;
        }

 public static string Ex2(string s)
        {
StreamReader sr = new StreamReader("input.txt");
        string s = sr.ReadtoEnd();
        sr.Close();
         return s;
}
        class triangle
        {

            static void Main(string[] args)
            {
                string s = Console.ReadLine();
                string[] arr = s.Split();
                StreamWriter sw = new StreamWriter("Output.txt");
                for (int i = 0; i < arr.Length; i++)
                {
                    Ex2(int.Parse(k));
                    Console.WriteLine(k);
                }
            }
        }






