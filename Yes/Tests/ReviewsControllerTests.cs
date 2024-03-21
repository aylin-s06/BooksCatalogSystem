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
    public class ReviewsControllerTests
    {
        //yay
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
        //samo book ostava
    }
}
