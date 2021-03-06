﻿using AoC.Helpers.Utils;
using AoC.Y2018.Days;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace AoC.Y2018.Tests.Days
{
    [TestClass]
    public class Day05Tests
    {
        private List<string> testInput = new List<string>()
        {
            "dabAcCaCBAcCcaDA"
        };

        [TestMethod]
        public void PartOneTest()
        {
            // Arrange
            var target = new Day05();

            // Act
            var result = target.Execute(Part.One);

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void PartTwoTest()
        {
            // Arrange
            var target = new Day05();

            // Act
            var result = target.Execute(Part.Two);

            // Assert
            Assert.IsNotNull(result);
        }
    }
}