using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Yes.Controllers;

namespace Yes.Tests
{
    [TestClass]
    public class AuthorsControllerTests
    {
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

            //chakay
            //stoy day na men
            // Act
            var result = service.SearchAllBooksByAuthor(searchInput);

            // Assert
            CollectionAssert.AreEqual(expectedBooks, result);
        }
        //yess

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
