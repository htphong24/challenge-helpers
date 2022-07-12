using ChallengeHelpers.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace ChallengeHelpers.Tests
{
    [TestClass]
    public class CheckPalindromeLinkedListServiceTests
    {
        [TestMethod]
        public void DoRun_GivenNormalInputs_ReturnsExpectedResult()
        {
            // Arrange
            var node0010 = new ListNode().AddNodes(new[] { 1, 7, 3, 3, 6, 5, 6, 3, 3, 7, 1 });
            var node0020 = new ListNode().AddNodes(new[] { 1, 7, 3, 3, 6, 5, 5, 6, 3, 3, 7, 1 });
            var node0030 = new ListNode().AddNodes(new[] { 1, 7, 1 });
            var node0040 = new ListNode().AddNodes(new[] { 1, 7, 8, 1 });

            // Act
            var r0010 = new CheckPalindromeLinkedListService().Run(node0010, out var t0010);
            var r0020 = new CheckPalindromeLinkedListService().Run(node0020, out var t0020);
            var r0030 = new CheckPalindromeLinkedListService().Run(node0030, out var t0030);
            var r0040 = new CheckPalindromeLinkedListService().Run(node0040, out var t0040);

            // Assert
            Assert.AreEqual(r0010, true);
            Assert.AreEqual(r0020, true);
            Assert.AreEqual(r0030, true);
            Assert.AreEqual(r0040, false);
        }

        [TestMethod]
        public void DoRun_GivenEdgeCases_ReturnsExpectedResult()
        {
            // Arrange
            var node0050 = new ListNode().AddNodes(new[] { 7 });
            var node0060 = new ListNode().AddNodes(new[] { 7, 0 });

            // Act
            var r0050 = new CheckPalindromeLinkedListService().Run(node0050, out var t0050);
            var r0060 = new CheckPalindromeLinkedListService().Run(node0060, out var t0060);

            // Assert
            Assert.AreEqual(r0050, true);
            Assert.AreEqual(r0060, false);
        }
    }
}
