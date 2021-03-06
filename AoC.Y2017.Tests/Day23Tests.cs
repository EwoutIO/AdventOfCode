﻿using AoC.Helpers.Utils;
using AoC.Y2017.Days;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AoC.Y2017.Tests.Days
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
            Assert.AreEqual(6724, result);
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
            Assert.AreEqual(903, result);
        }
    }
}
