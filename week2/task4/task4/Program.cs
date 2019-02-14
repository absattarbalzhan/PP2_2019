using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace task4
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = "POP.txt"; // имя файла который я хочу создать
            string PathString = @"C:\Users\Айгуль\Desktop\pp2\week2"; // и где я его хочу создать
            PathString = Path.Combine(PathString, fileName); // нужно скомбинировать их пути
            FileStream fs = File.Create(PathString); // и создаем файл
            fs.Close(); // нужно чтобы прекратил работу

            string PathString2 = @"C:\Users\Айгуль\Desktop\pp2\week2\task4"; // путь куда я должен  скопировать

            string destFile = System.IO.Path.Combine(PathString2, fileName); // скомбинируем путь
            File.Copy(PathString, destFile, true); // копируем туда

            File.Delete(PathString); // и удаляем оригинал
           }
           
    }
}