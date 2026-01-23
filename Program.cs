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
                    input = Console.ReadLine();

                    if (string.IsNullOrWhiteSpace(input))
                        Console.WriteLine("Input CanNot be Empty !!!");

                } while (string.IsNullOrWhiteSpace(input));

                return input;
            }

            int ReadOnlyInt(string message)
            {
                int value;
                string input;

                do
                {
                    Console.Write(message);
                    input = Console.ReadLine();

                    if (string.IsNullOrWhiteSpace(input))
                    {
                        Console.WriteLine("Input CanNot be Empty !!!");
                        continue;
                    }

                    if (!int.TryParse(input, out value))
                    {
                        Console.WriteLine("Please enter a valid Number !!!");
                        continue;
                    }

                    return value;

                } while (true);
            }
            Console.WriteLine("Welcome to Library system!");

            Library library = new Library();
            string choice;

            do
            {
                Console.WriteLine("\nLibrary Management System");
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
                
                choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        int bid = ReadOnlyInt("Book ID: ");
                        string title = ReadOnlyString("Title: ");
                        string author = ReadOnlyString("Author: ");
                        library.AddBook(new Book(bid,title,author));
                        break;

                    case "2":
                        library.RemoveBook(ReadOnlyInt("Book ID: "));
                        break;

                    case "3":
                        int mid = ReadOnlyInt("Member ID: ");
                        string name = ReadOnlyString("Name: ");
                        library.AddMember(new Member(mid,name));
                        break;

                    case "4":
                        library.RemoveMember(ReadOnlyInt("Member ID: "));
                        break;

                    case "5":
                        int b1 = ReadOnlyInt("Book ID: ");
                        int m1 = ReadOnlyInt("Member ID: ");
                        library.BorrowBook(b1, m1);
                        break;

                    case "6":
                        int b2 = ReadOnlyInt("Book ID: ");
                        int m2 = ReadOnlyInt("Member ID: ");
                        library.ReturnBook(b2, m2);
                        break;

                    case "7":
                        library.ListBooks();
                        break;

                    case "8":
                        library.ListMember();
                        break;

                    case "9":
                        Console.WriteLine("Exit");
                        break;

                    default:
                        Console.WriteLine("Invalid option.");
                        break;
                }

            } while (choice != "9" || choice == null);
        }

    }
}
