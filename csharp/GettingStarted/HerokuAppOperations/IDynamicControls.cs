// --------------------------------------------------------------------------------------------------------------------
// © [Your Company Name], [Year]. All rights reserved.
// This code is the property of [Your Company Name] and is protected by copyright law. Unauthorized reproduction or
// distribution of this code, or any portion of it, may result in civil and criminal penalties and will be prosecuted
// to the maximum extent possible under the law.
// --------------------------------------------------------------------------------------------------------------------

using System;

namespace HerokuAppWebdriverAdapter
{
    /// <summary>
    /// Interface for interacting with the Dynamic Controls page on HerokuApp.
    /// </summary>
    /// <remarks>
    /// Provides methods for performing actions such as adding/removing checkboxes, enabling/disabling textboxes, 
    /// and retrieving page information or status messages. Useful for automating tests that verify dynamic behavior.
    /// </remarks>
    public interface IDynamicControlsPage
    {
        /// <summary>
        /// Adds a checkbox to the page.
        /// </summary>
        void AddCheckbox();

        /// <summary>
        /// Removes a checkbox from the page.
        /// </summary>
        void RemoveCheckbox();

        /// <summary>
        /// Checks whether the checkbox is currently displayed on the page.
        /// </summary>
        /// <returns>True if the checkbox is displayed; otherwise, false.</returns>
        bool IsCheckboxDisplayed();

        /// <summary>
        /// Enables the input textbox on the page.
        /// </summary>
        void EnableTextbox();

        /// <summary>
        /// Disables the input textbox on the page.
        /// </summary>
        void DisableTextbox();

        /// <summary>
        /// Checks whether the input textbox is enabled.
        /// </summary>
        /// <returns>True if the textbox is enabled; otherwise, false.</returns>
        bool IsTextBoxEnabled();

        /// <summary>
        /// Retrieves the loading message displayed during operations.
        /// </summary>
        /// <returns>The text of the loading message.</returns>
        string GetLoadingMessage();

        /// <summary>
        /// Retrieves the completion message displayed after an operation is completed.
        /// </summary>
        /// <returns>The text of the completion message.</returns>
        string GetCompletionMessage();

        /// <summary>
        /// Waits until the loading message disappears.
        /// </summary>
        void WaitForLoadingToDisappear();

        /// <summary>
        /// Clicks the button to remove the checkbox.
        /// </summary>
        void ClickRemoveButton();

        /// <summary>
        /// Clicks the button to enable the input textbox.
        /// </summary>
        void ClickEnableButton();

        /// <summary>
        /// Clicks the button to disable the input textbox.
        /// </summary>
        void ClickDisableButton();

        /// <summary>
        /// Retrieves the title text (<h4>) displayed on the page.
        /// </summary>
        /// <returns>The title text.</returns>
        string GetPageTitle();

        /// <summary>
        /// Retrieves the description text (<p>) displayed on the page.
        /// </summary>
        /// <returns>The description text.</returns>
        string GetPageDescription();
    }
}
