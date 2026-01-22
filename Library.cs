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
        private Member[] _member;
        private int _membercount;
        public Library()
        {
            _book = new Book[10];
            _count = new Member[10];
            _bookcount = 0;
            _membercount = 0;
        }
        public bool Addbook(Book book)
        {
            if (_book >= 10)
            {
                return false;   
            }
            _book[_bookcount]=book;
            _bookcount++;
            return true;
        }
        private int FindBook(int bookId)
        {
            for (int i = 0; i < _bookcount; i++)
            {
                if( _book[i] == bookId ) 
                    { return i; }
            }
            return -1;
        }
    }
}
