using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Mail;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;

namespace Danila_8.Class
{
    class Phone
    {
        private string  number;

        public string Number
        {
            get { return number; }
            set { number = value; }
        }

        private string model;

        public string Model
	    {
		    get { return model;}
		    set { model = value;}
	    }

        private string weight;

        public string Weight
	    {
		    get { return weight;}
		    set { weight = value;}
	    }
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public void recieveCall()
        {
            Console.WriteLine("Введите номер телефона: ");
            Name = Console.ReadLine();
            Console.WriteLine("Введите номер:");
            Number = Console.ReadLine();
            Console.WriteLine("Введите модель:");
            Model = Console.ReadLine();
            Console.WriteLine("Введите вес:");
            Weight = Console.ReadLine();
        }

        public void getNumber()
        {
            Console.WriteLine();
            Console.WriteLine("Звонит: " + Name);
            Console.WriteLine("Номер: " + Number);
            Console.WriteLine("Модель: " + Model);
            Console.WriteLine("Вес: " + Weight);
        }


        public Phone(string number, string model, string weight) : this(number, model)
        {
            this.Weight = weight;
        }
        public Phone(string number, string model)
        {
            this.Number = number;
            this.Model = model;
        }
        public Phone()
        {
            
        }

        public void receiveCall(string Name, string Number)
        {
            Console.WriteLine("Введите номер телефона: ");
            Name = Console.ReadLine();
            Console.WriteLine("Введите номер:");
            Number = Console.ReadLine();
        }

        public void sendMessage(params string[] ii)
        {
            Console.WriteLine("Введите сколько будет номеров: ");
            int size = int.Parse(Console.ReadLine());

            ii = new string[size];

            if (size == 0)
            {
                Console.WriteLine("Ошибка: нет номеров.");
            }
            
            else
            {
                for (int i = 0; i < ii.Length; i++)
                {
                    Console.WriteLine($"Введите номер:");
                    ii[i] = Console.ReadLine();
                }

                Console.WriteLine("Вывод номеров телефонов: ");

                for (int i = 0; i < ii.Length; i++) 
                {
                    Console.WriteLine(ii[i]);
                }
                
            }
        }




    }
}
