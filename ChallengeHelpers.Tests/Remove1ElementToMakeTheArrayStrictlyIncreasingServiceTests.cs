using ChallengeHelpers.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ChallengeHelpers.Tests
{
    [TestClass]
    public class Remove1ElementToMakeTheArrayStrictlyIncreasingServiceTests
    {
        [TestMethod]
        public void DoRun_GivenNormalInputs_ReturnsExpectedResult()
        {
            // Arrange

            // Act
            var r0010 = new Remove1ElementToMakeTheArrayStrictlyIncreasingService().Run(new[] { 1, 2, 10, 5, 7 }, out var t0010);
            var r0020 = new Remove1ElementToMakeTheArrayStrictlyIncreasingService().Run(new[] { 2, 3, 1, 2 }, out var t0020);
            var r0040 = new Remove1ElementToMakeTheArrayStrictlyIncreasingService().Run(new[] { 1, 1, 1 }, out var t0040);
            var r0050 = new Remove1ElementToMakeTheArrayStrictlyIncreasingService().Run(new[] { 1, 1 }, out var t0050);
            var r0060 = new Remove1ElementToMakeTheArrayStrictlyIncreasingService().Run(new[] { 3, 1 }, out var t0060);
            var r0070 = new Remove1ElementToMakeTheArrayStrictlyIncreasingService().Run(new[] { 1, 3 }, out var t0070);
            var r0080 = new Remove1ElementToMakeTheArrayStrictlyIncreasingService().Run(new[] { 1, 2, 10, 10, 5, 7 }, out var t0080);
            var r0090 = new Remove1ElementToMakeTheArrayStrictlyIncreasingService().Run(new[] { 1, 2, 10, 5, 10, 7 }, out var t0090);
            var r0100 = new Remove1ElementToMakeTheArrayStrictlyIncreasingService().Run(new[] { 1, 2, 10, 5, 11, 7 }, out var t0100);
            var r0110 = new Remove1ElementToMakeTheArrayStrictlyIncreasingService().Run(new[] { 3, 2, 1 }, out var t0110);
            var r0120 = new Remove1ElementToMakeTheArrayStrictlyIncreasingService().Run(new[] { 3, 1, 1 }, out var t0120);
            var r0130 = new Remove1ElementToMakeTheArrayStrictlyIncreasingService().Run(new[] { 1, 3, 1 }, out var t0130);
            var r0140 = new Remove1ElementToMakeTheArrayStrictlyIncreasingService().Run(new[] { 1, 1, 3 }, out var t0140);
            var r0150 = new Remove1ElementToMakeTheArrayStrictlyIncreasingService().Run(new[] { 3, 1, 2 }, out var t0150);
            var r0160 = new Remove1ElementToMakeTheArrayStrictlyIncreasingService().Run(new[] { 1, 2, 3, 4, 5 }, out var t0160);

            // Assert
            Assert.AreEqual(r0010, true);
            Assert.AreEqual(r0020, false);
            Assert.AreEqual(r0040, false);
            Assert.AreEqual(r0050, true);
            Assert.AreEqual(r0060, true);
            Assert.AreEqual(r0070, true);
            Assert.AreEqual(r0080, false);
            Assert.AreEqual(r0090, false);
            Assert.AreEqual(r0100, false);
            Assert.AreEqual(r0110, false);
            Assert.AreEqual(r0120, false);
            Assert.AreEqual(r0130, true);
            Assert.AreEqual(r0140, true);
            Assert.AreEqual(r0150, true);
            Assert.AreEqual(r0160, true);
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
