using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Library_Managment_System
{
    internal class Library
    {
        private Book[] _books;
        private int _bookCount;
        private Member[] _member;
        private int _memberCount ;
        public Library()
        {
            _books = new Book[50];
            _member = new Member[50];
            _bookCount = 0;
            _memberCount = 0;

        }

        // ================== BOOKS ==================
        public void AddBook(Book book)
        {
           if(FindBook(book.GetID()) != null)
            {
                Console.WriteLine($"Book with ID {book.GetID()} already exists.");
                return;
            }

            _books[_bookCount++] = book;
            Console.WriteLine($"Book '{book.GetTitle()}' added successfully.");
        }


        public void RemoveBook(int id)
        {
            int index = FindBookIndex(id);

            if (index == -1)
            {
                Console.WriteLine("Book not found.");
                return;
            }

            if (!_books[index].GetAvailabilty())
            {
                Console.WriteLine("Book is currently borrowed and can't be removed.");
                return;
            }

            for (int i = index; i < _bookCount - 1; i++)
                _books[i] = _books[i + 1];

            _books[--_bookCount] = null;
            Console.WriteLine("Book removed successfully.");
        }

        public void ListBooks()
        {
            if (_bookCount == 0)
            {
                Console.WriteLine("No books in library.");
                return;
            }

            for (int i = 0; i < _bookCount; i++)
                Console.WriteLine(_books[i]);
        }
        // ================== MEMBERS ==================

        public void AddMember(Member member)
        {
            for (int i = 0; i < _memberCount; i++)
            {
                if (_member[i].Id == member.Id )
                {
                    Console.WriteLine($"Member With ID {_member[i].Id} already Exists!");
                    return;
                }
            }

            _member[_memberCount++] = member;
            Console.WriteLine($"Member '{member.Name}' added successfully.");
        }

        public void RemoveMember(int id)
        {
            int index = FindMemberIndex(id);

            if (index == -1)
            {
                Console.WriteLine("Member not found.");
                return;
            }

            if (_member[index].BorrowedCount > 0)
            {
                Console.WriteLine($"Member {_member[index].Name} has {_member[index].BorrowedCount} borrowed books and Can't be Removed !!!");
                return;
            }

            for (int i = index; i < _memberCount - 1; i++)
                _member[i] = _member[i + 1];

            _member[--_memberCount] = null;
            Console.WriteLine("Member removed successfully.");
        }

        public void ListMembers()
        {
            for (int i = 0; i < _memberCount; i++)
                Console.WriteLine(_member[i]);
        }


        // ================== BORROW / RETURN ==================

        public void BorrowBook(int bookId, int memberId)
        {
            Book book = FindBook(bookId);
            Member member = FindMember(memberId);

            if (book == null || member == null)
            {
                Console.WriteLine("Book or Member not found.");
                return;
            }

            if (!book.GetAvailabilty())
            {
                Console.WriteLine("Book is not available.");
                return;
            }

          if(member.BorrowBook(book))
            {
                book.Borrow();
            }
        }

        public void ReturnBook(int bookId, int memberId)
        {
            Member member = FindMember(memberId);

            if (member == null)
            {
                Console.WriteLine("Member not found.");
                return;
            }

            Book book = FindBook(bookId);

            if (book == null)
            {
                Console.WriteLine("Book not found.");
                return;
            }

            bool returned = member.ReturnBook(book);

            if (!returned)
            {
                Console.WriteLine("This member didn't borrow this book.");
                return;
            }

            book.Return();
            Console.WriteLine($"{member.Name} returned '{book.GetTitle()}'.");
        }

        // ================== HELPERS ==================
        private Book FindBook(int id)
        {
            for (int i = 0; i < _bookCount; i++)
                if (_books[i].GetID() == id)
                    return _books[i];

            return null! ;
        }


        private int FindBookIndex(int id)
        {
            for (int i = 0; i < _bookCount; i++)
                if (_books[i].GetID() == id)
                    return i;

            return -1;
        }

        private Member FindMember(int id)
        {
            for (int i = 0; i < _memberCount; i++)
                if (_member[i].Id == id)
                    return _member[i];

            return null!;
        }

        private int FindMemberIndex(int id)
        {
            for (int i = 0; i < _memberCount; i++)
                if (_member[i].Id == id)
                    return i;

            return -1;
        }

    }
}