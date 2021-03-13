using System.Collections.Generic;

namespace PizzaBox.Domain
{
    public class Pizza{


        public string PizzaName { get; set; }
        public int Price { get; set; }
        public string Size { get; set; }
        public string Crust { get; set; }
        public string Toppings { get; set; }

         public override string ToString(){
            return  "Your Pizza chose: "+ PizzaName+", Crust= " + Crust +", Size= "+ Size +", Toppings= "+ Toppings +", Price = $"+ Price;
        }
    }

}
