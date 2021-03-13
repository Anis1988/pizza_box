
using System;
using Xunit;
using PizzaBox.Domain;


namespace PizzaBox.Testing
{
    public class UnitTest1
    {
        [Fact]
        public void Test1(){
                var sut = new Store(){
                    Name = "California"
                };

                var expected = "California";

                var actual = sut.Name;


                Assert.Equal(expected, actual);

        }
        [Fact]
        public void Test2(){
                var sut = new Store(){
                    Name = ""
                };

                var expected = "";

                var actual = sut.Name;


                Assert.Equal(expected, actual);
        }
        [Theory]
        [InlineData("Florida")]
        public void Test3(string expected){
                var sut = new Store(){
                    Name = "Florida"
                };

                var actual = sut.Name;


                Assert.Equal(expected, actual);
        }

    }
}
