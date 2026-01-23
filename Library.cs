using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Managment_System
{
    internal class Library
    {
        private Book[] _book;
        private int _bookcount;
    //    private Member[] _member;
        private int _membercount;
        public Library()
        {
            _book = new Book[50];
            _member = new Member[50];
            _bookcount = 0;
            _membercount = 0;
        }
        public void AddBook(Book book)
        {
            for (int i = 0; i < _bookcount; i++)
            {
                if (_book[i].Id == book.Id)
                {
                    Console.WriteLine($"Book With ID {_book[i].Id} already Exists!");
                    return;
                }
            }
        _book[_bookcount] = book;
        _bookcount++;
        Console.WriteLine($"Book '{book.Title}' added successfully.");
        }
        public void RemoveBook(int id)
        {
            int index = -1;
            for (int i = 0; i < _bookcount; i++)
            {
                if (_book[i].Id == id)
                {
                    index = i;
                }
                else
                {
                    index = -1;
                }
            }
            if (index == -1)
            {
                Console.WriteLine("Book not found.");
                return;
            }
            for (int i = index; i < _bookcount - 1; i++)
            {
                _book[i] = _book[i + 1];
            }
            _bookcount--;
            Console.WriteLine("Book removed successfully.");
        }
        public void ListBooks()
        {
            if (_bookcount == 0)
            {
                Console.WriteLine("No books in library.");
                return;
            }
            for (int i = 0; i < _bookcount; i++)
            {
                Console.WriteLine($"ID: {_book[i].Id}, Title: {_book[i].Title}, Author: {_book[i].Author}, Available: {_book[i].IsAvailable}");
            }
        }

        public void AddMember(int id, string name)
        {
            _member[_membercount] = new Member(id, name);
            _membercount++;
            Console.WriteLine($"Member '{name}' added successfully.");
        }

        private int FindMemberIndex(int id)
        {
            for (int i = 0; i < _membercount; i++)
                if (_member[i].Id == id)
                    return i;

            return -1;
        }

        public void RemoveMember(int id)
        {
            int index = FindMemberIndex(id);
            if (index == -1)
            {
                Console.WriteLine("Member not found.");
                return;
            }

            for (int i = index; i < _membercount - 1; i++)
            {
                _member[i] = _member[i + 1];
            }

            _membercount--;
            Console.WriteLine("Member removed successfully.");
        }

        public void ListMember()
        {
            foreach (Member M in _member)
            {
                if (M != null)
                {
                Console.WriteLine($"Member ID {M.Id} : {M.Name} and has {M.BorrowedCount} Books");
                }
            }
        }

        public void BorrowBook(int bookid, int memberId)
        {
            Book book = FindBook(bookid);
            Member member = FindMember(memberId);
            if (member == null || book == null)
            {
                Console.WriteLine("Book or Member not found.");
                return;
            }
            if (!book.IsAvailable)
            {
                Console.WriteLine("Book is not available.");
                return;
            }
            member.BorrowedBooks[member.BorrowedCount] = book;
            member.BorrowedCount++;

            book.IsAvailable = false;
            Console.WriteLine($"{member.Name} borrowed '{book.Title}'.");
        }
        public void ReturnBook(int bookid, int memberId)
        {
            Member member = FindMember(memberId);
            if (member == null)
            {
                Console.WriteLine("Member not found.");
                return;
            }
            int index = -1;
            for (int i = 0; i < member.BorrowedCount; i++)
            {
                if (member.BorrowedBooks[i].Id == bookid)
                {
                    index = i;
                    break;
                }
            }
            if (index == -1)
            {
                Console.WriteLine("This member didn't borrow this book.");
                return;
            }
            Book book = member.BorrowedBooks[index];
            book.IsAvailable = true;

            for (int i = index; i < member.BorrowedCount - 1; i++)
            {
                member.BorrowedBooks[i] = member.BorrowedBooks[i + 1];
            }

            member.BorrowedCount--;
            Console.WriteLine($"{member.Name} returned '{book.Title}'.");
        }

        private Book FindBook(int id)
        {
            for (int i = 0; i < _bookcount; i++)
                if (_book[i].Id == id)
                    return _book[i];

            return null;
        }

        private Member FindMember(int id)
        {
            for (int i = 0; i < _membercount; i++)
                if (_member[i].Id == id)
                    return _member[i];

            return null;
        }



    }
}
