﻿using AoC.Helpers.Utils;
using AoC.Y2016.Days;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace AoC.Y2016.Tests.Days
{
    [TestClass]
    public class Day21Tests
    {
        [TestMethod]
        public void PartOneTest()
        {
            // Arrange
            var target = new Day21();

            // Act
            var result = target.Debug(Part.One);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("dbfgaehc", result);
        }

        [TestMethod]
        public void PartTwoTest()
        {
            // Arrange
            var target = new Day21();

            // Act
            var result = target.Debug(Part.Two);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("aghfcdeb", result);
        }
    }
}
