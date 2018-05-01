using Microsoft.VisualStudio.TestTools.UnitTesting;
using WindowsFormsApp1.Functionality;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Functionality;
using Moq;

namespace WindowsFormsApp1.Functionality.Tests
{
    [TestClass()]
    public class UserTypeTests
    {
        [TestMethod()]
        public void MenuItemVisibleTest()
        {
            //Arrange
            var UT = new UserType();

            //Act
            bool result = UT.MenuItemVisible("logout");

            //Assert
            Assert.AreEqual(true, result);

        }
    }
}