using System;
using HelloWorld;
using Xunit;

namespace HelloWorld.Tests
{
    public class HelloWorldTests {

        [Fact]
        public void TestGet()
        {
            var helloWorld = new HelloWorld();
            Assert.Equal("Hello World!", helloWorld.Get());
        }
    }


}
