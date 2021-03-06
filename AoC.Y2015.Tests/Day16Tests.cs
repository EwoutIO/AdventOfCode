﻿using AoC.Helpers.Utils;
using AoC.Y2015.Days;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AoC.Y2015.Tests.Days
{
    [TestClass]
    public class Day16Tests
    {
        [TestMethod]
        public void PartOneTest()
        {
            // Arrange
            var target = new Day16();

            // Act
            var result = target.Debug(Part.One);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(373, result);
        }

        [TestMethod]
        public void PartTwoTest()
        {
            // Arrange
            var target = new Day16();

            // Act
            var result = target.Debug(Part.Two);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(260, result);
        }
    }
}
