using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Managment_System
{
    internal class Member
    {
        public int Id;
        public string Name;

        public Book[] BorrowedBooks;
        public int BorrowedCount;

        public Member(int id, string name)
        {
            Id = id;
            Name = name;

            BorrowedBooks = new Book[5]; // أقصى عدد استعارة
            BorrowedCount = 0;
        }
    }
}
