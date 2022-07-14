using ChallengeHelpers.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ChallengeHelpers.Services.Tests
{
    [TestClass]
    public class RansomNoteServiceTests
    {
        [TestMethod]
        public void DoRun_GivenNormalInputs_ReturnsExpectedResult()
        {
            // Arrange
            var rq0010 = new RansomNoteRequest("a", "b");
            var rq0020 = new RansomNoteRequest("aa", "ab");
            var rq0030 = new RansomNoteRequest("aa", "aab");
            var rq0040 = new RansomNoteRequest("thanh", "xytbhbattanzhanc");
            var rq0050 = new RansomNoteRequest("thanh", "xytbhbattazhac");
            var rq0060 = new RansomNoteRequest("thanh", "xybthanhzc");
            var rq0070 = new RansomNoteRequest("aa", "a");
            var rq0080 = new RansomNoteRequest("thanhphong", "thanhphong");
            var rq0090 = new RansomNoteRequest("thanhphong", "thanhphon");
            var rq0100 = new RansomNoteRequest("thanhphong", "o");

            // Act
            var r0010 = new RansomNoteService().Run(rq0010, out var t0010);
            var r0020 = new RansomNoteService().Run(rq0020, out var t0020);
            var r0030 = new RansomNoteService().Run(rq0030, out var t0030);
            var r0040 = new RansomNoteService().Run(rq0040, out var t0040);
            var r0050 = new RansomNoteService().Run(rq0050, out var t0050);
            var r0060 = new RansomNoteService().Run(rq0060, out var t0060);
            var r0070 = new RansomNoteService().Run(rq0070, out var t0070);
            var r0080 = new RansomNoteService().Run(rq0080, out var t0080);
            var r0090 = new RansomNoteService().Run(rq0090, out var t0090);
            var r0100 = new RansomNoteService().Run(rq0100, out var t0100);

            // Assert
            Assert.AreEqual(r0010, false);
            Assert.AreEqual(r0020, false);
            Assert.AreEqual(r0030, true);
            Assert.AreEqual(r0040, true);
            Assert.AreEqual(r0050, false);
            Assert.AreEqual(r0060, true);
            Assert.AreEqual(r0070, false);
            Assert.AreEqual(r0080, true);
            Assert.AreEqual(r0090, false);
            Assert.AreEqual(r0100, false);
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
