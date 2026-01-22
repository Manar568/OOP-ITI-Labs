namespace oop_day06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student("Manar", 2, 'A');
            Book b1 = new Book("b1","ahmed","123am");
            Book b2 = new Book("b2222", "ahmed", "123am");

            Console.WriteLine(s);
            Console.WriteLine(b1);
            Console.WriteLine(s.GetType());
            Console.WriteLine(b1.GetType());

            Student s2 = new Student("Manar", 2, 'A');
            Student s3 = new Student("Nada", 3, 'A');
            Console.WriteLine(b1.Equals(b2));
            Console.WriteLine(b1.GetHashCode());
            Console.WriteLine(b2.GetHashCode());




            Console.WriteLine("//////////////////////////////");
            Console.WriteLine(s2.Equals(s3));
            Console.WriteLine(s2.Equals(s));
            Console.WriteLine(s2==s);
            
            Console.WriteLine("//////////////////////////////");

            Console.WriteLine(ReferenceEquals(s2,s3));
              s2 =s;
            Console.WriteLine(s2.GetHashCode());
            Console.WriteLine(s.GetHashCode());

            Console.WriteLine(ReferenceEquals(s2,s));
           // Console.WriteLine(s3.Equals(s));

            Student s4=s.clone();
            Console.WriteLine(s4);

        }
    }
}
