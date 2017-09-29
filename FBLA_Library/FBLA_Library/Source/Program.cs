using FBLA_Library.Source.Books;
using FBLA_Library.Source.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FBLA_Library.Source
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("What user would you like to view?");
                int id = Convert.ToInt32(Console.ReadLine());

                User s = UserManager.getUser(id);

                if (s != null)
                {
                    s.showRaw();
                }
                else
                {
                    Console.WriteLine("That user doesnt exist, creating one now");
                    Console.WriteLine("What is their data?");
                    String val = Console.ReadLine();
                    UserManager.createUser(id, val);

                    Console.WriteLine("User created!");
                }
            }
        }
    }
}
