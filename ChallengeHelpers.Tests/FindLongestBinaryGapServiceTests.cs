using ChallengeHelpers.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ChallengeHelpers.Tests
{
    [TestClass]
    public class FindLongestBinaryGapServiceTests
    {
        [TestMethod]
        public void DoRun_GivenNormalInputs_ReturnsExpectedResult()
        {
            // Arrange


            // Act
            var r0010 = new FindLongestBinaryGapService().Run(9, out var t0010);
            var r0020 = new FindLongestBinaryGapService().Run(15, out var t0020);
            var r0030 = new FindLongestBinaryGapService().Run(20, out var t0030);
            var r0040 = new FindLongestBinaryGapService().Run(32, out var t0040);
            var r0050 = new FindLongestBinaryGapService().Run(529, out var t0050);
            var r0060 = new FindLongestBinaryGapService().Run(1041, out var t0060);
            var r0090 = new FindLongestBinaryGapService().Run(Convert.ToInt32(Math.Pow(2, 30)), out var t0090); // = 1000...000 => 0
            var r0100 = new FindLongestBinaryGapService().Run(Convert.ToInt32(Math.Pow(2, 30)) + 1, out var t0100); // = 1000...001 => 30 - 1 = 29

            // Assert
            Assert.AreEqual(r0010, 2);
            Assert.AreEqual(r0020, 0);
            Assert.AreEqual(r0030, 1);
            Assert.AreEqual(r0040, 0);
            Assert.AreEqual(r0050, 4);
            Assert.AreEqual(r0060, 5);
            Assert.AreEqual(r0090, 0);
            Assert.AreEqual(r0100, 29);
        }

        [TestMethod]
        public void DoRun_GivenEdgeCases_ReturnsExpectedResult()
        {
            // Arrange


            // Act
            var r0070 = new FindLongestBinaryGapService().Run(1, out var t0070);
            var r0080 = new FindLongestBinaryGapService().Run(int.MaxValue, out var t0080); // = 2^31 -1 => all 1s => no binary gap => 0
            var r0110 = new FindLongestBinaryGapService().Run(Convert.ToInt32(Math.Pow(2, 30) + Math.Pow(2, 27) + Math.Pow(2, 5) + Math.Pow(2, 11)) + 1, out var t0110); // = 27 - 11 - 1 = 15

            // Assert
            Assert.AreEqual(r0070, 0);
            Assert.AreEqual(r0080, 0);
            Assert.AreEqual(r0110, 15);
        }
    }
}
