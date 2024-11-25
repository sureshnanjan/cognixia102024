using System;
using NUnit.Framework;
using HerokuAppOperations;

namespace HerokuAppScenarios
{
    [TestFixture]
    public class CheckBoxTest
    {
        // Test 1: Verify that the checkbox is initially unchecked
        [Test]
        public void WhenCheckboxIsCreated_StatusIsUnchecked()
        {
            // Arrange: Create a checkbox instance with an initial status of unchecked
            ICheckBox checkbox = new ICheckBox("Accept Terms and Conditions", false);

            // Act: Get the checkbox status
            bool isChecked = checkbox.GetCheckboxStatus();

            // Assert: Verify that the checkbox is initially unchecked
            Assert.IsFalse(isChecked, "Expected the checkbox to be unchecked initially.");
        }

        // Test 2: Verify that toggling the checkbox changes its status to checked
        [Test]
        public void WhenCheckboxIsToggled_StatusBecomesChecked()
        {
            // Arrange: Create a checkbox instance
            ICheckBox checkbox = new CheckBox("Accept Terms and Conditions");

            // Act: Toggle the checkbox status to checked
            checkbox.ToggleCheckboxStatus();
            bool isChecked = checkbox.GetCheckboxStatus();

            // Assert: Verify that the checkbox is checked after toggle
            Assert.IsTrue(isChecked, "Expected the checkbox to be checked after toggle.");
        }

        // Test 3: Verify that toggling the checkbox again changes its status back to unchecked
        [Test]
        public void WhenCheckboxIsToggledTwice_StatusBecomesUnchecked()
        {
            // Arrange: Create a checkbox instance
            ICheckBox checkbox = new CheckBox("Accept Terms and Conditions");

            // Act: Toggle the checkbox twice
            checkbox.ToggleCheckboxStatus();  // First toggle (checked)
            checkbox.ToggleCheckboxStatus();  // Second toggle (unchecked)
            bool isChecked = checkbox.GetCheckboxStatus();

            // Assert: Verify that the checkbox is unchecked after the second toggle
            Assert.IsFalse(isChecked, "Expected the checkbox to be unchecked after the second toggle.");
        }

        // Test 4: Verify that the checkbox title is returned correctly
        [Test]
        public void WhenCheckboxIsCreated_TitleIsCorrect()
        {
            // Arrange: Create a checkbox instance with a specific title
            ICheckBox checkbox = new CheckBox("Accept Terms and Conditions");

            // Act: Get the checkbox title
            string title = checkbox.GetTitle();

            // Assert: Verify that the title is correct
            Assert.AreEqual("Accept Terms and Conditions", title, "Expected the checkbox title to be 'Accept Terms and Conditions'.");
        }
    }
}
