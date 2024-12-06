//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using HerokuAppOperations;
//using HerokuAppWebdriverAdapter;
//using OpenQA.Selenium;

//namespace HerokuAppScenarios
//{
//    public class TinyMCEEditorTest
//    {
//        //Arrange
//        ITinyMCEEditor editor;
//        [SetUp]
//        public void SetUp()
//        {
//            editor = new TinyMCEEditor();
//        }
//        [Test]
//        public void ValidateGetContainer()
//        {
//            //Act
//            String sentence=editor.GetContent();
//            //Assert
//            Assert.IsTrue(sentence.Length > 0, "There is no content");
//        }
//        [Test]
//        public void ValidateSetContainer() {
//                // Arrange
//                string expectedContent = "Hello, TinyMCE!";
//                // Act
//                editor.SetContent(expectedContent);
//                string actualContent =editor.GetContent();
//                // Assert
//                Assert.AreEqual(expectedContent, actualContent, "Content should match after being set.");
//        }
//        [Test]
//        public void ValidateClearContent()
//        {
//            // Arrange
//            editor.SetContent("Temporary content.");

//            // Act
//            editor.ClearContent();
//            string actualContent = editor.GetContent();

//            // Assert
//            Assert.AreEqual(string.Empty, actualContent, "Content should be cleared.");
//        }
//        [Test]
//        public void Test_TinyMCE_BoldAndItalicFormatting()
//        {
//            // Arrange
//            string inputText = "Test Formatting";
//            string expectedBoldItalicHtml = "<p><b><i>" + inputText + "</i></b></p>"; // Expected HTML structure

//            // Act
//            // Set content in the editor
//            editor.SetContent(inputText);

//            // Switch to the iframe containing the TinyMCE editor
//            editor.SetItalyAndBold();

//            // Retrieve the formatted content
//            string actualFormattedContent = editor.GetContent();

//            // Assert
//            Assert.AreEqual(expectedBoldItalicHtml, actualFormattedContent,
//                "Bold and italic formatting should be correctly applied to the content.");
//        }

//    }
//}
