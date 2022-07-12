using ChallengeHelpers.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace ChallengeHelpers.Tests
{
    [TestClass]
    public class TwoSumServiceTests
    {
        [TestMethod]
        public void DoRun_GivenNormalInputs_ReturnsExpectedResult()
        {
            // Arrange


            // Act
            var r0010 = new TwoSumService().Run(new TwoSumRequest(new[] { 2, 7, 11, 15 }, 9), out var t0010);
            var r0020 = new TwoSumService().Run(new TwoSumRequest(new[] { 3, 2, 4 }, 6), out var t0020);
            var r0030 = new TwoSumService().Run(new TwoSumRequest(new[] { 3, 3 }, 6), out var t0030);
            var r0040 = new TwoSumService().Run(new TwoSumRequest(new[] { 5, 0, 8, 3, 1, 6, 8, 9 }, 15), out var t0040);
            var r0050 = new TwoSumService().Run(new TwoSumRequest(new[] { 1, 1, 1, 1, 1, 4, 1, 1, 1, 1, 1, 7, 1, 1, 1, 1, 1 }, 11), out var t0050);
            var r0060 = new TwoSumService().Run(new TwoSumRequest(new[] { 1, 5, 3, 0, 8, 3, 1, 6, 8, 9 }, 15), out var t0060);

            // Assert
            Assert.IsTrue(r0010.SequenceEqual(new[] { 0, 1 }));
            Assert.IsTrue(r0020.SequenceEqual(new[] { 1, 2 }));
            Assert.IsTrue(r0030.SequenceEqual(new[] { 0, 1 }));
            Assert.IsTrue(r0040.SequenceEqual(new[] { 5, 7 }));
            Assert.IsTrue(r0050.SequenceEqual(new[] { 5, 11 }));
        }

        [TestMethod]
        public void DoRun_GivenEdgeCases_ReturnsExpectedResult()
        {
            // Arrange


            // Act
            //var r0010 = new TwoSumService().Run(new TwoSumRequest(new[] { }, ), out var t0010);
            //var r0020 = new TwoSumService().Run(new TwoSumRequest(new[] { }, ), out var t0020);
            //var r0030 = new TwoSumService().Run(new TwoSumRequest(new[] { }, ), out var t0030);

            // Assert
            //Assert.AreEqual(r0010, new[] { });
            //Assert.AreEqual(r0020, new[] { });
            //Assert.AreEqual(r0030, new[] { });
        }
    }
}
