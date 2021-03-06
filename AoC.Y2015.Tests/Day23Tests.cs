﻿using AoC.Helpers.Utils;
using AoC.Y2015.Days;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AoC.Y2015.Tests.Days
{
    [TestClass]
    public class Day23Tests
    {
        [TestMethod]
        public void PartOneTest()
        {
            // Arrange
            var target = new Day23();

            // Act
            var result = target.Debug(Part.One);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(184, result);
        }

        [TestMethod]
        public void PartTwoTest()
        {
            // Arrange
            var target = new Day23();

            // Act
            var result = target.Debug(Part.Two);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(231, result);
        }
    }
}
