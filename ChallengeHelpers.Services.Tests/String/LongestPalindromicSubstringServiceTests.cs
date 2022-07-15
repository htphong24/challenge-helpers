using ChallengeHelpers.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ChallengeHelpers.Services.Tests
{
    [TestClass]
    public class LongestPalindromicSubstringServiceTests
    {
        [TestMethod]
        public void DoRun_GivenNormalInputs_ReturnsExpectedResult()
        {
            // Arrange


            // Act
            var r0010 = new LongestPalindromicSubstringService().Run("babad", out var t0010);
            var r0020 = new LongestPalindromicSubstringService().Run("cbbd", out var t0020);
            var r0030 = new LongestPalindromicSubstringService().Run("a", out var t0030);
            var r0040 = new LongestPalindromicSubstringService().Run("bdcddce", out var t0040);
            var r0070 = new LongestPalindromicSubstringService().Run("bacdce", out var t0070);
            var r0080 = new LongestPalindromicSubstringService().Run("ecacddcaf", out var t0080);
            var r0090 = new LongestPalindromicSubstringService().Run("bacdcaf", out var t0090);
            var r0100 = new LongestPalindromicSubstringService().Run("xabcbamndedy", out var t0100);
            var r0110 = new LongestPalindromicSubstringService().Run("xabcbabcby", out var t0110);
            var r0120 = new LongestPalindromicSubstringService().Run("xabcbaabcbyz", out var t0120);

            // Assert
            Assert.AreEqual(r0010, "bab");
            Assert.AreEqual(r0020, "bb");
            Assert.AreEqual(r0030, "a");
            Assert.AreEqual(r0040, "cddc");
            Assert.AreEqual(r0070, "cdc");
            Assert.AreEqual(r0080, "acddca");
            Assert.AreEqual(r0090, "acdca");
            Assert.AreEqual(r0100, "abcba");
            Assert.AreEqual(r0110, "bcbabcb");
            Assert.AreEqual(r0120, "bcbaabcb");
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
