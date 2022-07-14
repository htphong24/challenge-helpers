using ChallengeHelpers.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ChallengeHelpers.Services.Tests
{
    [TestClass]
    public class FindSmallestMissingIntServiceTests
    {
        [TestMethod]
        public void DoRun_GivenNormalInputs_ReturnsExpectedResult()
        {
            // Arrange

            // Act
            var r0010 = new FindSmallestMissingIntService().Run(new[] { 1, 3, 6, 4, 1, 2 }, out var t0010); // positive only
            var r0020 = new FindSmallestMissingIntService().Run(new[] { 1, 4, 10 }, out var t0020); // positive only
            var r0030 = new FindSmallestMissingIntService().Run(new[] { 100, 101, 102 }, out var t0030); // positive only
            var r0040 = new FindSmallestMissingIntService().Run(new[] { -100, -103 }, out var t0040); // negative only
            var r0050 = new FindSmallestMissingIntService().Run(new[] { -1000000, 1, 3, 6, 4, 1, 1000000 }, out var t0050); // negative and positive
            var r0060 = new FindSmallestMissingIntService().Run(new[] { 4, 0, 6, 500, 304, 10, 63, 100, 8, 9999, 2 }, out var t0060);

            // Assert
            Assert.AreEqual(r0010, 5);
            Assert.AreEqual(r0020, 2);
            Assert.AreEqual(r0030, 1);
            Assert.AreEqual(r0040, 1);
            Assert.AreEqual(r0050, 2);
            Assert.AreEqual(r0060, 1);
        }

        [TestMethod]
        public void DoRun_GivenEdgeCases_ReturnsExpectedResult()
        {
            // Arrange
            var randomArray = Helpers.GenerateRandomArray(min: -1, max: 3, length: 1000);
            var consecutiveArray = Helpers.GenerateConsecutiveArray(min: 1, max: 100 * 1000);

            // Act
            var r0070 = new FindSmallestMissingIntService().Run(new[] { int.MaxValue }, out var t0070);
            var r0080 = new FindSmallestMissingIntService().Run(new[] { int.MinValue, int.MaxValue }, out var t0080);
            var r0090 = new FindSmallestMissingIntService().Run(new int[] { }, out var t0090); // empty
            var r0100 = new FindSmallestMissingIntService().Run(randomArray, out var t0100); // large random array
            var r0110 = new FindSmallestMissingIntService().Run(consecutiveArray, out var t0110); // large consecutive array

            // Assert
            Assert.AreEqual(r0070, 1);
            Assert.AreEqual(r0080, 1);
            Assert.AreEqual(r0090, 1);
            //Assert.AreEqual(r0100, 12);
            //Assert.AreEqual(r0110, 12); // max + 1
        }
    }
}
