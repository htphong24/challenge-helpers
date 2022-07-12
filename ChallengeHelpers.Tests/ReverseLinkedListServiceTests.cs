using ChallengeHelpers.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace ChallengeHelpers.Tests
{
    [TestClass]
    public class ReverseLinkedListServiceTests
    {
        [TestMethod]
        public void DoRun_GivenNormalInputs_ReturnsExpectedResult()
        {
            // Arrange
            var node0010 = new ListNode().AddNodes(new[] { 1, 2, 3, 4, 5 });
            var node0020 = new ListNode().AddNodes(new[] { 1, 2 });

            // Act
            var r0010 = new ReverseLinkedListService().Run(node0010, out var t0010);
            var r0020 = new ReverseLinkedListService().Run(node0020, out var t0020);

            // Assert
            Assert.AreEqual(r0010.ConvertToString(), "54321");
            Assert.AreEqual(r0020.ConvertToString(), "21");
        }

        [TestMethod]
        public void DoRun_GivenEdgeCases_ReturnsExpectedResult()
        {
            // Arrange
            var node0040 = new ListNode().AddNodes(new[] { 1, 1, 1, 1, 1 });
            var node0050 = new ListNode().AddNodes(new[] { 1 });

            // Act
            var r0040 = new ReverseLinkedListService().Run(node0040, out var t0040);
            var r0050 = new ReverseLinkedListService().Run(node0050, out var t0050);
            var r0030 = new ReverseLinkedListService().Run(null, out var t0030);

            // Assert
            Assert.IsNull(r0030);
            Assert.AreEqual(r0040.ConvertToString(), "11111");
            Assert.AreEqual(r0050.ConvertToString(), "1");
        }
    }
}
