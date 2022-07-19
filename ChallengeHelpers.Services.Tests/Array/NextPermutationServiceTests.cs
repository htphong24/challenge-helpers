using ChallengeHelpers.Common;
using ChallengeHelpers.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ChallengeHelpers.Services.Tests
{
    [TestClass]
    public class NextPermutationServiceTests
    {
        [TestMethod]
        public void DoRun_GivenNormalInputs_ReturnsExpectedResult()
        {
            // Arrange

            // Act
            var r0010 = new NextPermutationService().Run(new[] { 1, 5, 8, 4, 7, 6, 5, 3, 1 }, out var t0010);
            var r0020 = new NextPermutationService().Run(new[] { 1, 2 }, out var t0020);
            var r0030 = new NextPermutationService().Run(new[] { 1 }, out var t0030);
            var r0040 = new NextPermutationService().Run(new[] { 1,2,3 }, out var t0040);
            var r0050 = new NextPermutationService().Run(new[] { 3,2,1 }, out var t0050);
            var r0060 = new NextPermutationService().Run(new[] { 1,1,5 }, out var t0060);

            // Assert
            Assert.AreEqual(r0010.ConvertToString(), "1,5,8,5,1,3,4,6,7");
            Assert.AreEqual(r0020.ConvertToString(), "2,1");
            Assert.AreEqual(r0030.ConvertToString(), "1");
            Assert.AreEqual(r0040.ConvertToString(), "1,3,2");
            Assert.AreEqual(r0050.ConvertToString(), "1,2,3");
            Assert.AreEqual(r0060.ConvertToString(), "1,5,1");
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
