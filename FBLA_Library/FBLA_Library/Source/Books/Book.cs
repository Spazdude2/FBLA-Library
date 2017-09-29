using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FBLA_Library.Source.Books
{
    class Book
    {
        private String rawData;

        public Book(String data)
        {
            rawData = data;

        }

        public void showRaw()
        {
            Console.WriteLine(rawData);
        }
    }
}
