using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Xml.Linq;
using Danila_8.Class;

namespace Danila_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Phone phone = new Phone();
            Console.WriteLine("Введите номер:");
            phone.Number = Console.ReadLine();
            Console.WriteLine("Введите модель:");
            phone.Model = Console.ReadLine();
            Console.WriteLine("Введите вес:");
            phone.Weight = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine("Номер: " + phone.Number);
            Console.WriteLine("Модель: " + phone.Model);
            Console.WriteLine("Вес: " + phone.Weight);
            Console.WriteLine();

            phone.recieveCall();
            phone.getNumber();

            Console.WriteLine();

            Phone phonee = new Phone("2", "2");
            Console.WriteLine("Вызов из конструктора с двумя праметрами конструктор с двумя");
            Console.WriteLine(phonee.Number);
            Console.WriteLine(phonee.Model);

            Console.WriteLine();

            phone.receiveCall("","");

            Console.WriteLine();

            phone.sendMessage();

            Console.WriteLine();

            Reader reader = new Reader();

            Reader[] readerr = new Reader[6];
            for (int i = 0; i < 6; i++)
            {
                readerr[i] = new Reader();
            }
            readerr[0].FIO = "Danila";
            readerr[0].Nomer_bileta = "13";
            readerr[0].Facyltet = "3";
            readerr[0].Data_rochdenia = "31.01.2004";
            readerr[0].Telefon = "8 (777) 777-77-77";
            Console.WriteLine(readerr[0].ToString());

            Console.WriteLine();

            reader.takeBook("Danila", "13", "3", "31.01.2004", "8 (777) 777-77-77");
            reader.returnBook("Danila", "13", "3", "31.01.2004", "8 (777) 777-77-77");

            Console.WriteLine();

            reader.takeBook("Петров В.В.", "3 книги");

            Console.WriteLine();

            reader.takeBook("Петров В.В.", "Приключения,", "Словарь,", "Энциклопедия.");

            Console.WriteLine();

            reader.takeBook("Петров В.В.");

            Console.WriteLine();

            reader.returnBook("Петров В.В.", "3 книги");

            Console.WriteLine();

            reader.returnBook("Петров В.В.", "Приключения,", "Словарь,", "Энциклопедия.");

            Console.WriteLine();

            reader.returnBook("Петров В.В.");

            Console.ReadKey();
        }
    }
}
