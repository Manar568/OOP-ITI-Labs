namespace oop_day02_part01
{
    internal class Program
    {
        static void Main(string[] args)
        {
         Book b1=new Book("book1","ahmed");
            Book b2 = new Book("book2", "Mohamed");
            Book b3 = new Book("book3", "ahmed","12345678901",2015,true);
            Book b4 = new Book("book4", "", "12345678", 2050, true);
            Book b5 = new Book();
            b1.DisplyInfo();
            b2.DisplyInfo();
            b3.DisplyInfo();
            b4.DisplyInfo();
            b5.DisplyInfo();

            Console.WriteLine("we are in the libraryyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyy");


            Library l1=new Library("Ketaby");
            l1.AddBook(b1);
            l1.AddBook(b2);
            l1.AddBook(b3);
            l1.AddBook(b4);
            l1.AddBook(b5);

            l1.DisplyAllBooks();
          Book b6=l1.FindBookByTitle("book1");
            b6.DisplyInfo();

            l1.Borrow("book2");


          






        }
    }
}
