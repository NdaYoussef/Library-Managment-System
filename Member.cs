using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Library_Managment_System
{
    internal class Member
    {
        public int id;
        public string name;
        public Book[] BorrowedBooks;
        private int borrowedCount;



        public Member (int id,string name,int maxBooks)
        {
            add
            this.id = id;
            this.name = name;
            BorrowedBooks = new Book[maxBooks];
            borrowedCount = 0;
        }


        public void BorrowBook(Book book)
        {
            if (borrowedCount < BorrowedBooks.Length)
            {
                BorrowedBooks[borrowedCount] = book;
                borrowedCount++;

                Console.WriteLine("book addded successfully");
            }


            Console.WriteLine("you passed limit book");
        }

        public bool ReturnBook(Book book)
        {
            for (int i = 0; i < borrowedCount; i++)
            {
                if (BorrowedBooks[i] == book)
                {
                    for (int j = i; j < borrowedCount - 1; j++)
                    {
                        BorrowedBooks[j] = BorrowedBooks[j + 1];
                    }

                    BorrowedBooks[borrowedCount - 1] = null;
                    borrowedCount--;
                    Console.WriteLine("book return successfully");
                }
            }

            Console.WriteLine("this book not found");
        }


        public override string ToString()
        {
           
            string info = $"Member ID: {id}, Name: {name}\nBorrowed Books:\n";

            if (borrowedCount == 0)
            {
                info += "no borrowed book yet";
            }
            else
            {
                for (int i = 0; i < borrowedCount; i++)
                {
                    info += $"- {BorrowedBooks[i].Title}\n";
                }
            }

            return info;
        }
    }
}
