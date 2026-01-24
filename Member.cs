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
        private int _id;
        private string _name;
        private Book[] _borrowedBooks;
        private int _borrowedCount;


            public int Id
            {
                get { return _id; }
                set { _id = value; }
            }

     
            public string Name
            {
                get { return _name; }
                set { _name = value; }
            }

            public int BorrowedCount
            {
                get { return _borrowedCount; }
            }

            public Book[] BorrowedBooks
            {
                get { return _borrowedBooks; }
            }
            public Member(int id, string name, int maxBooks)
        {
            _id = id;
            _name = name;
            _borrowedBooks = new Book[maxBooks];
            _borrowedCount = 0;
        }


        public bool BorrowBook(Book book)
        {
            if (_borrowedCount >= _borrowedBooks.Length)
            {
                Console.WriteLine("You passed the limit of books");
                return false;
            }

            _borrowedBooks[_borrowedCount++] = book;
            Console.WriteLine("Book borrowed successfully");
            return true;
        }

        public bool ReturnBook(Book book)
        {
            for (int i = 0; i < _borrowedCount; i++)
            {
                if (_borrowedBooks[i].GetID() == book.GetID())
                {
                    for (int j = i; j < _borrowedCount - 1; j++)
                    {
                        _borrowedBooks[j] = _borrowedBooks[j + 1];
                    }

                    _borrowedBooks[_borrowedCount - 1] = null;
                    _borrowedCount--;

                    Console.WriteLine("Book returned successfully");
                    return true;
                }
            }

            Console.WriteLine("This book not found");
            return false;
        }

        public override string ToString()
        {
            string info = $"Member ID: {_id}, Name: {_name}\nBorrowed Books:\n ";

            if (_borrowedCount == 0)
            {
                info += "No borrowed books yet";
            }
            else
            {
                for (int i = 0; i < _borrowedCount; i++)
                {
                    info += $"- {_borrowedBooks[i].GetTitle()}, {_borrowedBooks[i].GetID()}\n";
                }
            }

            return info;
        }
    }
}