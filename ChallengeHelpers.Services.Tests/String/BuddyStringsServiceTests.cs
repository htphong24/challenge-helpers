using ChallengeHelpers.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ChallengeHelpers.Services.Tests
{
    [TestClass]
    public class BuddyStringsServiceTests
    {
        [TestMethod]
        public void DoRun_GivenNormalInputs_ReturnsExpectedResult()
        {
            // Arrange


            // Act
            var r0010 = new BuddyStringsService().Run(new BuddyStringsRequest("ab", "ba"), out var t0010);
            var r0020 = new BuddyStringsService().Run(new BuddyStringsRequest("ab", "ab"), out var t0020);
            var r0030 = new BuddyStringsService().Run(new BuddyStringsRequest("phongho", "phongho"), out var t0030);
            var r0040 = new BuddyStringsService().Run(new BuddyStringsRequest("ngocmai", "ngocmai"), out var t0040);
            var r0050 = new BuddyStringsService().Run(new BuddyStringsRequest("ngocmai", "ngacmoi"), out var t0050);
            var r0060 = new BuddyStringsService().Run(new BuddyStringsRequest("abcd", "badc"), out var t0060);
            var r0070 = new BuddyStringsService().Run(new BuddyStringsRequest("ab", "babbb"), out var t0070);

            // Assert
            Assert.AreEqual(r0010, true);
            Assert.AreEqual(r0020, false);
            Assert.AreEqual(r0030, true);
            Assert.AreEqual(r0040, false);
            Assert.AreEqual(r0050, true);
            Assert.AreEqual(r0060, false);
            Assert.AreEqual(r0070, false);
        }

        [TestMethod]
        public void DoRun_GivenEdgeCases_ReturnsExpectedResult()
        {
            // Arrange


            // Act
            var r0010 = new BuddyStringsService().Run(new BuddyStringsRequest("a", "x"), out var t0010);
            var r0020 = new BuddyStringsService().Run(new BuddyStringsRequest("a", "a"), out var t0020);
            var r0030 = new BuddyStringsService().Run(new BuddyStringsRequest("aaaaaa", "aaaaaa"), out var t0030);

            // Assert
            Assert.AreEqual(r0010, false);
            Assert.AreEqual(r0020, false);
            Assert.AreEqual(r0030, true);
        }
    }
}
