namespace oop_day07
{
    internal class Program
    {
        
        static void Main(string[] args)
        {

            PizzaSize pi=( PizzaSize.Small | PizzaSize.Large); 
            Console.WriteLine(pi);
            pi = PizzaSize.Small &~PizzaSize.Large;
            Console.WriteLine(pi);

            Console.WriteLine("////////////////////////////////////");


            Pizza p1 = new Pizza(PizzaSize.Small,PizzaType.Cheese,50);
            Pizza p2 = new Pizza(PizzaSize.Large, PizzaType.Cheese, 100);
            Pizza p3 = new Pizza(PizzaSize.Medium, PizzaType.Pepperoni, 70);
            Pizza p4 = new Pizza(PizzaSize.ExtraLarge, PizzaType.Cheese, 200);
            Console.WriteLine(p1.GetSizeName());
            Console.WriteLine(p4.GetSizeName());
            Console.WriteLine(p4.GetTypeDescription());


            Console.WriteLine("////////////////////////////////////");


            Order o1=new Order(1,"Manar");
            Order o2 = new Order(2, "Nada");


            o1.AddPizza(p1);
            o1.AddPizza(p2);
            o1.AddPizza(p3);
            Console.WriteLine(o1.CalculateTotal());
            Console.WriteLine(o1.GetOrderStatus());


            Console.WriteLine("////////////////////////////////////");



            Console.WriteLine(o2.CalculateTotal());
            Console.WriteLine(o2.GetOrderStatus());








        }
    }
}
