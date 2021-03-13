using PizzaBox.Domain;
using Xunit;

namespace PizzaBox.Testing
{

    public class CustomerTest{

          [Fact]
          public void Test1(){
                var sut = new Customer(){
                    CustomerName = "Anis"
                };

                var expected = "Anis";

                var actual = sut.CustomerName;


                Assert.Equal(expected, actual);

        }
          [Theory]
          [InlineData("John")]
          public void Test2(string expected){
                var sut = new Customer(){
                    CustomerName = "John"
                };



                var actual = sut.CustomerName;


                Assert.Equal(expected, actual);

        }
    }
}
