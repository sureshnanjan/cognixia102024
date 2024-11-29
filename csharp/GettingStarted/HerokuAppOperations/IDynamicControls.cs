// --------------------------------------------------------------------------------------------------------------------
// © [Your Company Name], [Year]. All rights reserved.
// This code is the property of [Your Company Name] and is protected by copyright law. Unauthorized reproduction or
// distribution of this code, or any portion of it, may result in civil and criminal penalties and will be prosecuted
// to the maximum extent possible under the law.
// --------------------------------------------------------------------------------------------------------------------

using System;

namespace HerokuAppWebdriverAdapter
{
    public interface IDynamicControlsPage
    {
        // Adds a checkbox to the page
        void AddCheckbox();

        // Removes a checkbox from the page
        void RemoveCheckbox();

        // Checks if the checkbox is displayed
        bool IsCheckboxDisplayed();

        // Enables the input textbox
        void EnableTextbox();

        // Disables the input textbox
        void DisableTextbox();

        // Checks if the textbox is enabled
        bool IsTextBoxEnabled();

        // Retrieves the loading message during operations
        string GetLoadingMessage();

        // Retrieves the completion message after the operation
        string GetCompletionMessage();

        // Method to wait for the loading message to disappear
        void WaitForLoadingToDisappear();

        // **New method to handle clicking the remove button**
        void ClickRemoveButton();

        // Method to handle clicking the enable button
        void ClickEnableButton();

        // Method to handle clicking the disable button
        void ClickDisableButton();


    }
}
