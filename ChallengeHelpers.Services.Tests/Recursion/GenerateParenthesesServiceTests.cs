using ChallengeHelpers.Services;
using ChallengeHelpers.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ChallengeHelpers.Services.Tests
{
    [TestClass]
    public class GenerateParenthesesServiceTests
    {
        [TestMethod]
        public void DoRun_GivenNormalInputs_ReturnsExpectedResult()
        {
            // Arrange


            // Act
            var r0010 = new GenerateParenthesesService().Run(1, out var t0010);
            var r0020 = new GenerateParenthesesService().Run(2, out var t0020);
            var r0030 = new GenerateParenthesesService().Run(3, out var t0030);

            // Assert
            Assert.AreEqual(r0010.ConvertToString(), "()");
            Assert.AreEqual(r0020.ConvertToString(), "(()),()()");
            Assert.AreEqual(r0030.ConvertToString(), "((())),(()()),(())(),()(()),()()()");
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
