using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_day02_part01
{
    internal class Library
    {
        public string Name;
        public Book[] books=new Book[10];
        private int n = 0;

        public Library(string name)
        {
            Name = name;
            
        }
        public void AddBook(Book book)
        {

            if (n < 10) {
             books[n] = book;
            n++;
        }
        
        }
        public void  DisplyAllBooks()
        {
            for(int i = 0; i < n; i++)
            {
                books[i].DisplyInfo();
            } 
        }

        public Book FindBookByTitle(string name)
        {
            Console.WriteLine(n);
            for (int i = 0; i < n; i++)
            {
                if(books[i].Title == name)
                {
                    return books[i];
                   
                }
               
                  //  Console.WriteLine("the book not found");
                

            }

            Console.WriteLine("the book not found");
            return null;

        }


        public void Borrow(string name)
        {
            Book book = FindBookByTitle(name);
            book.BorrowBook();


        }

       

    }


}
