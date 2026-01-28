[TestClass]
public class TextUtilitiesTests
{
    private TextUtilities utils;

    [TestInitialize]
    public void Init()
    {
        utils = new TextUtilities();
    }

    [TestMethod]
    public void Reverse_WorksCorrectly()
    {
        Assert.AreEqual("tahC", utils.Reverse("Chat"));
    }

    [TestMethod]
    public void IsPalindrome_ReturnsTrue()
    {
        Assert.IsTrue(utils.IsPalindrome("madam"));
    }

    [TestMethod]
    public void ToUpperCase_ReturnsUpperString()
    {
        Assert.AreEqual("HELLO", utils.ToUpperCase("hello"));
    }
}