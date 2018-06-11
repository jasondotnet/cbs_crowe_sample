using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CroweHorwath.HelloWorld.Controllers;
using System.Collections.Generic;
using System.Linq;

namespace CroweHorwath.HelloWorld.WebApi.Tests.Controllers
{
    [TestClass]
    public class HelloControllerTest
    {
        [TestMethod]
        public void Get()
        {
            // Arrange
            HelloController controller = new HelloController();

            // Act
            IEnumerable<string> result = controller.Get();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(2, result.Count());
            Assert.AreEqual("Hello", result.ElementAt(0));
            Assert.AreEqual("World", result.ElementAt(1));
        }
    }
}
