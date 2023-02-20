using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Danila_8.Class
{
    public class Book
    {
        private string _title = "Мы";

        public string Title1
        {
            get { return _title; }
            set { _title = value; }
        }

        private string _author = "Замятин";

        public string Author1
        {
            get { return _author; }
            set { _author = value; }
        }
    }
}
