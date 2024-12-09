using HerokuAppOperations;
using HerokuAppWebdriverAdapter;
using NUnit.Framework;
using Assert = NUnit.Framework.Assert;
namespace HerokuAppScenarios
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void HomePageTitleisCorrect()
        {
            // AUT Application Under Test
            IHomePage page = new HomePage();
            string expected = "Welcome to the-internet no";
            string actual = page.getTitle();
            Assert.That(Is.Equals(expected, actual));
        }

        [Test]
        public void HomePageAvailableExamplesAreCorrect()
        {
            // AUT Application Under Test
            IHomePage page = new HomePage();
            int expected = 46;
            int actual = page.getAvailableExamples().Length;
            Assert.That(Is.Equals(expected, actual));
        }

        [Test]
        public void HomeAccesingExamplesWork()
        {
            Assert.Pass();
        }
    }
}