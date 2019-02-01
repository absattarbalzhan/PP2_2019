using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Student
    {
        string name; // создаем строку под названием name
        string id; // создаем другую строку под названием id
        int Year = 1; // создаем переменную integer year равный одному

        public Student(string name, string id) //  создаем конструктор с двумя параметрами name  и id
        {
            this.name = name; //
            this.id = id;     //
        }
        public void NewYear() // создаем конструктор без параметров
        {
            while (Year <= 4)
            {
                Console.WriteLine(name + " " + id + " " + Year);
                Year++;
            } // пока год обучения меньше или равен 4, то выводим имя,id и год обучения. И после каждого вывода увеличиваем год на 1
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("BALZHAN ABSATTAR", "18BD1234567"); // создаем нового студента и задаем начальные данные
            s1.NewYear();  // здесь вызываем функцию, которая выводит данные
        }
    }
}