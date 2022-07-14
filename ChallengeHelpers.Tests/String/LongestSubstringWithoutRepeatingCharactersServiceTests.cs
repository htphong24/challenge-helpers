using ChallengeHelpers.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ChallengeHelpers.Tests
{
    [TestClass]
    public class LongestSubstringWithoutRepeatingCharactersServiceTests
    {
        [TestMethod]
        public void DoRun_GivenNormalInputs_ReturnsExpectedResult()
        {
            // Arrange


            // Act
            var r0010 = new LongestSubstringWithoutRepeatingCharactersService().Run("abcabcbb", out var t0010);
            var r0020 = new LongestSubstringWithoutRepeatingCharactersService().Run("bbbbbb", out var t0020);
            var r0030 = new LongestSubstringWithoutRepeatingCharactersService().Run("pwwkew", out var t0030);
            var r0040 = new LongestSubstringWithoutRepeatingCharactersService().Run("abcabcbbbdef", out var t0040);
            var r0070 = new LongestSubstringWithoutRepeatingCharactersService().Run("abcabcbbe", out var t0070);
            var r0080 = new LongestSubstringWithoutRepeatingCharactersService().Run("abcabcbbbd", out var t0080);
            var r0090 = new LongestSubstringWithoutRepeatingCharactersService().Run("abcabcbbbdef", out var t0090);
            var r0100 = new LongestSubstringWithoutRepeatingCharactersService().Run("ab", out var t0100);
            var r0110 = new LongestSubstringWithoutRepeatingCharactersService().Run("dvdf", out var t0110);

            // Assert
            Assert.AreEqual(r0010, 3);
            Assert.AreEqual(r0020, 1);
            Assert.AreEqual(r0030, 3);
            Assert.AreEqual(r0040, 4);
            Assert.AreEqual(r0070, 3);
            Assert.AreEqual(r0080, 3);
            Assert.AreEqual(r0090, 4);
            Assert.AreEqual(r0100, 2);
            Assert.AreEqual(r0110, 3);
        }

        [TestMethod]
        public void DoRun_GivenEdgeCases_ReturnsExpectedResult()
        {
            // Arrange


            // Act
            var r0050 = new LongestSubstringWithoutRepeatingCharactersService().Run("a", out var t0050);
            var r0060 = new LongestSubstringWithoutRepeatingCharactersService().Run("", out var t0060);

            // Assert
            Assert.AreEqual(r0050, 1);
            Assert.AreEqual(r0060, 0);
        }
    }
}
