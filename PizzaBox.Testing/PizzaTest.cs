using PizzaBox.Domain;
using Xunit;

namespace PizzaBox.Testing
{
    public class PizzaTest{

        [Fact]
        public void test1(){
            var sut = new Pizza(){
                PizzaName = "Pizza1",
                Size = "Small",
                Toppings = "Cheese",
                Crust = "Crust1",
            };
            var expected = "Pizza1";
            var expected1 = "Small";
            var expected2 = "Crust1";
            var actual = sut.PizzaName;
            var actual1 = sut.Size;
            var actual2 = sut.Crust;

            Assert.Equal(expected, actual);
            Assert.Equal(expected1, actual1);
            Assert.Equal(expected2, actual2);


        }
             [Theory]
             [InlineData("Pizza2")]
        public void test2(string expected){
            var sut = new Pizza(){
                PizzaName = "Pizza2",
                Crust = "Crust2",
            };
            var actual1 = sut.PizzaName;

            Assert.Equal(expected, actual1);
        }
             [Theory]
             [InlineData("Crust2")]
        public void test3(string expected){
            var sut = new Pizza(){
                PizzaName = "Pizza2",
                Crust = "Crust2",
            };
            var actual1 = sut.Crust;

            Assert.Equal(expected, actual1);
        }

    }

}

