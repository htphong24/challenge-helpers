using ChallengeHelpers.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ChallengeHelpers.Services.Tests
{
    [TestClass]
    public class ReverseIntegerServiceTests
    {
        [TestMethod]
        public void DoRun_GivenNormalInputs_ReturnsExpectedResult()
        {
            // Arrange

            // Act
            var r0010 = new ReverseIntegerService().Run(123, out var t0010);
            var r0020 = new ReverseIntegerService().Run(-123, out var t0020);
            var r0030 = new ReverseIntegerService().Run(2147483647, out var t0030);
            var r0040 = new ReverseIntegerService().Run(-2147483647, out var t0040);
            var r0050 = new ReverseIntegerService().Run(0, out var t0050);
            var r0060 = new ReverseIntegerService().Run(120, out var t0060);
            var r0080 = new ReverseIntegerService().Run(-120, out var t0080);

            // Assert
            Assert.AreEqual(r0010, 321);
            Assert.AreEqual(r0020, -321);
            Assert.AreEqual(r0030, 0);
            Assert.AreEqual(r0040, 0);
            Assert.AreEqual(r0050, 0);
            Assert.AreEqual(r0060, 21);
            Assert.AreEqual(r0080, -21);
        }

        [TestMethod]
        public void DoRun_GivenEdgeCases_ReturnsExpectedResult()
        {
            // Arrange

            // Act

            // Assert
        }
    }
}
