using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yes.Controllers;

namespace Yes.Tests
{
    /// <summary>
    /// Unit tests for the GenresController class.
    /// </summary>
    [TestClass]
    public class GenresControllerTests
    {
        /// <summary>
        /// Test method to verify that SearchAllFromSelectedGenre returns matching books for a given genre.
        /// </summary>
        [TestMethod]
        public void TestSearchAllFromSelectedGenre_ReturnsMatchingBooks()
        {
            
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
        /// Test method to verify that SearchAllFromSelectedGenre returns an empty list when no matches are found.
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
