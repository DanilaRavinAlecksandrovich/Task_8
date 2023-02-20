using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Danila_8.Class
{
    class Reader
    {
        private string fio;

        public string FIO
        {
            get { return fio; }
            set { fio = value; }
        }

        private string nomer_bileta;

        public string Nomer_bileta
        {
            get { return nomer_bileta; }
            set { nomer_bileta = value; }
        }

        private string facyltet;

        public string Facyltet
        {
            get { return facyltet; }
            set { facyltet = value; }
        }

        private string data_rochdenia;

        public string Data_rochdenia
        {
            get { return data_rochdenia; }
            set { data_rochdenia = value; }
        }

        private string telefon;

        public string Telefon
        {
            get { return telefon; }
            set { telefon = value; }
        }

        private string col_knig;

        public string Col_knig
        {
            get { return col_knig; }
            set { col_knig = value; }
        }

        private string naz_knig_1;

        public string Naz_knig_1
        {
            get { return naz_knig_1; }
            set { naz_knig_1 = value; }
        }

        private string naz_knig_2;

        public string Naz_knig_2
        {
            get { return naz_knig_2; }
            set { naz_knig_2 = value; }
        }

        private string naz_knig_3;

        public string Naz_knig_3
        {
            get { return naz_knig_3; }
            set { naz_knig_3 = value; }
        }

        public void takeBook(string FIO, string Nomer_bileta, string Facyltet, string Data_rochdenia, string Telefon)
        {
            this.fio = FIO;
            this.nomer_bileta = Nomer_bileta;
            this.facyltet = Facyltet;
            this.data_rochdenia = Data_rochdenia;
            this.telefon = Telefon;
        }

        public void returnBook(string FIO, string Nomer_bileta, string Facyltet, string Data_rochdenia, string Telefon)
        {
            Console.WriteLine($"FIO: {fio}\nNomer_bileta: {nomer_bileta}\nFacyltet: {facyltet}\nData_rochdenia: {data_rochdenia}\nTelefon: {telefon}\n");
        }

        public Reader()
        {
            this.fio = FIO;
            this.nomer_bileta = Nomer_bileta;
            this.facyltet= Facyltet;
            this.data_rochdenia = Data_rochdenia;
            this.telefon = Telefon;

        }
        public override string ToString()
        {
            return $"FIO: {fio}\nNomer_bileta: {nomer_bileta}\nFacyltet: {facyltet}\nData_rochdenia: {data_rochdenia}\nTelefon: {telefon}\n";
        }

        public void takeBook(string FIO, string Col_knig)
        {
            this.fio = FIO;
            this.col_knig = Col_knig;
            Console.WriteLine($"{FIO} взял {Col_knig}");
        }

        public void takeBook(string FIO, string Naz_knig_1, string Naz_knig_2, string Naz_knig_3)
        {
            this.fio = FIO;
            this.naz_knig_1 = Naz_knig_1;
            this.naz_knig_2 = Naz_knig_2;
            this.naz_knig_3 = Naz_knig_3;
            Console.WriteLine($"{FIO} взял книги: {Naz_knig_1} {Naz_knig_2} {Naz_knig_3}");
        }

        Book book = new Book();

        public void takeBook(string FIO)
        {
            this.fio = FIO;
            Console.WriteLine($"{FIO} взял книгу - {book.Title1} - {book.Author1}");
        }

        public void returnBook(string FIO, string Col_knig)
        {
            this.fio = FIO;
            this.col_knig = Col_knig;
            Console.WriteLine($"{FIO} вернул {Col_knig}");
        }

        public void returnBook(string FIO, string Naz_knig_1, string Naz_knig_2, string Naz_knig_3)
        {
            this.fio = FIO;
            this.naz_knig_1 = Naz_knig_1;
            this.naz_knig_2 = Naz_knig_2;
            this.naz_knig_3 = Naz_knig_3;
            Console.WriteLine($"{FIO} вернул книги: {Naz_knig_1} {Naz_knig_2} {Naz_knig_3}");
        }

        public void returnBook(string FIO)
        {
            this.fio = FIO;
            Console.WriteLine($"{FIO} вернул книгу - {book.Title1} - {book.Author1}");
        }



    }
}
