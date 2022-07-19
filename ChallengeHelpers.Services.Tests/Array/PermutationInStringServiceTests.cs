using ChallengeHelpers.Common;
using ChallengeHelpers.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ChallengeHelpers.Services.Tests
{
    [TestClass]
    public class PermutationInStringServiceTests
    {
        [TestMethod]
        public void DoRun_GivenNormalInputs_ReturnsExpectedResult()
        {
            // Arrange

            // Act
            var r0010 = new PermutationInStringService().Run(new PermutationInStringRequest("ab", "eidbaooo"), out var t0010);
            var r0020 = new PermutationInStringService().Run(new PermutationInStringRequest("ab", "eidboaoo"), out var t0020);
            var r0030 = new PermutationInStringService().Run(new PermutationInStringRequest("adc", "dcda"), out var t0030);
            var r0040 = new PermutationInStringService().Run(new PermutationInStringRequest("abbd", "xyzbadbijkl"), out var t0040);

            // Assert
            Assert.AreEqual(r0010, true);
            Assert.AreEqual(r0020, false);
            Assert.AreEqual(r0030, true);
            Assert.AreEqual(r0040, true);
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
