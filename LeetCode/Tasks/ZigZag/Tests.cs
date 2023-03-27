using NUnit.Framework;

namespace Tasks;

[TestFixture]
public class Tests
{
    [Test]
    public void Test1Convert()
    {
        var solution = new Solution();
        var result = solution.Convert("A", 1);
        Assert.AreEqual("A", result);
    }
    
    [Test]
    public void Test2ConvertWith1Letters()
    {
        var solution = new Solution();
        var result = solution.Convert("A", 2);
        Assert.AreEqual("A", result);
    }
    
    [Test]
    public void Test3ConvertWith2Letters()
    {
        var solution = new Solution();
        var result = solution.Convert("AB", 3);
        Assert.AreEqual("AB", result);
    }

    [Test]
    public void Test3Convert()
    {
        var solution = new Solution();
        var testString = "PAYPALISHIRING";
        var result = solution.Convert(testString, 3);
        Assert.AreEqual("PAHNAPLSIIGYIR", result);
    }

    [Test]
    public void Test4Convert()
    {
        var solution = new Solution();
        var testString = "PAYPALISHIRING";
        var result = solution.Convert(testString, 4);
        Assert.AreEqual("PINALSIGYAHRPI", result);
    }

    [Test]
    public void Test5Convert()
    {
        var solution = new Solution();
        var testString = "PAYPALISHIRING";
        var result = solution.Convert(testString, 5);
        Assert.AreEqual("PHASIYIRPLIGAN", result);
    }
    
    [Test]
    public void Test1ConvertWith2Letters()
    {
        var solution = new Solution();
        var result = solution.Convert("AB", 1);
        Assert.AreEqual("AB", result);
    }
    
    [Test]
    public void Test2ConvertWith3Letters()
    {
        var solution = new Solution();
        var result = solution.Convert("ABC", 2);
        Assert.AreEqual("ACB", result);
    }
    
    [Test]
    public void Test2ConvertWith4Letters()
    {
        var solution = new Solution();
        var result = solution.Convert("ABCD", 2);
        Assert.AreEqual("ACBD", result);
    }
}