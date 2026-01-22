using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_day07
{
    internal struct Order
    {

        public int OrderNumber;
        public string CustomerName;
        public Pizza[] Pizzas=new Pizza[5];
        public double TotalAmount;
        int n = 0;
        public Order(int number, string name) 
        {
           OrderNumber = number;
            CustomerName = name;

        }
        public void  AddPizza(Pizza p)
        {
            if (n < 5)
            {
                Pizzas[n] = p;
                n++;
            }
            else
            {
                Console.WriteLine("you can't add ");
            }


        }

        public  double CalculateTotal()
        {

            double total = 0;
            for(int i = 0; i < n; i++)
            {
                total += Pizzas[i].Price;
            }

            return total;
        }

        public  string GetOrderStatus()
        {
            string state;

            if (n == 0)
                state = "New Order";
            else if (n > 0 && n <= 3)
                state = "In Progress";
            else
                state = "Large Order";

            return state;


        }

    }
}
