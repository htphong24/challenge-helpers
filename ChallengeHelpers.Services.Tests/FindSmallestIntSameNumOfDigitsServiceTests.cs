using ChallengeHelpers.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ChallengeHelpers.Services.Tests
{
    [TestClass]
    public class FindSmallestIntSameNumOfDigitsServiceTests
    {
        [TestMethod]
        public void DoRun_GivenNormalInputs_ReturnsExpectedResult()
        {
            // Arrange


            // Act
            var r0010 = new FindSmallestIntSameNumOfDigitsService().Run(1, out var t0010);
            var r0020 = new FindSmallestIntSameNumOfDigitsService().Run(10, out var t0020);
            var r0030 = new FindSmallestIntSameNumOfDigitsService().Run(125, out var t0030);

            // Assert
            Assert.AreEqual(r0010, 0);
            Assert.AreEqual(r0020, 10);
            Assert.AreEqual(r0030, 100);
        }

        [TestMethod]
        public void DoRun_GivenEdgeCases_ReturnsExpectedResult()
        {
            // Arrange


            // Act
            var r0040 = new FindSmallestIntSameNumOfDigitsService().Run(0, out var t0040); // test min value
            var r0050 = new FindSmallestIntSameNumOfDigitsService().Run(1000 * 1000 * 1000, out var t0050); // test max value
            var r0060 = new FindSmallestIntSameNumOfDigitsService().Run(999999999, out var t0060); // test max value - 1
            var r0070 = new FindSmallestIntSameNumOfDigitsService().Run(43545264, out var t0070); // test random large number
            var r0080 = new FindSmallestIntSameNumOfDigitsService().Run(000, out var t0080);

            // Assert
            Assert.AreEqual(r0040, 0);
            Assert.AreEqual(r0050, 1000 * 1000 * 1000);
            Assert.AreEqual(r0060, 100 * 1000 * 1000);
            Assert.AreEqual(r0070, 10 * 1000 * 1000);
            Assert.AreEqual(r0080, 0);
        }
    }
}
