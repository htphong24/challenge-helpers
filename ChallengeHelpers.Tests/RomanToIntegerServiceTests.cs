using ChallengeHelpers.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ChallengeHelpers.Tests
{
    [TestClass]
    public class RomanToIntegerServiceTests
    {
        [TestMethod]
        public void DoRun_GivenNormalInputs_ReturnsExpectedResult()
        {
            // Arrange

            // Act
            var r0010 = new RomanToIntegerService().Run("IX", out var t0010);
            var r0020 = new RomanToIntegerService().Run("III", out var t0020);
            var r0030 = new RomanToIntegerService().Run("LVIII", out var t0030);
            var r0040 = new RomanToIntegerService().Run("CCXLV", out var t0040);
            var r0050 = new RomanToIntegerService().Run("CDLIX", out var t0050);
            var r0060 = new RomanToIntegerService().Run("CDLXXXIX", out var t0060);

            // Assert
            Assert.AreEqual(r0010, 9);
            Assert.AreEqual(r0020, 3);
            Assert.AreEqual(r0030, 58);
            Assert.AreEqual(r0040, 245);
            Assert.AreEqual(r0050, 459);
            Assert.AreEqual(r0060, 489);
        }

        [TestMethod]
        public void DoRun_GivenEdgeCases_ReturnsExpectedResult()
        {
            // Arrange

            // Act
            var r0090 = new RomanToIntegerService().Run("I", out var t0090);
            var r0100 = new RomanToIntegerService().Run("MMMCMXCIX", out var t0100);
            var r0110 = new RomanToIntegerService().Run("MMMIV", out var t0110);
            var r0120 = new RomanToIntegerService().Run("MCMXCIV", out var t0120);

            // Assert
            Assert.AreEqual(r0090, 1);
            Assert.AreEqual(r0100, 3999);
            Assert.AreEqual(r0110, 3004);
            Assert.AreEqual(r0120, 1994);
        }
    }
}
