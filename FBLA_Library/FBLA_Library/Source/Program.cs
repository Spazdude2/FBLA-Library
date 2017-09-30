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
            Console.WriteLine("Welcome to the School of Spaz's library");
            Console.WriteLine();

            while (true)
            {
                
                Console.WriteLine("Would you like to search for a [User] or a [Book]?");
                Console.Write("> ");
                String response = Console.ReadLine();
                Console.WriteLine();

                if (response.Contains("User"))
                {
                    Console.WriteLine("What user would you like to view? (Enter User ID)");
                    Console.Write("> ");
                    int id = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();

                    User s = UserManager.getUser(id);

                    if (s != null)
                    {
                        s.showRaw();
                    }
                    else
                    {
                        Console.WriteLine("That user doesnt exist, creating one now.");
                        Console.WriteLine("Enter student data. ([Name] | [userType](Student/Teacher) | [Books](number) | (corresponding book number with book ID '[Book1]: 0') | # of[Overdue] books)");
                        Console.Write("> ");
                        String val = Console.ReadLine();
                        Console.WriteLine();
                        UserManager.createUser(id, val);

                        Console.WriteLine("User created!");
                        Console.WriteLine();
                    }
                }

                else if (response.Contains("Book"))
                {
                    Console.WriteLine("What book would you like to view? (Enter Book ID)");
                    Console.Write("> ");
                    int id = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                    Book s = BookManager.getBook(id);

                    if (s != null)
                    {
                        s.showRaw();
                    }
                    else
                    {
                        Console.WriteLine("That Book doesnt exist, creating one now.");
                        Console.WriteLine("Enter book data. (book [Name]/[Author])");
                        Console.Write("> ");
                        String val = Console.ReadLine();
                        Console.WriteLine();
                        BookManager.createBook(id, val);

                        Console.WriteLine("Book created!");
                        Console.WriteLine();
                    }
                }

                else
                {
                    Console.WriteLine("Please type your option as seen in a choice box");
                    Console.WriteLine();
                }
            }
        }
    }
}
