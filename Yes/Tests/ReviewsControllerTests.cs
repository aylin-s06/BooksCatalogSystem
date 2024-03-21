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
    /// Unit tests for the ReviewsController class.
    /// </summary>
    [TestClass]
    public class ReviewsControllerTests
    {
        /// <summary>
        /// Test method to verify that SearchBookReviewsByBookName returns matching reviews for a given book.
        /// </summary>
        [TestMethod]
        public void TestSearchBookReviewsByBookName_ReturnsMatchingReviews()
        {
            // Arrange
            var service = new ReviewsController();
            var searchInput = "Mr. Mercedes";
            var expectedReviews = new[]
            {
                new { BookTitle = "Mr. Mercedes", Comment = "Disappointing read, lacked depth and failed to engage.", Rating = 2 },
            };

            // Act
            var result = service.SearchBookReviewsByBookName(searchInput);

            // Assert
            CollectionAssert.AreEqual(expectedReviews, result);
        }

        /// <summary>
        /// Test method to verify that SearchBookReviewsByBookName returns an empty list when no matches are found.
        /// </summary>
        [TestMethod]
        public void TestSearchBookReviewsByBookName_ReturnsEmptyListForNoMatches()
        {
            // Arrange
            var service = new ReviewsController();
            var searchInput = "Hansel and Gretel";

            // Act
            var result = service.SearchBookReviewsByBookName(searchInput);

            // Assert
            Assert.AreEqual(0, result.Count);
        }
    }
}
