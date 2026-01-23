using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Managment_System
{
    internal class Book
    {
        private int Id; 
        private string Title;
        private string Author;
        private bool IsAvailable = true;

        public Book(int id , string title , string author,bool availabilty)
        {
            Id = id;
            if (string.IsNullOrEmpty(title))
            {
                Console.WriteLine("The Title can't be empty or null");

            }

            Title = title;


            if (string.IsNullOrEmpty(author))
            {
                Console.WriteLine("The Author can't be empty or null");
              
            }
            Author = author;

            IsAvailable = availabilty;
        }

        public int GetID()
        {
            return Id;
        }
        public string GetTitle()
        {
            return Title;

        }
        public string GetAuthor()
        {
            return Author;
        }
        public bool GetAvailabilty()
        {
            return IsAvailable;
        }

        public override string ToString()
        {
            return $"ID: {Id}\n Title: {Title}\n Author: {Author}\n Availablity:{IsAvailable}";
        }
        public void Borrow()
        {
            if (!IsAvailable)
            {
                Console.WriteLine($"Book: {Title} is already borrowed");
            }
            IsAvailable = false;

            Console.WriteLine("Book borrowed successfully!");
        }
        public void Return()
        {
            IsAvailable = true;
            Console.WriteLine("Book returned successfully");
        }



    }
}
