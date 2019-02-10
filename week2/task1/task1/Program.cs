using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace task1
{
    class Program
    {// создаем функцию, которая проверяет строку на палиндром
        public static bool Ex(string s)
        {
            for (int i=0; i<s.Length/2; i++) // до середины
            {
                if (s[i] != s[s.Length -i-1]) // проверяет соответствующие элементы на палиндром
                { return false; }
            }
            return true;
        }
        public static string Ex1 ()
            // создаем фунцию, которая читает строку из файла
        { StreamReader sr = new StreamReader("input.txt"); 
            string s = sr.ReadToEnd();
            sr.Close();
            return s;
        }


        static void Main(string[] args)
        {
            string s = Ex1();
            StreamWriter sw = new StreamWriter("Output.txt"); // выводим ответ в другом файле 
            if (Ex(s)== true)
            {
                sw.WriteLine("YES");
                    
            } else { sw.WriteLine("NO");
            }
            sw.Close(); 
        }
    }
}
