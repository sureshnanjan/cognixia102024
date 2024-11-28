using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HerokuAppWebdriverAdapter;

namespace HerokuAppScenarios
{
    public class TinyMCEEditorTest
    {
        TinyMCEEditor editor;
        [SetUp]
        public void SetUp()
        {
            editor = new TinyMCEEditor();
        }
        [Test]
        public void ValidateGetContainer()
        {
            //Arrange

            //Act
            String sentence=editor.GetContent();
            //Assert
            Assert.IsTrue(sentence.Length > 0, "There is no content");
        }
    }
}
