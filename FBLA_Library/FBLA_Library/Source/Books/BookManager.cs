using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FBLA_Library.Source.Books
{
    class BookManager
    {
        public static Book getBook(long id)    //Int 8 didget
        {
            String fileText = getText(id);

            if (fileText == "-1")
            {
                Console.WriteLine("That is not a valid book");
                return null;
            }

            return new Book(fileText);
        }

        private static string getText(long name)
        {
            String vals = "";
            String line;
            try
            {
                //Pass the file path and file name to the StreamReader constructor
                StreamReader sr = new StreamReader("./Books/" + name + ".txt");

                //Read the first line of text
                line = sr.ReadLine();

                //Continue to read until you reach end of file
                while (line != null)
                {
                    //write the lie to console window
                    vals += line + "\n";
                    //Read the next line
                    line = sr.ReadLine();
                }

                //close the file
                sr.Close();
            }
            catch (Exception e)
            {
                return "-1";
            }

            return vals;
        }
    }
}
