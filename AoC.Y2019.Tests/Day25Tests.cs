﻿using AoC.Helpers.Utils;
using AoC.Y2019.Days;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace AoC.Y2019.Tests.Days
{
    [TestClass]
    public class Day25Tests
    {
        private List<string> testInput = new List<string>()
            {
            };

        [TestMethod]
        public void PartOneTest()
        {
            // Arrange
            var target = new Day25();

            // Act
            var result = target.Debug(Part.One);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("536904736", result);
        }

        [TestMethod]
        public void PartTwoTest()
        {
            // Arrange
            var target = new Day25();

            // Act
            var result = target.Debug(Part.Two);

            // Assert
            Assert.IsNotNull(result);
        }
    }
}
