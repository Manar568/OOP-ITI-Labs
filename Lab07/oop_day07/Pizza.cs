using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_day07
{
    [Flags]
    enum PizzaSize
    {
        Small=1,
        Medium=2,
        Large=4,
        ExtraLarge=8
    }
    enum PizzaType
    {
        Cheese,
        Pepperoni,
        Veggie,
        Supreme
    }
    internal struct Pizza
    {

       public PizzaSize Size;
        public PizzaType Type;
        public double Price;
        public bool IsReady;
        public Pizza(PizzaSize size,PizzaType type,double price)
        {
            Size = size;
            Type = type;
            Price = price;
                
            
        }
        public string GetSizeName()
        {
            switch(Size)
            { 
                case PizzaSize.Small:
                    return "Small";
                    break;
                case PizzaSize.Medium:
                   return "Medium";
                        break;

                case PizzaSize.Large:
                   return "Large";
                    break;

                case PizzaSize.ExtraLarge:
                    return "ExtraLarge";
                    break;

            }
            return "";

       }

        public string GetTypeDescription()
        {
            string type="";
            switch (Type)
            {
                case PizzaType.Cheese:
                    type = "Classic cheese pizza";
                    break;

                    case PizzaType.Pepperoni:
                    type = "Pepperoni pizza";
                    break;
                    case PizzaType.Veggie:
                    type = "Vegetable pizza";
                    break;
                    case PizzaType.Supreme:
                    type = "Everything pizza";
                    break;
            }
            return type;

        }



    }
}
