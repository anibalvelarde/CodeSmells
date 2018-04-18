using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Code.Smells.Lib.Tests
{
    [TestClass]
    public class DirtyCodeVsCleanCodeTests
    {
        [TestMethod]
        public void Should_HaveSameOutcome_When_RunningDirtyOrCleanCode()
        {
            // Arrange...
            var instanceUnderTest = new Code.Smells.Lib.Examples.DirtyCodeVsCleanCode();

            // Act...
            var dirtyCodeOutcome = instanceUnderTest.DirtyCodeExample();
            var cleanCodeOutcome = instanceUnderTest.CleanCodeExample();

            // Assert...
            Assert.AreEqual(dirtyCodeOutcome, cleanCodeOutcome);
        }
    }
}
