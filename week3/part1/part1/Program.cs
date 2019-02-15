using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab3
{
    class FarManager // новый класс
    {
        int cursor; // курсор нужен что бы видеть где я нахожусь
        int cnt; // нужен, чтобы считывать сколько файлов или папок в заданной directory
        public FarManager() //пустой конструктор
        {
            cursor = 0; // изначально мы вводим, что курсор должен стоять на самом верху
        }
        public void Show(DirectoryInfo dire, int z) // в этой функции задаем еще значение курсора
        {
            FileSystemInfo[] d = dire.GetFileSystemInfos(); // создала массив, чтобы взять все файлы и папки в заданной directory
            for (int i = 0; i < d.Length; i++) // пробегаемся с циклом 
            {
                if (z == i) // где стоит курсор цвет должен быть иначе
                {
                    Console.ForegroundColor = ConsoleColor.White; //белый с синим
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.WriteLine(i + 1 + ". " + d[i].Name); //потом выводим индекс и имя файла или папки
                }
                else if (d[i].GetType() == typeof(FileInfo)) // если же это файл
                {
                    Console.ForegroundColor = ConsoleColor.Yellow; //желтый и черный
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.WriteLine(i + 1 + ". " + d[i].Name); //выводим индекс и имя файла
                }
                else if (d[i].GetType() == typeof(DirectoryInfo)) // для папки
                {
                    Console.ForegroundColor = ConsoleColor.White; //белый черный
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.WriteLine(i + 1 + ". " + d[i].Name);//индекс и имя папки
                }
            }
        }
        public void Up() 
        {
            cursor--;
            if (cursor < 0) // если мы на самом вверху, то он передвигает нас на нижнию строку
            {
                cursor = cnt - 1;
            }
        }
        public void Down() 
        {
            cursor++;
            if (cursor == cnt) // если же мы на последнем, то должны переместиться на самый вверх
            {
                cursor = 0;
            }
        }
        public void Start(string path) // функция Start
        {
            ConsoleKeyInfo button = Console.ReadKey(); // каждый раз когда мы жмем кнопку он записывает ее в button
            while (button.Key != ConsoleKey.Escape) // если же мы нажали кнопку escape то программа должна завершиться
            {
                DirectoryInfo dir = new DirectoryInfo(path);
                FileSystemInfo[] d = dir.GetFileSystemInfos(); //создаем массив где будем хранить все в заданной папке
                cnt = d.Length; // и считываем сколько же файлов или папок там внутри
                Show(dir, cursor); // задаем функия Show с курсором что бы задать цвет
                button = Console.ReadKey(); // нужна что бы каждый раз мы нажимали иную кнопку
                Console.BackgroundColor = ConsoleColor.Black; //background  я поставилa на черный цвет
                Console.Clear(); // для того что бы мы видели другую картину очищая предыдущую
                if (button.Key == ConsoleKey.UpArrow) // если же мы нажимаем кнопку вверх то вызываем функцию
                {
                    Up();
                }
                if (button.Key == ConsoleKey.DownArrow) //то же самое и с кнопкой вниз
                {
                    Down();
                }
                if (button.Key == ConsoleKey.Enter) // когда жмем Enter, то мы должны зайти в указанную папку
                {
                    path = d[cursor].FullName;
                    cursor = 0;
                }
                if (button.Key == ConsoleKey.Backspace) // а если Backspace то должны выйти с этой папки
                {
                    cursor = 0;
                    dir = dir.Parent;
                    path = dir.FullName;
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            FarManager far = new FarManager(); //задаю класс
            far.Start(@"C:\Users\Айгуль\Desktop\pp2"); // даю путь где он должен начаться и передаю значение в функцию Start
        }
    }
}