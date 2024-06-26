﻿using BookCatalog.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yes.Tests
{
    /// <summary>
    /// Unit tests for the BooksController class.
    /// </summary>
    [TestClass]
    public class BooksControllerTests
    {
        /// <summary>
        /// Test method to verify that SearchAllBooks returns matching books for a given search input.
        /// </summary>
        [TestMethod]
        public void TestSearchAllBooks_ReturnsMatchingBooks()
        {
            // Arrange
            var controller = new BooksController();
            var searchInput = "Harry Potter";
            var expectedBooks = new[]
            {
                new { Title = "Harry Potter and the Philosophers Stone", ISBN = "051302767-X", Genre = "Fantasy", Author = "J.K. Rowling", IsAvailable = true },
                new { Title = "Harry Potter and the Chamber of Secrets", ISBN = "583306983-1", Genre = "Fantasy", Author = "J.K. Rowling", IsAvailable = true },
                new { Title = "Harry Potter and the Prisoner of Azkaban", ISBN = "100371588-5", Genre = "Fantasy", Author = "J.K. Rowling", IsAvailable = false },
                new { Title = "Harry Potter and the Goblet of Fire", ISBN = "966904518-5", Genre = "Fantasy", Author = "J.K. Rowling", IsAvailable = false },
            };

            // Act
            var result = controller.SearchAllBooks(searchInput);

            // Assert
            CollectionAssert.AreEqual(expectedBooks, result);
        }

        /// <summary>
        /// Test method to verify that SearchAllBooks returns an empty list when no matches are found.
        /// </summary>
        [TestMethod]
        public void TestSearchAllBooks_ReturnsEmptyListForNoMatches()
        {
            // Arrange
            var controller = new BooksController();
            var searchInput = "NonExistingBook";

            // Act
            var result = controller.SearchAllBooks(searchInput);

            // Assert
            Assert.AreEqual(0, result.Count);
        }
    }
}
