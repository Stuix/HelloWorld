using HelloWorld;
using System;
using Xunit;

namespace HelloTest
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var sut = new Hello();

            sut.Name = "Adam";

            Assert.Equal("Adam", sut.Name);
        }
    }
}
