using ChallengeHelpers.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ChallengeHelpers.Services.Tests
{
    [TestClass]
    public class ReturnUniquePermutationsServiceTests
    {
        [TestMethod]
        public void DoRun_GivenNormalInputs_ReturnsExpectedResult()
        {
            // Arrange

            // Act
            var r0010 = new ReturnUniquePermutationsService().Run(new[] { 1, 2, 3 }, out var t0010);
            var r0020 = new ReturnUniquePermutationsService().Run(new[] { 1, 2 }, out var t0020);
            var r0040 = new ReturnUniquePermutationsService().Run(new[] { 1 }, out var t0040);
            var r0050 = new ReturnUniquePermutationsService().Run(new[] { 1, 2, 3, 4 }, out var t0050);
            var r0060 = new ReturnUniquePermutationsService().Run(new[] { 1, 1, 2 }, out var t0060);
            var r0070 = new ReturnUniquePermutationsService().Run(new[] { 1, 1, 2, 3 }, out var t0070);

            // Assert
            Assert.AreEqual(r0010.Count, 6);
            Assert.AreEqual(r0020.Count, 2);
            Assert.AreEqual(r0040.Count, 1);
            Assert.AreEqual(r0050.Count, 24);
            Assert.AreEqual(r0060.Count, 3);
            Assert.AreEqual(r0070.Count, 12);
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
