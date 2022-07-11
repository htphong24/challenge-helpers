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

            // [1,7,3,3,6,5,6,3,3,7,1]
            var node0010A = new ListNode(1); // last node
            var node0010B = new ListNode(7, node0010A);
            var node0010C = new ListNode(3, node0010B);
            var node0010D = new ListNode(3, node0010C);
            var node0010E = new ListNode(6, node0010D);
            var node0010F = new ListNode(5, node0010E);
            var node0010G = new ListNode(6, node0010F);
            var node0010H = new ListNode(3, node0010G);
            var node0010I = new ListNode(3, node0010H);
            var node0010J = new ListNode(7, node0010I);
            var node0010K = new ListNode(1, node0010J);

            // [1,7,3,3,6,5,5,6,3,3,7,1]
            var node0020A = new ListNode(1); // last node
            var node0020B = new ListNode(7, node0020A);
            var node0020C = new ListNode(3, node0020B);
            var node0020D = new ListNode(3, node0020C);
            var node0020E = new ListNode(6, node0020D);
            var node0020F = new ListNode(5, node0020E);
            var node0020G = new ListNode(5, node0020F);
            var node0020H = new ListNode(6, node0020G);
            var node0020I = new ListNode(3, node0020H);
            var node0020J = new ListNode(3, node0020I);
            var node0020K = new ListNode(7, node0020J);
            var node0020L = new ListNode(1, node0020K);

            // [1,7,1]
            var node0030A = new ListNode(1); // last node
            var node0030B = new ListNode(7, node0030A);
            var node0030C = new ListNode(1, node0030B);

            // [1,7,8,1]
            var node0040A = new ListNode(1); // last node
            var node0040B = new ListNode(8, node0040A);
            var node0040C = new ListNode(7, node0040B);
            var node0040D = new ListNode(1, node0040C);

            // Act
            var r0010 = new CheckPalindromeLinkedListService().Run(new ListNode().AddNodes(new[] { 1, 7, 3, 3, 6, 5, 6, 3, 3, 7, 1 }), out var t0010);
            var r0020 = new CheckPalindromeLinkedListService().Run(new ListNode().AddNodes(new[] { 1, 7, 3, 3, 6, 5, 5, 6, 3, 3, 7, 1 }), out var t0020);
            var r0030 = new CheckPalindromeLinkedListService().Run(new ListNode().AddNodes(new[] { 1, 7, 1 }), out var t0030);
            var r0040 = new CheckPalindromeLinkedListService().Run(new ListNode().AddNodes(new[] { 1, 7, 8, 1 }), out var t0040);

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

            // [7]
            var node0050A = new ListNode(7);

            // [7,0]
            var node0060A = new ListNode(7); // last node
            var node0060B = new ListNode(0, node0060A);

            // Act
            var r0050 = new CheckPalindromeLinkedListService().Run(new ListNode().AddNodes(new[] { 7 }), out var t0050);
            var r0060 = new CheckPalindromeLinkedListService().Run(new ListNode().AddNodes(new[] { 7, 0 }), out var t0060);

            // Assert
            Assert.AreEqual(r0050, true);
            Assert.AreEqual(r0060, false);
        }
    }
}
