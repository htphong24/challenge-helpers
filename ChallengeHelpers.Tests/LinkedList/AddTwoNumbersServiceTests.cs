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
            var rq0030 = new AddTwoNumbersRequest(
                new ListNode().AddNodes(new[] { 9, 9, 9, 9, 9, 9, 9 }),
                new ListNode().AddNodes(new[] { 9, 9, 9, 9 })
            );
            var rq0040 = new AddTwoNumbersRequest(
                new ListNode().AddNodes(new[] { 2, 4, 9 }),
                new ListNode().AddNodes(new[] { 5, 6, 4, 9 })
            );

            // Act
            var r0010 = new AddTwoNumbersService().Run(rq0010, out var t0010);
            var r0030 = new AddTwoNumbersService().Run(rq0030, out var t0030);
            var r0040 = new AddTwoNumbersService().Run(rq0040, out var t0040);

            // Assert
            Assert.AreEqual(r0010.ConvertToString(), "708");
            Assert.AreEqual(r0030.ConvertToString(), "89990001");
            Assert.AreEqual(r0040.ConvertToString(), "70401");
        }

        [TestMethod]
        public void DoRun_GivenEdgeCases_ReturnsExpectedResult()
        {
            // Arrange
            var rq0020 = new AddTwoNumbersRequest(
                new ListNode().AddNodes(new[] { 0 }),
                new ListNode().AddNodes(new[] { 0 })
            );
            var rq0050 = new AddTwoNumbersRequest(
                new ListNode().AddNodes(new[] { 9 }),
                new ListNode().AddNodes(new[] { 1, 9, 9, 9, 9, 9, 9, 9, 9, 9 })
            );

            // Act
            var r0020 = new AddTwoNumbersService().Run(rq0020, out var t0020);
            var r0050 = new AddTwoNumbersService().Run(rq0050, out var t0050);

            // Assert
            Assert.AreEqual(r0020.ConvertToString(), "0");
            Assert.AreEqual(r0050.ConvertToString(), "00000000001");
        }
    }
}
