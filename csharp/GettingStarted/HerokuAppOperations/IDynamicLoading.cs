// --------------------------------------------------------------------------------------------------------------------
// © [Your Company Name], [Year]. All rights reserved.
// This code is the property of [Your Company Name] and is protected by copyright law. Unauthorized reproduction or
// distribution of this code, or any portion of it, may result in civil and criminal penalties and will be prosecuted
// to the maximum extent possible under the law.
// --------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

namespace HerokuAppWebdriverAdapter
{
    /// <summary>
    /// Interface for interacting with the Dynamic Loading page on HerokuApp.
    /// </summary>
    /// <remarks>
    /// Provides methods for navigating the page, interacting with dynamically loaded elements,
    /// verifying content, and retrieving link details.
    /// </remarks>
    public interface IDynamicLoadingPage
    {
        /// <summary>
        /// Navigates to the specified dynamic loading page URL.
        /// </summary>
        /// <param name="url">The URL of the dynamic loading page.</param>
        void NavigateToPage(string url);

        /// <summary>
        /// Clicks the "Start" button to initiate dynamic content loading.
        /// </summary>
        void ClickStartButton();

        /// <summary>
        /// Checks whether the loading indicator is currently displayed.
        /// </summary>
        /// <returns>True if the loading indicator is displayed; otherwise, false.</returns>
        bool IsLoadingIndicatorDisplayed();

        /// <summary>
        /// Waits for the loading process to complete and for the loading indicator to disappear.
        /// </summary>
        void WaitForLoadingToComplete();

        /// <summary>
        /// Checks whether the dynamically loaded element is currently displayed on the page.
        /// </summary>
        /// <returns>True if the element is displayed; otherwise, false.</returns>
        bool IsDynamicallyLoadedElementDisplayed();

        /// <summary>
        /// Retrieves the text content of the dynamically loaded element.
        /// </summary>
        /// <returns>The text of the loaded element.</returns>
        string GetLoadedElementText();

        /// <summary>
        /// Checks whether a specific element, identified by its locator, is displayed on the page.
        /// </summary>
        /// <param name="locator">The CSS selector or locator for the element.</param>
        /// <returns>True if the element is displayed; otherwise, false.</returns>
        bool IsElementDisplayed(string locator);

        /// <summary>
        /// Retrieves the sub-header text (<h4>) displayed on the page.
        /// </summary>
        /// <returns>The sub-header text.</returns>
        string GetSubHeaderText();

        /// <summary>
        /// Gets the total count of hyperlinks available on the page.
        /// </summary>
        /// <returns>The number of hyperlinks.</returns>
        int GetHyperlinkCount();

        /// <summary>
        /// Retrieves the text of all hyperlinks available on the page.
        /// </summary>
        /// <returns>A list of hyperlink texts.</returns>
        IList<string> GetHyperlinkTexts();

        /// <summary>
        /// Retrieves the URLs of all hyperlinks available on the page.
        /// </summary>
        /// <returns>A list of hyperlink URLs.</returns>
        IList<string> GetHyperlinkUrls();
    }
}
