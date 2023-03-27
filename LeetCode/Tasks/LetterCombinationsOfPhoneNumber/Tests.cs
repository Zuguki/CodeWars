using NUnit.Framework;

namespace LetterCombinationsOfPhoneNumber;

[TestFixture]
public class Tests
{
    [Test]
    public void Test2Letters23()
    {
        var sol = new Solution();
        var input = "23";
        var output = new List<string> {"ad", "ae", "af", "bd", "be", "bf", "cd", "ce", "cf"};
        Assert.AreEqual(output, sol.LetterCombinations(input));
    }
}