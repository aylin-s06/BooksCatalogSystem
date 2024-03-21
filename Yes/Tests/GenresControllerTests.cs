using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yes.Controllers;

namespace Yes.Tests
{
    [TestClass]
    public class GenresControllerTests
    {
        [TestMethod]//super
        public void TestSearchAllFromSelectedGenre_ReturnsMatchingBooks()
        {
            //koe ima nay-malko
            // Arrange
            var service = new GenresController();
            var searchInput = "Horror";
            var expectedBooks = new List<object>
            {
               new { Title = "The Shining", ISBN = "418983209-X", Genre = "Horror", Author = "Stephen King", IsAvailable = true }
            };

            // Act
            var result = service.SearchAllFromSelectedGenre(searchInput);

            // Assert
            CollectionAssert.AreEqual(expectedBooks, result);
        }
        /// <summary>
        /// aaa
        /// </summary>
        [TestMethod]
        public void TestSearchAllFromSelectedGenre_ReturnsEmptyListForNoMatches()
        {
            // Arrange
            var service = new GenresController();
            var searchInput = "Poetry";

            // Act
            var result = service.SearchAllFromSelectedGenre(searchInput);

            // Assert
            Assert.AreEqual(0, result.Count);
        }


    }
}
