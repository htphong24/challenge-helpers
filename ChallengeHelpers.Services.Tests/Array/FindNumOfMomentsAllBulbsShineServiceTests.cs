using ChallengeHelpers.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ChallengeHelpers.Services.Tests
{
    [TestClass]
    public class FindNumOfMomentsAllBulbsShineServiceTests
    {
        [TestMethod]
        public void DoRun_GivenNormalInputs_ReturnsExpectedResult()
        {
            // Arrange


            // Act
            var r0010 = new FindNumOfMomentsAllBulbsShineService().Run(new[] { 2, 1, 3, 5, 4 }, out var t0010);
            var r0020 = new FindNumOfMomentsAllBulbsShineService().Run(new[] { 2, 3, 4, 1, 5 }, out var t0020);
            var r0030 = new FindNumOfMomentsAllBulbsShineService().Run(new[] { 1, 3, 4, 2, 5 }, out var t0030);
            var r0070 = new FindNumOfMomentsAllBulbsShineService().Run(new[] { 2, 10, 4, 100 }, out var t0070);
            var r0090 = new FindNumOfMomentsAllBulbsShineService().Run(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 10 }, out var t0090);

            // Assert
            Assert.AreEqual(r0010, 3);
            Assert.AreEqual(r0020, 2);
            Assert.AreEqual(r0030, 3);
            Assert.AreEqual(r0070, 0);
            Assert.AreEqual(r0090, 8);
        }

        [TestMethod]
        public void DoRun_GivenEdgeCases_ReturnsExpectedResult()
        {
            // Arrange


            // Act
            var r0040 = new FindNumOfMomentsAllBulbsShineService().Run(new[] { 1 }, out var t0040);
            var r0050 = new FindNumOfMomentsAllBulbsShineService().Run(new[] { 100 }, out var t0050);
            var r0060 = new FindNumOfMomentsAllBulbsShineService().Run(new[] { 55 }, out var t0060);
            var r0080 = new FindNumOfMomentsAllBulbsShineService().Run(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, out var t0080);
            var r0100 = new FindNumOfMomentsAllBulbsShineService().Run(new[] { 100, 99, 98, 97, 96, 95, 94, 93, 92 }, out var t0100);

            // Assert
            Assert.AreEqual(r0040, 1);
            Assert.AreEqual(r0050, 0);
            Assert.AreEqual(r0060, 0);
            Assert.AreEqual(r0080, 9);
            Assert.AreEqual(r0100, 0);
        }
    }
}
