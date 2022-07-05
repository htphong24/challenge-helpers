using ChallengeHelpers.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ChallengeHelpers.Tests
{
    [TestClass]
    public class CheckIfAStringContainsAllBinaryCodesServiceTests
    {
        [TestMethod]
        public void DoRun_GivenNormalInputs_ReturnsExpectedResult()
        {
            // Arrange


            // Act
            var r0010 = new CheckIfAStringContainsAllBinaryCodesService().Run(new CheckIfAStringContainsAllBinaryCodesRequest("00110110", 2), out var t0010);
            var r0020 = new CheckIfAStringContainsAllBinaryCodesService().Run(new CheckIfAStringContainsAllBinaryCodesRequest("0110", 1), out var t0020);
            var r0030 = new CheckIfAStringContainsAllBinaryCodesService().Run(new CheckIfAStringContainsAllBinaryCodesRequest("0110", 2), out var t0030);
            var r0040 = new CheckIfAStringContainsAllBinaryCodesService().Run(new CheckIfAStringContainsAllBinaryCodesRequest("00010101100111", 3), out var t0040);
            var r0050 = new CheckIfAStringContainsAllBinaryCodesService().Run(new CheckIfAStringContainsAllBinaryCodesRequest("0001010110011", 3), out var t0050);

            // Assert
            Assert.AreEqual(r0010, true);
            Assert.AreEqual(r0020, true);
            Assert.AreEqual(r0030, false);
            Assert.AreEqual(r0040, true);
            Assert.AreEqual(r0050, false);
        }

        [TestMethod]
        public void DoRun_GivenEdgeCases_ReturnsExpectedResult()
        {
            // Arrange


            // Act
            var r0010 = new CheckIfAStringContainsAllBinaryCodesService().Run(new CheckIfAStringContainsAllBinaryCodesRequest("0", 1), out var t0010);
            var r0020 = new CheckIfAStringContainsAllBinaryCodesService().Run(new CheckIfAStringContainsAllBinaryCodesRequest("1", 1), out var t0020);
            var r0030 = new CheckIfAStringContainsAllBinaryCodesService().Run(new CheckIfAStringContainsAllBinaryCodesRequest("0", 2), out var t0030);
            var r0040 = new CheckIfAStringContainsAllBinaryCodesService().Run(new CheckIfAStringContainsAllBinaryCodesRequest("1", 2), out var t0040);
            var r0050 = new CheckIfAStringContainsAllBinaryCodesService().Run(new CheckIfAStringContainsAllBinaryCodesRequest("0001110111010010011010100000111110101111010110101111111101111110000000100010110111111111010011000111111000010011110100010010000001010011111000010001101100110000110011001110111001001011101111001011001010001101010100000001111000011000101101110011000010100010011001001111000100110001100100101011011001000110101110101101010001011001101001010000101000101010111101111101001011101011001111010101010111011000101000100000100111001110110011010001110001000111000101010010101101001110100100010001101001100011001010111101001011111111000110110000011110111100100001110111110010111101101011101000001001010011100101110111001111010010101100000001111100101000001011010001111111100011011100011101000100010100101011011011101001110111101100000000111110101110011011010100", 16), out var t0050);

            // Assert
            Assert.AreEqual(r0010, false);
            Assert.AreEqual(r0020, false);
            Assert.AreEqual(r0030, false);
            Assert.AreEqual(r0040, false);
            Assert.AreEqual(r0050, false);
        }
    }
}
