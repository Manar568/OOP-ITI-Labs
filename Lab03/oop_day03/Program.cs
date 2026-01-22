namespace oop_day02
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Association 
            //ex1
            Programmer m =new Programmer("Manar");

            Labtop l = new Labtop("HP");

            m.Use(l);
           // ex2
            Doctor d = new Doctor("Ahmed");
            Patient p = new Patient("Ali");
            d.Treat(p);

            //ex3

            WebSite w = new WebSite("Amazon");
            User u = new User("Ahmed");

            u.Use(w);
            #endregion

            #region Aggregation
            // ex1

            Office of = new Office(2);

            Chair ch = new Chair("Black");

            of.Contains(ch);


            //ex2
            Charger charger = new Charger(200);
            l.Contains(charger);

            //ex3

            Library li = new Library("Ketaby");

            Book[] books =new Book[2];
            for (int i = 0; i < 2; i++) {
                books[i] = new Book("Sun");
            
            }

            li.Contains(books);

            #endregion

            #region Composition
            ///ex1
            ///

            // car composit of motor



            ///ex2
            ///

            // website composite of Pages

            ///ex3
            ///

            //Labtop composit of screen








            #endregion
        }
    }
}
