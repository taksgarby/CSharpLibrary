using Microsoft.VisualStudio.TestTools.UnitTesting;
using UtilityLibraries;
namespace StringLibraryTest;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void TestStartsWithUpper()
    {
        //Tests that are expected to return true
        string[] words = { "Alpha", "Beta", "Cigna", "Delta" };
        foreach (var word in words)
        {
            bool result = word.StartsWithUpper();
            Assert.IsTrue(result,
                string.Format("Expected for '{0}':true; Actual: {1}",
                    word, result));
        }
    }
    [TestMethod]
    public void TestDoesNotStartWithUpper()
    {
        //Tests taht are expected to return false
        string[] words = { "alpha", "beta", "cigna", "delta" };
        foreach (var word in words)
        {
            bool result = word.StartsWithUpper();
            Assert.IsFalse(result,
                string.Format("Expected for '{0}': false; Actual: {1}",
                    word, result));
        }
    }

    [TestMethod]
    public void DirectCallWithNullOrEmpty()
    {
        //Tests that are expected to return false
        string?[] words = { string.Empty, null };
        foreach (var word in words)
        {
            bool result = StringLibrary.StartsWithUpper(word);
            Assert.IsFalse(result,
                string.Format("Expected for '{0}': false; Actual: {1}",
                                 word == null ? "<null>" : word, result));

        }
    }
}