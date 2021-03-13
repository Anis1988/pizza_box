using System.Collections.Generic;
using PizzaBox.Domain;
using Xunit;

namespace PizzaBox.Testing
{
    public class OrderTest{


    [Fact]
        public void test1(){
            List<Pizza> pizzs = new List<Pizza>();
            pizzs.Add(new Pizza(){PizzaName = "Pizza1"});

        var sut = new Order(){
                Pizzas = pizzs
        };
            var expected = "Pizza1";
            foreach(var item in sut.Pizzas){

            Assert.Equal(expected,item.PizzaName);
            }

        }
    [Theory]
    [InlineData("Crust1")]
        public void test2(string expected){
            List<Pizza> pizzs = new List<Pizza>();
            pizzs.Add(new Pizza(){Crust = "Crust1"});

        var sut = new Order(){
                Pizzas = pizzs
        };

            foreach(var item in sut.Pizzas){

            Assert.Equal(expected,item.Crust);
            }

        }
    }
}
