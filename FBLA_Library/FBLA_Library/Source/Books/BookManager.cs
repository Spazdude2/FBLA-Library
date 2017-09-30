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
        public static Book getBook(int id)    //Int 5 didget
        {
            String fileText = getText(id);

            if (fileText == "-1")
                return null;

            return new Book(fileText);
        }

        public static Book createBook(int id, String values)
        {
            generate(id, values);

            return getBook(id);

        }

        private static string getText(int name)
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

        private static void generate(int id, String values)
        {

            string path = "./Books/" + id + ".txt";

            if (!File.Exists(path))
            {
                // Create a file to write to.
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine(values);
                }
            }
        }
    }
}
