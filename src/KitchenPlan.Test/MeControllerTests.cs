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
    public class MeControllerTests
    {
        [TestMethod]
        public void Bio_Should_Return_A_View_With_A_Title()
        {
            // Arrange
            var cntrl = new MeController();

            // Act
            var result = cntrl.Bio();

            // Assert
            Assert.IsInstanceOfType(result, typeof(ViewResult));
            var view = result as ViewResult;  // soft cast - will return null if it can't
            // var view = (ViewResult) result; hard cast - will throw exception if it can't 
            Assert.AreEqual("Bio", view.ViewBag.Title);
        }
        [TestMethod]
        public void HeadShot_Should_Return_A_View_With_A_Title()
        {
            // Arrange
            var cntrl = new MeController();

            // Act
            var result = cntrl.HeadShot();

            // Assert
            Assert.IsInstanceOfType(result, typeof(ViewResult));
            var view = result as ViewResult;  // soft cast - will return null if it can't
            // var view = (ViewResult) result; hard cast - will throw exception if it can't 
            Assert.AreEqual("HeadShot", view.ViewBag.Title);
        }
    }
}
