// --------------------------------------------------------------------------------------------------------------------
// © [Your Company Name], [Year]. All rights reserved.
// This code is the property of [Your Company Name] and is protected by copyright law. Unauthorized reproduction or
// distribution of this code, or any portion of it, may result in civil and criminal penalties and will be prosecuted
// to the maximum extent possible under the law.
// --------------------------------------------------------------------------------------------------------------------
using System;

namespace HerokuAppWebdriverAdapter
{
    public interface IDynamicLoadingPage
    {
        // Navigate to the dynamic loading page
        void NavigateToPage(string url);

        // Click the Start button
        void ClickStartButton();

        // Check if the loading indicator is displayed
        bool IsLoadingIndicatorDisplayed();

        // Wait for the loading to complete
        void WaitForLoadingToComplete();

        // Check if the dynamically loaded element is displayed
        bool IsDynamicallyLoadedElementDisplayed();

        // Get the text of the dynamically loaded element
        string GetLoadedElementText();

        // Validate if a given element is displayed on the page
        bool IsElementDisplayed(string locator);

        // Get the <h4> text
        string GetSubHeaderText();

        // Get the count of hyperlink options
        int GetHyperlinkCount();

        // Get the list of hyperlink texts
        IList<string> GetHyperlinkTexts();

        // Get the list of hyperlink URLs
        IList<string> GetHyperlinkUrls();
    }
}

