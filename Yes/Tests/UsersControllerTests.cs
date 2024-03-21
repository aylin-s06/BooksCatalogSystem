using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Linq;
using BookCatalog.Models;
using Yes.Controllers;
using static Microsoft.ApplicationInsights.MetricDimensionNames.TelemetryContext;
using User = BookCatalog.Models.User;

namespace Yes.Tests
{
    [TestClass]
    public class UsersControllerTests
    {

        //hayir
        [TestMethod]
        public void TestIsUserValid_ReturnsTrueForValidUser()
        {
            // Arrange
            var service = new UsersController();
            var user = new User { Email = "Aylin@bg.com", Password = "Aylinpass" };

            // Act
            var isValid = service.IsUserValid(user.Email, user.Password);

            // Assert
            Assert.IsTrue(isValid);
        }
        [TestMethod]
        public void TestIsUserValid_ReturnsFalseForInvalidUser()
        {
            // Arrange
            var service = new UsersController();
            var user = new User { Email = "KrisT@bg.com", Password = "TheBestTeacher" };

            // Act
            var isValid = service.IsUserValid(user.Email, user.Password);

            // Assert
            Assert.IsFalse(isValid);
        }
        [TestMethod]
        public void TestIsUserValid_ReturnsFalseForEmptyEmail()
        {
            // Arrange
            var service = new UsersController();

            // Act
            var isValid = service.IsUserValid("", "somePassword");

            // Assert
            Assert.IsFalse(isValid);
        }

        [TestMethod]
        public void TestIsUserValid_ReturnsFalseForIncorrectPassword()
        {
            // Arrange
            var service = new UsersController();
            var user = new User { Email = "IvanM@bg.com", Password = "wrongPassword" };

            // Act
            var isValid = service.IsUserValid(user.Email, "incorrectPassword");

            // Assert
            Assert.IsFalse(isValid);
        }
        [TestMethod]
        public void TestGetUserNameByEmail_ReturnsUserNameForExistingEmail()
        {
            // Arrange
            var service = new UsersController();
            var email = "Nikol@bg.com";
            var expectedUserName = "Nikol";

            // Act
            var userName = service.GetUserNameByEmail(email);

            // Assert
            Assert.AreEqual(expectedUserName, userName);
        }
        //yes
        [TestMethod]
        public void TestGetUserNameByEmail_ReturnsEmptyStringForNonExistingEmail()
        {
            // Arrange
            var service = new UsersController();
            var email = "nai@example.com";

            // Act
            var userName = service.GetUserNameByEmail(email);

            // Assert
            Assert.AreEqual("", userName); //dobre e
        }
    }
}
