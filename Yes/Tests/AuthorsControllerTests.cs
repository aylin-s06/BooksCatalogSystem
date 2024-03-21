using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Yes.Controllers;

namespace Yes.Tests
{
    /// <summary>
    /// Unit tests for the AuthorsController class.
    /// </summary>
    [TestClass]
    public class AuthorsControllerTests
    {
        /// <summary>
        /// Test method to verify that SearchAllBooksByAuthor returns matching books for a given author name.
        /// </summary>
        [TestMethod]
        public void TestSearchAllBooksByAuthor_ReturnsMatchingBooks()
        { 
            var service = new AuthorsController(); 
            var searchInput = "Agatha Christie";
            var expectedBooks = new List<object>
            { new { AuthorName = "Agatha Christie", BookTitle = "Murder on the Orient Express" },
              new { AuthorName = "Agatha Christie", BookTitle = "And Then There Were None" },
              new { AuthorName = "Agatha Christie", BookTitle = "The Man in the Brown Suit" },
              new { AuthorName = "Agatha Christie", BookTitle = "The Secret Adversary" }
            };

            // Act
            var result = service.SearchAllBooksByAuthor(searchInput);

            // Assert
            CollectionAssert.AreEqual(expectedBooks, result);
        }

        /// <summary>
        /// Test method to verify that SearchAllBooksByAuthor returns an empty list when no matches are found.
        /// </summary>
        [TestMethod]
        public void TestSearchAllBooksByAuthor_ReturnsEmptyListForNoMatches()
        {
            // Arrange
            var service = new AuthorsController();
            var searchInput = "Ivan Vazov";

            // Act
            var result = service.SearchAllBooksByAuthor(searchInput);

            // Assert
            Assert.AreEqual(0, result.Count);
        }
    }
}
