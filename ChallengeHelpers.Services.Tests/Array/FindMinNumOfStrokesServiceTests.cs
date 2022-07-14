using ChallengeHelpers.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ChallengeHelpers.Services.Tests
{
    [TestClass]
    public class FindMinNumOfStrokesServiceTests
    {
        [TestMethod]
        public void DoRun_GivenNormalInputs_ReturnsExpectedResult()
        {
            // Arrange
            var randomArray0010 = Helpers.GenerateRandomArray(min: 1, max: 1000 * 1000, length: 1000);
            var randomArray0020 = Helpers.GenerateRandomArray(min: 1, max: 1000 * 1000 * 1000, length: 100 * 1000);
            
            // Act
            var r0010 = new FindMinNumOfStrokesService().Run(new[] { 1, 3, 2, 1, 2 }, out var t0010);
            var r0020 = new FindMinNumOfStrokesService().Run(new[] { 1, 3, 2, 1, 2, 1, 5, 3, 3, 4, 2 }, out var t0020);
            var r0030 = new FindMinNumOfStrokesService().Run(new[] { 3, 3, 8, 2, 5, 7, 4, 1, 1, 2, 2, 6, 7, 9, 9, 8, 4, 1 }, out var t0030);
            var r0040 = new FindMinNumOfStrokesService().Run(new[] { 5, 8 }, out var t0040);
            var r0050 = new FindMinNumOfStrokesService().Run(new[] { 1, 1, 1, 1 }, out var t0050);
            var r0070 = new FindMinNumOfStrokesService().Run(new[] { 1000 * 1000 * 1000 }, out var t0070);
            var r0080 = new FindMinNumOfStrokesService().Run(new[] { 1000 * 1000 * 1000, 1000 * 1000 * 1000, 1000 * 1000 * 1000 }, out var t0080);
            var r0090 = new FindMinNumOfStrokesService().Run(new[] { 1, 1000 * 1000 * 1000, 1, 1000 * 1000 * 1000, 1, 1000 * 1000 * 1000 }, out var t0090);
            var r0100 = new FindMinNumOfStrokesService().Run(randomArray0010, out var t0100);
            var r0110 = new FindMinNumOfStrokesService().Run(randomArray0020, out var t0110);
            
            // Assert
            Assert.AreEqual(r0010, 4);
            Assert.AreEqual(r0020, 9);
            Assert.AreEqual(r0030, 21);
            Assert.AreEqual(r0040, 8);
            Assert.AreEqual(r0050, 1);
            Assert.AreEqual(r0070, 1000 * 1000 * 1000);
            Assert.AreEqual(r0080, 1000 * 1000 * 1000);
            Assert.AreEqual(r0090, -1); // 2,999,999,998 => -1
        }

        [TestMethod]
        public void DoRun_GivenEdgeCases_ReturnsExpectedResult()
        {
            // Arrange
            var consecutiveArray0010 = Helpers.GenerateConsecutiveArray(min: 999999777, max: 1000 * 1000 * 1000);
            var consecutiveArray0020 = Helpers.GenerateConsecutiveArray(min: 1, max: 100 * 1000);
            var consecutiveArray0030 = Helpers.GenerateConsecutiveArray(min: 50, max: 99856);

            // Act
            var r0060 = new FindMinNumOfStrokesService().Run(new[] { 1 }, out var t0060);
            var r0120 = new FindMinNumOfStrokesService().Run(consecutiveArray0010, out var t0120);
            var r0130 = new FindMinNumOfStrokesService().Run(consecutiveArray0020, out var t0130);
            var r0140 = new FindMinNumOfStrokesService().Run(consecutiveArray0030, out var t0140);

            // Assert
            Assert.AreEqual(r0060, 1);
            Assert.AreEqual(r0120, 1000 * 1000 * 1000); // max
            Assert.AreEqual(r0130, 100 * 1000); // max
            Assert.AreEqual(r0140, 99856); // max
        }
    }
}
