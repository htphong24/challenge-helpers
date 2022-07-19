using ChallengeHelpers.Common;
using ChallengeHelpers.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ChallengeHelpers.Services.Tests
{
    [TestClass]
    public class PermutationSequenceServiceTests
    {
        [TestMethod]
        public void DoRun_GivenNormalInputs_ReturnsExpectedResult()
        {
            // Arrange

            // Act
            var r0010 = new PermutationSequenceService().Run(new PermutationSequenceRequest(4,17), out var t0010);
            var r0020 = new PermutationSequenceService().Run(new PermutationSequenceRequest(4,18), out var t0020);
            var r0030 = new PermutationSequenceService().Run(new PermutationSequenceRequest(4,1), out var t0030);
            var r0040 = new PermutationSequenceService().Run(new PermutationSequenceRequest(4,24), out var t0040);
            var r0050 = new PermutationSequenceService().Run(new PermutationSequenceRequest(1,1), out var t0050);

            // Assert
            Assert.AreEqual(r0010, "3412");
            Assert.AreEqual(r0020, "3421");
            Assert.AreEqual(r0030, "1234");
            Assert.AreEqual(r0040, "4321");
            Assert.AreEqual(r0050, "1");
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
