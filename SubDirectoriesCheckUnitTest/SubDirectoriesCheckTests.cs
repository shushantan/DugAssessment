using Microsoft.VisualStudio.TestTools.UnitTesting;
using SubDirectoriesCheck;
using System.Collections.Generic;
using System;


namespace SubDirectoriesCheckUnitTest
{
    [TestClass]
    public class SubDirectoriesCheckTests
    {
        private static IEnumerable<object[]> ListOfTestCases =>
            new List<object[]>
            {
                new object[] { "/", "/", true },
                new object[] { "/a", "/a", true },
                new object[] { "/a", "/A", false },
                new object[] { "/a", "/b", false},
                new object[] { "/@directory", "/@directory", true},
                new object[] { "/my folder", "/my folder", true},
                new object[] { "/a/b/c", "/c", true},
                new object[] { "/a/b/c", "/b", true},
                new object[] { "/a/b/c", "/B", false},
                new object[] { "/a/b/c", "/", false},
                new object[] { "/a", "/a/b", true},
                new object[] { "/a", "/b", false},
                new object[] { "/ab", "/cd", false},
                new object[] { "/abcd", "/", false },
                new object[] { "/", "/a/b/c/d/e/f/g/h/i/j/k/l/m/n/o/p/q/r/s/t/u/v/", true},

            };

        [DataTestMethod]
        [DynamicData(nameof(ListOfTestCases))]
        public void verifyLogicIsCorrect(string s1, string s2, bool expectedResult)
        {
            var result = Program.IsSubDirectories(s1,s2);
            Assert.AreEqual(result, expectedResult);

        } 
    }
}
