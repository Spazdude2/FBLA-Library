using FBLA_Library.Source.Books;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FBLA_Library.Source.Users
{
    class User
    {

        //Raw text data
        private String rawData;

        //Text data
        private Dictionary<String, String> values = new Dictionary<string, string>();

        public User(String data)
        {
            rawData = data;

            String[] lines = rawData.Replace("\n", "|").Split('|');
            
            foreach (String line in lines)
            {
                if (line == "") continue;
                String[] lineData = line.Split(' ');
                
                values.Add(lineData[0].Substring(0, lineData[0].Length-1), lineData[1]);

            }
            
        }

        public String getVariable (String val)
        {
            return values[val];
        }

        public void showRaw()
        {
            Console.WriteLine("What data do you need? (none to end)?");
            
            String s = Console.ReadLine();
            if (s == "none") return;

            if (s == "GetBooks")
            {
                Book b = BookManager.getBook(Convert.ToInt32(values["Book1"]));
                b.showRaw();
            }

            else
                Console.WriteLine(getVariable(s));
            

            showRaw();
        }

    }
}
