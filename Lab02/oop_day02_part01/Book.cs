using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_day02_part01
{
    internal class Book
    {
        public string Title;
        public string Author;
        public string ISBN;
        public int PublicationYear;
        public bool IsAvailable;





        /*

        public Book(string title, string auther)
        {

            Title = title;
            Author = auther;

        }
          public Book(string title, string auther , string isbn, int pubyear , bool avilable):this(title,auther)
        {
         ISBN =isbn;
          PublicationYear = pubyear;
         IsAvailable=avilable;
        
        
        
        }

         */

        public Book()
        {
            
        }



        public Book(string title, string auther , string isbn, int pubyear , bool avilable)
        {
            if (title == "" || title == null)
            {
                Console.WriteLine("the title can't be emty or null");
            }
            else
            {
                Title = title;
            }
            if (auther == "" || auther == null)
            {
                Console.WriteLine("the auther can't be emty or null");
            }
            else
            {
                Author = auther;
            }
            int n = 0;
            foreach (char c in isbn)
            {
                n++;
            }
            Console.WriteLine(n);

            if (n == 10 || n == 13)
            {
                ISBN = isbn;
            }
            else
            {
                Console.WriteLine("ISBN string follows a basic format of exactly 10 or 13 digits.");
            }
            if (pubyear > 2027)
            {
                Console.WriteLine("this year can't be use");


            }
            else
            {
                PublicationYear = pubyear;
            }
            IsAvailable = avilable;
        }

        public Book(string title, string auther)
        {

            Title = title;
            Author = auther;
            ISBN = "Unknown";
            PublicationYear = 2026;

        }

        public void DisplyInfo()
        {
            Console.WriteLine($"Title:{Title}\n Auther:{Author}\n ISBN:{ISBN}\n PublicationYear:{PublicationYear}\n IsAvailable:{IsAvailable}");
        }

        public void BorrowBook()
        {
            IsAvailable= false;
            Console.WriteLine("succfullyyy");
        }
        public void ReturnBook() {
            IsAvailable= true;
            Console.WriteLine("the book has been returned");
        
        }

    }
}
