using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using KitchenPlan.Controllers;
using System.Web.Mvc;

namespace KitchenPlan.Test
{
    [TestClass]
    public class HomeControllerTests
    {
        [TestMethod]
        public void Index_SHould_Return_A_View_With_A_Title()
        {
            // Arrange
            var cntrl = new HomeController();

            // Act
            var result = cntrl.Index();

            // Assert
            Assert.IsInstanceOfType(result, typeof(ViewResult));
            var view = result as ViewResult;  // soft cast - will return null if it can't
           // var view = (ViewResult) result; hard cast - will throw exception if it can't 
            Assert.AreEqual("Home", view.ViewBag.Title);
        }
        [TestMethod]
        public void About_Should_Return_A_View_With_A_Title()
        {
            // Arrange
            var cntrl = new HomeController();

            // Act
            var result = cntrl.About();

            // Assert
            Assert.IsInstanceOfType(result, typeof(ViewResult));
            var view = result as ViewResult;  // soft cast - will return null if it can't
            // var view = (ViewResult) result; hard cast - will throw exception if it can't 
            Assert.AreEqual("Home", view.ViewBag.Title);
        }

    }
}
