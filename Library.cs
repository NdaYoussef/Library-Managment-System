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
        //public Library()
        //{
        //    _book = new Book[50];
        //    _count = new Member[50];
        //    _bookcount = 0;
        //    _membercount = 0;
        //}
        //public void AddBook(int id,string title,string athor)
        //{
        //    book[_bookcount]=new Book(id,title,athor);
        //    _bookcount++;
        //    Console.WriteLine($"Book '{title}' added successfully.");
        //}
        //public void RemoveBook(int id)
        //{
        //    int index = FindBookIndex(id);
        //    if(index == -1)
        //    {
        //        Console.WriteLine("Book not found.");
        //        return;
        //    }
        //    for (int i = index; i < booksCount - 1; i++)
        //    {
        //        books[i] = books[i + 1];
        //    }
        //    booksCount--;
        //    Console.WriteLine("Book removed successfully.");
        //}
        //public void ListBooks()
        //{
        //    if(booksCount == 0)
        //    {
        //        Console.WriteLine("No books in library.");
        //        return;
        //    }
        //    for(int i = 0; i < _bookcount; i++)
        //    {
        //        Console.WriteLine(
        //           $"ID: {books[i].Id}, Title: {books[i].Title}, Author: {books[i].Author}, Available: {books[i].IsAvailable}"
        //       );
        //    }

        //}
        //public void BorrowBook(int bookid,int memberId)
        //{
        //    Book book=FindBook(bookid);
        //    Member member = FindMember (memberId);
        //    if(member == null || book == null)
        //    {
        //        Console.WriteLine("Book or Member not found.");
        //        return;
        //    }
        //    if (!book.IsAvailable)
        //    {
        //        Console.WriteLine("Book is not available.");
        //        return;
        //    }
        //    member.BorrowedBooks[member.BorrowedCount] = book;
        //    member.BorrowedCount++;

        //    book.IsAvailable = false;
        //    Console.WriteLine($"{member.Name} borrowed '{book.Title}'.");
        //}
        //public void ReturnBook(int bookid, int memberId)
        //{
        //    Member member=FindMember(memberId);
        //    if(member==null)
        //    {
        //        Console.WriteLine("Member not found.");
        //        return;
        //    }
        //    int index = -1;
        //    for(int i=0; i < member.BorrowedCount; i++)
        //    {
        //        if (member.BorrowedBooks[i] == bookid)
        //        {
        //            index = i; 
        //            break;
        //        }
        //    }
        //    if(index == -1)
        //    {
        //        Console.WriteLine("This member didn't borrow this book.");
        //        return;
        //    }
        //    Book book =member.BorrowedBooks[index];
        //    book.IsAvailable = true;

        //    for (int i = index; i < member.BorrowedCount - 1; i++)
        //    {
        //        member.BorrowedBooks[i] = member.BorrowedBooks[i + 1];
        //    }

        //    member.BorrowedCount--;
        //    Console.WriteLine($"{member.Name} returned '{book.Title}'.");
            
        }
    }

