﻿using AoC.Helpers.Utils;
using AoC.Y2016.Days;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AoC.Y2016.Tests.Days
{
    [TestClass]
    public class Day07Tests
    {
        [TestMethod]
        public void PartOneTest()
        {
            // Arrange
            var target = new Day07();

            // Act
            var result = target.Debug(Part.One);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(115, result);
        }

        [TestMethod]
        public void PartTwoTest()
        {
            // Arrange
            var target = new Day07();

            // Act
            var result = target.Debug(Part.Two);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(231, result);
        }
    }
}
