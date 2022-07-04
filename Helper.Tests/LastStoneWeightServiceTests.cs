using HelperLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Helper.Tests
{
    [TestClass]
    public class LastStoneWeightServiceTests
    {
        [TestMethod]
        public void DoRun_GivenNormalInputs_ReturnsExpectedResult()
        {
            // Arrange


            // Act
            var r0010 = new LastStoneWeightService().Run(new[] { 2, 7, 4, 1, 8, 1 }, out var t0010);
            var r0020 = new LastStoneWeightService().Run(new[] { 10, 950, 1000, 3, 100, 1 }, out var t0020);
            var r0030 = new LastStoneWeightService().Run(new[] { 6, 38, 100, 9, 89 }, out var t0030);

            // Assert
            Assert.AreEqual(r0010, 1);
            Assert.AreEqual(r0020, 36);
            Assert.AreEqual(r0030, 12);
        }

        [TestMethod]
        public void DoRun_GivenEdgeCases_ReturnsExpectedResult()
        {
            // Arrange


            // Act
            var r0010 = new LastStoneWeightService().Run(new[] { 100 }, out var t0010);

            // Assert
            Assert.AreEqual(r0010, 100);
        }
    }
}
