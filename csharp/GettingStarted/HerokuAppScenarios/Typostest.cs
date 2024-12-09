using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using HerokuAppWebdriverAdapter;
using HerokuAppOperations;
using HerokuAppWebdriverAdapter;

namespace HerokuAppWebdriverTests
{
    [TestFixture]
    public class TyposTests
    {
        Typos typ;

        [SetUp]
        public void SetUp()
        {
            typ = new Typos();
        }

        [Test]
        public void TestPageHeader()
        {
            // Retrieve the header text
            string headerText = typ.GetPageHeader();

            // Verify the header text
            Assert.AreEqual("Typos", headerText, "The page header does not match the expected text.");
        }

        [Test]
        public void TestPageContent()
        {
            // Retrieve the content text
            string contentText = typ.GetPageContent();
            Console.WriteLine(contentText);
            // Check if content contains a sentence with or without typos
            bool val1=contentText.Equals("Sometimes you'll see a typo, other times you won't.");
            bool val2=contentText.Equals("Sometimes you'll see a typo, other times you won,t.");
            //StringAssert.Contains(, contentText, "The content does not match the expected text.");
            Assert.IsTrue(val1||val2);
        }

        [Test]
        public void TestPageRefresh()
        {
            // Retrieve initial content text
            string initialContent = typ.GetPageContent();

            // Retry refresh if content doesn't change
            for (int i = 0; i < 3; i++) // Retry up to 3 times
            {
                typ.RefreshPage();
                string refreshedContent = typ.GetPageContent();

                if (!initialContent.Equals(refreshedContent))
                {
                    Assert.Pass("Content changed after refresh as expected.");
                    return;
                }
            }

            Assert.Fail("Content did not change after multiple refresh attempts.");
        }

        [TearDown]
        public void TearDown()
        {
           
            
                typ.QuitDriver(); 
            
        }

    }
}
