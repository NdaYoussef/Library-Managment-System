using System;

namespace Library_Managment_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ReadOnlyString(string message)
            {
                string input;
                do
                {
                    Console.Write(message);
                    input = Console.ReadLine()!;

                    if (string.IsNullOrWhiteSpace(input))
                        Console.WriteLine("Input Can Not be Empty !!!");

                } while (string.IsNullOrWhiteSpace(input));

                return input.Trim();
            }

            int ReadOnlyInt(string message)
            {
                int value;
                string input;

                while (true)
                {
                    Console.Write(message);
                    input = Console.ReadLine()!;

                    if (string.IsNullOrWhiteSpace(input))
                    {
                        Console.WriteLine("Input Can Not be Empty !!!");
                        continue;
                    }

                    if (!int.TryParse(input, out value))
                    {
                        Console.WriteLine("Please enter a valid number !!!");
                        continue;
                    }

                    return value;
                }
            }

            Console.WriteLine("Welcome to Library System!\n");

            Library library = new Library();
            string choice;

            do
            {
                
                Console.WriteLine("1. Add Book");
                Console.WriteLine("2. Remove Book");
                Console.WriteLine("3. Add Member");
                Console.WriteLine("4. Remove Member");
                Console.WriteLine("5. Borrow Book");
                Console.WriteLine("6. Return Book");
                Console.WriteLine("7. List Books");
                Console.WriteLine("8. List Members");
                Console.WriteLine("9. Exit");

                Console.Write("Select option: ");
                choice = Console.ReadLine()!;

                switch (choice)
                {
                    case "1":
                        int bid = ReadOnlyInt("Book ID: ");
                        string title = ReadOnlyString("Title: ");
                        string author = ReadOnlyString("Author: ");
                        library.AddBook(new Book(bid, title, author, true));
                        break;


                    case "2":
                        library.RemoveBook(ReadOnlyInt("Book ID: "));
                        break;

                    case "3":
                        int mid = ReadOnlyInt("Member ID: ");
                        string name = ReadOnlyString("Name: ");
                        int maxBooks = ReadOnlyInt("Max books allowed: ");
                        library.AddMember(new Member(mid, name, maxBooks));
                        break;

                    case "4":
                        library.RemoveMember(ReadOnlyInt("Member ID: "));
                        break;

                    case "5":
                        library.BorrowBook(
                            ReadOnlyInt("Book ID: "),
                            ReadOnlyInt("Member ID: "));
                        break;

                    case "6":
                        library.ReturnBook(
                            ReadOnlyInt("Book ID: "),
                            ReadOnlyInt("Member ID: "));
                        break;

                    case "7":
                        library.ListBooks();
                        break;

                    case "8":
                        library.ListMembers();
                        break;

                    case "9":
                        Console.WriteLine("Goodbye ");
                        break;

                    default:
                        Console.WriteLine("Invalid option.");
                        break;
                }

            } while (choice != "9");
        }


        public static string ReadNonEmptyString(string message)
        {
            string input;
            do
            {
                Console.Write(message);
                input = Console.ReadLine() ?? "";

                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Input cannot be empty, whitespace, or null! Please enter again.");
                }

            } while (string.IsNullOrWhiteSpace(input));

            return input.Trim();
        }

      


    }
}

