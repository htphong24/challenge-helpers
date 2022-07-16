using ChallengeHelpers.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ChallengeHelpers.Services.Tests
{
    [TestClass]
    public class PrintPermutationsServiceTests
    {
        [TestMethod]
        public void DoRun_GivenNormalInputs_ReturnsExpectedResult()
        {
            // Arrange

            // Act
            var r0010 = new PrintPermutationsService().Run(new[] { 1, 2, 3 }, out var t0010);
            var r0020 = new PrintPermutationsService().Run(new[] { 1, 2 }, out var t0020);
            var r0040 = new PrintPermutationsService().Run(new[] { 1 }, out var t0040);
            var r0050 = new PrintPermutationsService().Run(new[] { 1, 2, 3, 4 }, out var t0050);

            // Assert
            Assert.AreEqual(r0010.Count, 6);
            Assert.AreEqual(r0020.Count, 2);
            Assert.AreEqual(r0040.Count, 1);
            Assert.AreEqual(r0050.Count, 24);
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
