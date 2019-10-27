using System;
using Xunit;
using AppRateAPI.Controllers;

namespace AppRateAPI.Test
{
    public class UnitTest1
    {

        ValuesController controller = new ValuesController();
        [Fact]
        public void GetReturnsName()
        {
            var returnValue = controller.Get(1);
            Assert.Equal("Douglas Kane", returnValue.Value);
        }        

        [Fact]
        public void Test1()
        {

        }
    }
}
