using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Part2
{
    class Program
    {
        static void Main(string[] args)
        {
            far FarManager = new far();
            FarManager.Start(@"C:\Users\Айгуль\Desktop\pp2");
        }
    }
    class far
    {
        public int cursor;// общедоступные переменные
        public int size;
        public bool ok;
        public far()
        {
            cursor = 0;
            ok = true;
        }
        public void Up()
        {
            cursor--;// двигает курсор вниз
            if (cursor < 0)
                cursor = size - 1;
        }
        public void Down()
        {
            cursor++;// двигает курсор вверх
            if (cursor == size)
                cursor = 0;
        }
        public void Color(FileSystemInfo file, int index)
        {
            if (index == cursor)// если курсор наводит на определенный файл или папку, то цвет заднего фона надписи становится красным
                Console.BackgroundColor = ConsoleColor.Red; 
            else if (file.GetType() == typeof(DirectoryInfo))// если кусор указывает на папку, то она окрашивается в белый цвет
            {
                Console.ForegroundColor = ConsoleColor.White; 
                Console.BackgroundColor = ConsoleColor.DarkBlue;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkMagenta;// иначе это файл и окрашиваем его в фиолетовый цвет
                Console.BackgroundColor = ConsoleColor.Yellow;
            }
        }
        public void Show(string path)
        {
            DirectoryInfo directory = new DirectoryInfo(path);
            FileSystemInfo[] files = directory.GetFileSystemInfos();
            size = files.Length;//  размер равен длине файлов
            int index = 0;
            foreach (FileSystemInfo fs in files)
            {
                Color(fs, index);
                Console.WriteLine(fs.Name);
                index++;
            }
        }
        public void Start(string path)
        {
            ConsoleKeyInfo key = Console.ReadKey();
            FileSystemInfo fs = null;
            while (key.Key != ConsoleKey.E)
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Clear();
                Show(path);
                key = Console.ReadKey();
                if (key.Key == ConsoleKey.UpArrow)
                    Up();
                else if (key.Key == ConsoleKey.DownArrow)
                    Down();

            }
        }
    }
}