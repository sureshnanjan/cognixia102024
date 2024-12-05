using NUnit.Framework;
using HerokuAppOperations; // Ensure IDragAndDrop is available
using HerokuAppWebdriverAdapter; // Ensure DragAndDrop class is available

namespace HerokuAppScenarios
{
    /// <summary>
    /// Test scenarios to verify the drag-and-drop functionality
    /// on the Heroku app's drag-and-drop page.
    /// </summary>
    [TestFixture]
    public class DragAndDropScenario
    {
        private IDragAndDrop _dragAndDrop; // Declare as IDragAndDrop interface

        /// <summary>
        /// Test to perform drag-and-drop operation and verify the result.
        /// </summary>
        [Test]
        public void TestDragAndDropFunctionality()
        {
            // Arrange
            _dragAndDrop = new DragAndDrop(); // Instantiate DragAndDrop through the interface

            // Act - Perform the drag-and-drop operation
            _dragAndDrop.DragAndDropElements();

            // Assert - Verify that after the drag-and-drop, the target column contains 'A'
            // and the source column contains 'B'.
            Assert.AreEqual("A", _dragAndDrop.GetTargetElementText(), "Target element should contain 'A' after drag and drop.");
            Assert.AreEqual("B", _dragAndDrop.GetSourceElementText(), "Source element should contain 'B' after drag and drop.");
        }

        /// <summary>
        /// Test to verify that column A is initially on the left (source column).
        /// </summary>
        [Test]
        public void VerifyColumnAInitialPosition()
        {
            // Arrange
            _dragAndDrop = new DragAndDrop(); // Instantiate DragAndDrop through the interface

            // Act
            string sourceText = _dragAndDrop.GetSourceElementText();

            // Assert
            Assert.AreEqual("A", sourceText, "Column A should contain 'A' initially.");
        }

        /// <summary>
        /// Test to verify that column B is initially on the right (target column).
        /// </summary>
        [Test]
        public void VerifyColumnBInitialPosition()
        {
            // Arrange
            _dragAndDrop = new DragAndDrop(); // Instantiate DragAndDrop through the interface

            // Act
            string targetText = _dragAndDrop.GetTargetElementText();

            // Assert
            Assert.AreEqual("B", targetText, "Column B should contain 'B' initially.");
        }

        /// <summary>
        /// Test to verify the initial text of both columns before performing any drag-and-drop operation.
        /// Ensures that column A contains 'A' and column B contains 'B'.
        /// </summary>
        [Test]
        public void VerifyInitialTextOfColumns()
        {
            // Arrange
            _dragAndDrop = new DragAndDrop(); // Instantiate DragAndDrop through the interface

            // Act
            string sourceText = _dragAndDrop.GetSourceElementText();
            string targetText = _dragAndDrop.GetTargetElementText();

            // Assert
            Assert.AreEqual("A", sourceText, "Column A should initially contain 'A'.");
            Assert.AreEqual("B", targetText, "Column B should initially contain 'B'.");
        }

        /// <summary>
        /// Test to verify the behavior of the columns after performing multiple drag-and-drop actions.
        /// The test ensures that the columns return to their correct positions after each action.
        /// </summary>
        [Test]
        public void VerifyColumnsAfterMultipleDragAndDrops()
        {
            // Arrange
            _dragAndDrop = new DragAndDrop(); // Instantiate DragAndDrop through the interface

            // Act - First drag-and-drop
            _dragAndDrop.DragAndDropElements();

            // Assert - After the first drag-and-drop
            Assert.AreEqual("A", _dragAndDrop.GetTargetElementText(), "Target element should contain 'A' after first drag and drop.");
            Assert.AreEqual("B", _dragAndDrop.GetSourceElementText(), "Source element should contain 'B' after first drag and drop.");

            // Act - Second drag-and-drop (reverse the operation)
            _dragAndDrop.DragAndDropElements();

            // Assert - After the second drag-and-drop
            Assert.AreEqual("A", _dragAndDrop.GetSourceElementText(), "Source element should contain 'A' after second drag and drop.");
            Assert.AreEqual("B", _dragAndDrop.GetTargetElementText(), "Target element should contain 'B' after second drag and drop.");
        }
    }
}
