using ChallengeHelpers.Common;
using ChallengeHelpers.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace ChallengeHelpers.Services.Tests
{
    [TestClass]
    public class MiddleOfTheLinkedListServiceTests
    {
        [TestMethod]
        public void DoRun_GivenNormalInputs_ReturnsExpectedResult()
        {
            // Arrange
            var node0010 = new ListNode().AddNodes(new[] { 1, 2, 3, 4, 5 });
            var node0020 = new ListNode().AddNodes(new[] { 1, 2, 3, 4, 5, 6 });

            // Act
            var r0010 = new MiddleOfTheLinkedListService().Run(node0010, out var t0010);
            var r0020 = new MiddleOfTheLinkedListService().Run(node0020, out var t0020);

            // Assert
            Assert.AreEqual(r0010.ConvertToString(), "345");
            Assert.AreEqual(r0020.ConvertToString(), "456");
        }

        [TestMethod]
        public void DoRun_GivenEdgeCases_ReturnsExpectedResult()
        {
            // Arrange
            var node0030 = new ListNode().AddNodes(new[] { 1 });
            var node0040 = new ListNode().AddNodes(new[] { 1, 2 });

            // Act
            var r0030 = new MiddleOfTheLinkedListService().Run(node0030, out var t0030);
            var r0040 = new MiddleOfTheLinkedListService().Run(node0040, out var t0040);

            // Assert
            Assert.AreEqual(r0030.ConvertToString(), "1");
            Assert.AreEqual(r0040.ConvertToString(), "2");
        }
    }
}
