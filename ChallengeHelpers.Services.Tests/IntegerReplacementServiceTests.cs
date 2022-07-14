using ChallengeHelpers.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ChallengeHelpers.Services.Tests
{
    [TestClass]
    public class IntegerReplacementServiceTests
    {
        [TestMethod]
        public void DoRun_GivenNormalInputs_ReturnsExpectedResult()
        {
            // Arrange

            // Act
            var r0010 = new IntegerReplacementService().Run(8, out var t0010);
            var r0020 = new IntegerReplacementService().Run(7, out var t0020);
            var r0040 = new IntegerReplacementService().Run(4096, out var t0040);
            var r0050 = new IntegerReplacementService().Run(67, out var t0050);
            var r0060 = new IntegerReplacementService().Run(25, out var t0060);
            var r0070 = new IntegerReplacementService().Run(28, out var t0070);
            var r0080 = new IntegerReplacementService().Run(29, out var t0080);
            var r0090 = new IntegerReplacementService().Run(63, out var t0090);
            var r0100 = new IntegerReplacementService().Run(4097, out var t0100);

            // Assert
            Assert.AreEqual(r0010, 3);
            Assert.AreEqual(r0020, 4);
            Assert.AreEqual(r0040, 12);
            Assert.AreEqual(r0050, 8);
            Assert.AreEqual(r0060, 6);
            Assert.AreEqual(r0070, 6);
            Assert.AreEqual(r0080, 7);
            Assert.AreEqual(r0090, 7);
            Assert.AreEqual(r0100, 13);
        }

        [TestMethod]
        public void DoRun_GivenEdgeCases_ReturnsExpectedResult()
        {
            // Arrange

            // Act
            var r0030 = new IntegerReplacementService().Run(1, out var t0030);
            var r0110 = new IntegerReplacementService().Run(2147483647, out var t0120);

            // Assert
            Assert.AreEqual(r0110, 32); // n = 2^31 - 1 = 2,147,483,647 => 32
            Assert.AreEqual(r0030, 0);
        }
    }
}
