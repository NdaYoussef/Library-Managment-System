    namespace Library_Managment_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
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
                        Console.Write("Book ID: ");
                        int bid = int.Parse(Console.ReadLine());
                        Console.Write("Title: ");
                        string title = Console.ReadLine();
                        Console.Write("Author: ");
                        string author = Console.ReadLine();
                        library.AddBook(new Book(bid,title,author));
                        break;

                    case "2":
                        Console.Write("Book ID: ");
                        library.RemoveBook(int.Parse(Console.ReadLine()));
                        break;

                    case "3":
                        Console.Write("Member ID: ");
                        int mid = int.Parse(Console.ReadLine());
                        Console.Write("Name: ");
                        string name = Console.ReadLine();
                        library.AddMember(mid, name);
                        break;

                    case "4":
                        Console.Write("Member ID: ");
                        library.RemoveMember(int.Parse(Console.ReadLine()));
                        break;

                    case "5":
                        Console.Write("Book ID: ");
                        int b1 = int.Parse(Console.ReadLine());
                        Console.Write("Member ID: ");
                        int m1 = int.Parse(Console.ReadLine());
                        library.BorrowBook(b1, m1);
                        break;

                    case "6":
                        Console.Write("Book ID: ");
                        int b2 = int.Parse(Console.ReadLine());
                        Console.Write("Member ID: ");
                        int m2 = int.Parse(Console.ReadLine());
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
