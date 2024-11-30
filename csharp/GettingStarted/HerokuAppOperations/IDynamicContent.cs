// --------------------------------------------------------------------------------------------------------------------
// © [Your Company Name], [Year]. All rights reserved.
// This code is the property of [Your Company Name] and is protected by copyright law. Unauthorized reproduction or
// distribution of this code, or any portion of it, may result in civil and criminal penalties and will be prosecuted
// to the maximum extent possible under the law.
// --------------------------------------------------------------------------------------------------------------------

using System;

namespace HerokuAppOperations
{
    /// <summary>
    /// Interface for interacting with dynamic content on the HerokuApp.
    /// </summary>
    /// <remarks>
    /// Provides methods for retrieving text content and image source URLs 
    /// from specific dynamic content blocks. These operations are intended 
    /// for validating content that changes dynamically during page interactions.
    /// </remarks>
    public interface IDynamicContent
    {
        /// <summary>
        /// Retrieves the text content of the first dynamic content block.
        /// This is used to extract the content from the first column of dynamic elements.
        /// </summary>
        /// <returns>The text of the first content block.</returns>
        string GetFirstContentText();

        /// <summary>
        /// Retrieves the text content of the second dynamic content block.
        /// This is used to extract the content from the second column of dynamic elements.
        /// </summary>
        /// <returns>The text of the second content block.</returns>
        string GetSecondContentText();

        /// <summary>
        /// Retrieves the text content of the third dynamic content block.
        /// This is used to extract the content from the third column of dynamic elements.
        /// </summary>
        /// <returns>The text of the third content block.</returns>
        string GetThirdContentText();

        /// <summary>
        /// Retrieves the source URL of the image in the first dynamic content block.
        /// This method is used to get the image URL from the first dynamic element (image) on the page.
        /// </summary>
        /// <returns>The source URL of the first image.</returns>
        string GetFirstImageSrc();

        /// <summary>
        /// Retrieves the source URL of the image in the second dynamic content block.
        /// This method is used to get the image URL from the second dynamic element (image) on the page.
        /// </summary>
        /// <returns>The source URL of the second image.</returns>
        string GetSecondImageSrc();

        /// <summary>
        /// Retrieves the source URL of the image in the third dynamic content block.
        /// This method is used to get the image URL from the third dynamic element (image) on the page.
        /// </summary>
        /// <returns>The source URL of the third image.</returns>
        string GetThirdImageSrc();

        /// <summary>
        /// Navigates to a specific page using the provided URL.
        /// This method is used to navigate to the dynamic content page or other pages.
        /// </summary>
        /// <param name="url">The URL to navigate to.</param>
        void NavigateToPage(string url);

        /// <summary>
        /// Retrieves the text of the <h3> header on the page.
        /// This header is typically used to identify the section of dynamic content.
        /// </summary>
        /// <returns>The text of the <h3> header.</returns>
        string GetHeaderText();

        /// <summary>
        /// Retrieves the text content of the first <p> tag.
        /// This is used to extract the first paragraph on the page, which often contains descriptive text.
        /// </summary>
        /// <returns>The text of the first <p> tag.</returns>
        string GetFirstParagraphText();

        /// <summary>
        /// Retrieves the text content of the second <p> tag.
        /// This is used to extract the second paragraph, which often contains additional descriptions or instructions.
        /// </summary>
        /// <returns>The text of the second <p> tag.</returns>
        string GetSecondParagraphText();

        /// <summary>
        /// Retrieves all hyperlink texts on the page.
        /// This method is used to gather all the clickable text from <a> tags across the page.
        /// </summary>
        /// <returns>A list of hyperlink texts found on the page.</returns>
        IList<string> GetHyperlinkTexts();

        /// <summary>
        /// Retrieves all hyperlink URLs on the page.
        /// This method is used to gather all the URLs (href attributes) from <a> tags across the page.
        /// </summary>
        /// <returns>A list of hyperlink URLs found on the page.</returns>
        IList<string> GetHyperlinkUrls();

        /// <summary>
        /// Clicks the "Start" button, typically used for initiating some dynamic loading behavior.
        /// This method simulates clicking a button to start some process or interaction on the page.
        /// </summary>
        void ClickStartButton();

        /// <summary>
        /// Checks if the loading indicator is displayed on the page.
        /// This method is used to verify if the page is in a loading state, often represented by a spinner or animation.
        /// </summary>
        /// <returns>True if the loading indicator is displayed, false otherwise.</returns>
        bool IsLoadingIndicatorDisplayed();

        /// <summary>
        /// Waits for the loading process to complete.
        /// This method is typically used to wait until the page has fully loaded or an operation is complete.
        /// </summary>
        void WaitForLoadingToComplete();

        /// <summary>
        /// Checks if the dynamically loaded element is displayed on the page.
        /// This method is used to verify if content that loads dynamically is present and visible on the page.
        /// </summary>
        /// <returns>True if the dynamically loaded element is displayed, false otherwise.</returns>
        bool IsDynamicallyLoadedElementDisplayed();

        /// <summary>
        /// Retrieves the text of the dynamically loaded element.
        /// This method is used to get the text of an element that loads dynamically after page interaction.
        /// </summary>
        /// <returns>The text of the dynamically loaded element.</returns>
        string GetLoadedElementText();

        /// <summary>
        /// Validates if a given element, specified by its locator, is displayed on the page.
        /// This method is used for general checks to verify the presence of any element.
        /// </summary>
        /// <param name="locator">The locator of the element to check for.</param>
        /// <returns>True if the element is displayed, false otherwise.</returns>
        bool IsElementDisplayed(string locator);
    }
}
