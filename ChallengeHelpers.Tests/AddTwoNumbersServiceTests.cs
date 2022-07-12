using ChallengeHelpers.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace ChallengeHelpers.Tests
{
    [TestClass]
    public class AddTwoNumbersServiceTests
    {
        [TestMethod]
        public void DoRun_GivenNormalInputs_ReturnsExpectedResult()
        {
            // Arrange
            var rq0010 = new AddTwoNumbersRequest(
                new ListNode().AddNodes(new[] { 2, 4, 3 }),
                new ListNode().AddNodes(new[] { 5, 6, 4 })
            );
            var rq0020 = new AddTwoNumbersRequest(
                new ListNode().AddNodes(new[] { 0 }),
                new ListNode().AddNodes(new[] { 0 })
            );
            var rq0030 = new AddTwoNumbersRequest(
                new ListNode().AddNodes(new[] { 9, 9, 9, 9, 9, 9, 9 }),
                new ListNode().AddNodes(new[] { 9, 9, 9, 9 })
            );
            var rq0040 = new AddTwoNumbersRequest(
                new ListNode().AddNodes(new[] { 2, 4, 9 }),
                new ListNode().AddNodes(new[] { 5, 6, 4, 9 })
            );
            var rq0050 = new AddTwoNumbersRequest(
                new ListNode().AddNodes(new[] { 9 }),
                new ListNode().AddNodes(new[] { 1, 9, 9, 9, 9, 9, 9, 9, 9, 9 })
            );

            // Act
            var r0010 = new AddTwoNumbersService().Run(rq0010, out var t0010);
            var r0020 = new AddTwoNumbersService().Run(rq0020, out var t0020);
            var r0030 = new AddTwoNumbersService().Run(rq0030, out var t0030);
            var r0040 = new AddTwoNumbersService().Run(rq0040, out var t0040);
            var r0050 = new AddTwoNumbersService().Run(rq0050, out var t0050);

            // Assert
            Assert.AreEqual(ConvertLinkedListToString(r0010), "708");
            Assert.AreEqual(ConvertLinkedListToString(r0020), "0");
            Assert.AreEqual(ConvertLinkedListToString(r0030), "89990001");
            Assert.AreEqual(ConvertLinkedListToString(r0040), "70401");
            Assert.AreEqual(ConvertLinkedListToString(r0050), "00000000001");
        }

        [TestMethod]
        public void DoRun_GivenEdgeCases_ReturnsExpectedResult()
        {
            // Arrange

            // Act

            // Assert
        }

        private string ConvertLinkedListToString(ListNode head)
        {
            var result = head.val.ToString();

            var nextNode = head;
            while (nextNode.next != null)
            {
                // Move to next node
                nextNode = nextNode.next;
                result += nextNode.val;
            }

            return result;
        }
    }
}
