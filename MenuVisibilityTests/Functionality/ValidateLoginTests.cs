using Microsoft.VisualStudio.TestTools.UnitTesting;
using WindowsFormsApp1.Functionality;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Functionality.Tests
{
    [TestClass()]
    public class ValidateLoginTests
    {
        [TestMethod()]
        public void ValidationTest()
        {
            //Arrange
            var VL = new ValidateLogin();

            //Act
            int result1 = VL.Validation("Eddy","3ddy!");
            int result2 = VL.Validation("Username","Password");

            //Assert
            Assert.AreNotEqual(0, result1);
            Assert.AreEqual(0, result2);
        }
    }
}