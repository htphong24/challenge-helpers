using ChallengeHelpers.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ChallengeHelpers.Services.Tests
{
    [TestClass]
    public class ValidParenthesesServiceTests
    {
        [TestMethod]
        public void DoRun_GivenNormalInputs_ReturnsExpectedResult()
        {
            // Arrange


            // Act
            var r0010 = new ValidParenthesesService().Run("()", out var t0010);
            var r0020 = new ValidParenthesesService().Run("()[]{}", out var t0020);
            var r0030 = new ValidParenthesesService().Run("(]", out var t0030);
            var r0040 = new ValidParenthesesService().Run("[", out var t0040);
            var r0070 = new ValidParenthesesService().Run("[[({[]})]]", out var t0070);
            var r0080 = new ValidParenthesesService().Run("[[({[]]})]]", out var t0080);
            var r0090 = new ValidParenthesesService().Run("[[({[})]]", out var t0090);
            var r0100 = new ValidParenthesesService().Run("([{{([", out var t0100);
            var r0110 = new ValidParenthesesService().Run("}]))}", out var t0110);
            var r0120 = new ValidParenthesesService().Run("(){}}{", out var t0120);

            // Assert
            Assert.AreEqual(r0010, true);
            Assert.AreEqual(r0020, true);
            Assert.AreEqual(r0030, false);
            Assert.AreEqual(r0040, false);
            Assert.AreEqual(r0070, true);
            Assert.AreEqual(r0080, false);
            Assert.AreEqual(r0090, false);
            Assert.AreEqual(r0100, false);
            Assert.AreEqual(r0110, false);
            Assert.AreEqual(r0120, false);
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
