
using System;
using System.Collections.Generic;
using PizzaBox.Domain;
using PizzaBox.Storing;

namespace PizzaBox.Client
{
    class Program{
            static Store store = new Store();
            static Pizza pizza = new Pizza();
            static Order orders = new Order();
            static Customer customer = new Customer();

            static List<Store> stores = new List<Store>();
            static List<Pizza> pizzas = new List<Pizza>();
            static List<Customer> customers = new List<Customer>();
        static void Main(string[] args){
            createName();
            printSelectStore();
            printSelectionMenu();
            stores.Add(store);
            pizzas.Add(pizza);
            customers.Add(customer);

            var fs = new FileStorage();
            fs.WriteToXml<Store>(stores);


            fs.WriteToOrderXml<Customer>(customers);


            fs.WriteToPizzaXml<Pizza>(pizzas);
            System.Console.WriteLine("SIZE = "+ pizza.Size);

        }
        public static void createName(){
            System.Console.WriteLine("Please enter your name: ");
            var name = Console.ReadLine();
            customer = new Customer(){
                CustomerName = name
            };
        }
        public static void printSelectionMenu(){
            Console.WriteLine("Please Select 1 - 5");
            Console.WriteLine("1- Select Pizza  ");
            Console.WriteLine("2- Select Size  ");
            Console.WriteLine("3- Select Crust  ");
            Console.WriteLine("4- Select Toppings  ");
            Console.WriteLine("5- Save & Exit  ");

            var input2 = Console.ReadLine();
            if  (int.Parse(input2) == 1 || int.Parse(input2)==2 || int.Parse(input2)==3 || int.Parse(input2)==4|| int.Parse(input2)==5){
            switch (int.Parse(input2)){
                case 1:
                pizzaSelection();
                break;
                case 2:
                sizeSelection();
                printSelectionMenu();
                break;
                case 3:
                crustSelection();
                printSelectionMenu();
                break;
                case 4:
                toppingSelection();
                printSelectionMenu();
                break;
                case 5:
                break;

            }
            } else {
                printSelectionMenu();
            }
        }
        private static void toppingSelection(){
            var priceOlives = 2;
            var priceExtraCheese = 3;
            var priceGreenPepper = 4;
            var pricePepperoni = 5;
            System.Console.WriteLine("Choose a Topping 1 - 4");
            System.Console.WriteLine("1 - Olives + $"+priceOlives );
            System.Console.WriteLine("2 - Extra Cheese + $"+priceExtraCheese);
            System.Console.WriteLine("3 - Green Pepper + $"+priceGreenPepper);
            System.Console.WriteLine("4 - Pepperoni + $"+pricePepperoni);
            var input5 = Console.ReadLine();
            if  (int.Parse(input5) == 1 || int.Parse(input5)==2 || int.Parse(input5)==3 || int.Parse(input5)==4){

            switch (int.Parse(input5)){
                case 1:
                    pizza = new Pizza(){
                        PizzaName = pizza.PizzaName,
                        Price = pizza.Price + priceOlives,
                        Crust = "Olives",
                    };
                    break;
                case 2:
                    pizza = new Pizza(){
                        PizzaName = pizza.PizzaName,
                        Price = pizza.Price + priceExtraCheese,
                        Crust = "Extra Cheese",
                    };
                    break;
                case 3:
                    pizza = new Pizza(){
                        PizzaName = pizza.PizzaName,
                        Price = pizza.Price + priceGreenPepper,
                        Crust = "Green Pepper",
                    };
                    break;
                case 4:
                    pizza = new Pizza(){
                        PizzaName = pizza.PizzaName,
                        Price = pizza.Price + pricePepperoni,
                        Crust = "Pepperoni",
                    };
                    break;

            }
            } else{
                toppingSelection();
            }
        }

        private static void crustSelection(){
            var priceFlatbread = 5;
            var priceCheeseStuffed = 10;
            var priceSicillian = 15;
            System.Console.WriteLine("Choose a Crust 1 - 3");
            System.Console.WriteLine("1 - FlatBread + $"+priceFlatbread );
            System.Console.WriteLine("2 - CheeseStuffed + $"+priceCheeseStuffed);
            System.Console.WriteLine("3 - Sicillian + $"+priceSicillian);
            System.Console.WriteLine("4 - Exit ");
            var input5 = Console.ReadLine();
            if  (int.Parse(input5) == 1 || int.Parse(input5)==2 || int.Parse(input5)==3 || int.Parse(input5)==4){

            switch (int.Parse(input5)){
                case 1:
                    pizza = new Pizza(){
                        PizzaName = pizza.PizzaName,
                        Price = pizza.Price + priceFlatbread
                    };
                    break;
                case 2:
                    pizza = new Pizza(){
                        PizzaName = pizza.PizzaName,
                        Price = pizza.Price + priceCheeseStuffed
                    };
                    break;
                case 3:
                    pizza = new Pizza(){
                        PizzaName = pizza.PizzaName,
                        Price = pizza.Price + priceSicillian
                    };
                break;
                case 4:
                 break;

            }
            } else {
                    crustSelection();
            }
        }

        private static void sizeSelection(){
            var priceSM = 5;
            var priceME = 10;
            var priceLA = 15;
            System.Console.WriteLine("Choose between 1 - 3");
            System.Console.WriteLine("1 - Small + $"+priceSM );
            System.Console.WriteLine("2 - Medium + $"+priceME);
            System.Console.WriteLine("3 - Large + $"+priceLA);
            System.Console.WriteLine("4 - Exit ");

            var input4 = Console.ReadLine();
            if  (int.Parse(input4) == 1 || int.Parse(input4)==2 || int.Parse(input4)==3 || int.Parse(input4)==4){

            switch (int.Parse(input4)) {
                case 1:
                    pizza = new Pizza(){
                        PizzaName = pizza.PizzaName,
                        Price = pizza.Price + priceSM,
                        Size = "Small"
                    };
                    break;
                case 2:
                    pizza = new Pizza(){
                        PizzaName = pizza.PizzaName,
                        Price = pizza.Price + priceME,
                        Size = "Medium"
                    };
                    break;
                case 3:
                    pizza = new Pizza(){
                        PizzaName = pizza.PizzaName,
                        Price = pizza.Price + priceLA,
                        Size ="Small"
                    };
                break;
                case 4:
                  break;

            }
            } else {
                sizeSelection();
            }

        }

        public static void printSelectStore(){
            Console.WriteLine("Please select a Store 1 - 3");
            Console.WriteLine("1- California  ");
            Console.WriteLine("2- Texas  ");
            Console.WriteLine("3- Florida  ");
            System.Console.WriteLine("4- Exit ");

            var input1 = Console.ReadLine();
            if(int.Parse(input1)==1 || int.Parse(input1)==2 || int.Parse(input1)==3|| int.Parse(input1)==4){
            switch(int.Parse(input1)){
                case 1:
                    store = new Store(){
                            Name = "California"
                        };
                    break;
                case 2:
                     store = new Store(){
                            Name = "Texas"
                        };
                    break;
                case 3:
                     store = new Store(){
                            Name = "Florida"
                        };
                    break;
                case 4:
                    break;

            }
            }
            else {
                printSelectStore();
            }
        }
         private static void pizzaSelection() {
                var pizzaNeat = "Neapolitan";
                var pizzaGreek = "GreekPizza";
                var pizzaCali = "CaliforniaPizza";
                var pizzaChicago = "ChicagoPizza";
                var price1 = 20;
                var price2 = 25;
                var price3 = 30;
                var price4 = 35;
           System.Console.WriteLine("Please choose a Pizza 1 - 4");
           System.Console.WriteLine("1 - "+ pizzaNeat + " => $"+ price1 );
           System.Console.WriteLine("2 - "+ pizzaGreek + " => $"+ price2 );
           System.Console.WriteLine("3 - "+ pizzaCali + " => $"+ price3 );
           System.Console.WriteLine("4 - "+ pizzaChicago + " => $"+ price4 );
           System.Console.WriteLine("5 - Exit ");


            var input3 = Console.ReadLine();
            if  (int.Parse(input3) == 1 || int.Parse(input3)==2 || int.Parse(input3)==3 || int.Parse(input3)==4 || int.Parse(input3)==5){
           switch (int.Parse(input3)) {
               case 1:
               System.Console.WriteLine("You selected " + pizzaNeat);
               pizza = new Pizza(){
                    PizzaName = pizzaNeat,
                    Price = price1
               };
                printSelectionMenu();
               break;
               case 2:
               System.Console.WriteLine("You selected " + pizzaGreek);
                 pizza = new Pizza(){
                    PizzaName = pizzaGreek,
                    Price = price2
               };
                printSelectionMenu();
               break;
               case 3:
               System.Console.WriteLine("You selected " + pizzaCali);
                pizza = new Pizza(){
                    PizzaName = pizzaCali,
                    Price = price3
               };
                printSelectionMenu();
               break;
               case 4:
               System.Console.WriteLine("You selected " + pizzaChicago);
                pizza = new Pizza(){
                    PizzaName = pizzaChicago,
                    Price = price4
               };
                printSelectionMenu();
               break;
               case 5:
                break;
           }
            } else{
                pizzaSelection();
            }
        }
    }
}
