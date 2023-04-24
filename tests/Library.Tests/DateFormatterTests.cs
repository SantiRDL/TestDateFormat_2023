using NUnit.Framework;
using TestDateFormat;


namespace Library.Tests;

public class DateFormattersTests
{
    [SetUp]
    public void Setup()
    {
    }


    [Test]
    public void TestCorrect()
    {
        
        string input = "10/11/1997";
        string expected = "1997-11-10";
        
        string actual = DateFormatter.ChangeFormat(input);

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void TestTooLong()
    {
        
        string input = "10/11/19977";
        string expected = "";
        
        string actual = DateFormatter.ChangeFormat(input);

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void TestTooShort()
    {
        
        string input = "10/11/199";
        string expected = "";
        
        string actual = DateFormatter.ChangeFormat(input);

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void TestEmpty()
    {
        
        string input = "";
        string expected = "";
        
        string actual = DateFormatter.ChangeFormat(input);

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void TestNotNumbers()
    {
        
        string input = "10/11/YYYY";
        string expected = "";
        
        string actual = DateFormatter.ChangeFormat(input);

        Assert.That(actual, Is.EqualTo(expected));
    }
}