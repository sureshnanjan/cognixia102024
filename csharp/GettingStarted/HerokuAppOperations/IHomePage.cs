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
    /// Defines the contract for interacting with the Home Page of the HerokuApp.
    /// This interface provides methods to retrieve the title, available examples, and navigation link URLs.
    /// </summary>
    public interface IHomePage
    {
        /// <summary>
        /// Retrieves the title of the homepage.
        /// </summary>
        /// <returns>A string representing the title of the homepage.</returns>
        /// <remarks>
        /// This method can be used to validate that the page has loaded correctly by verifying the title.
        /// </remarks>
        string GetTitle();

        /// <summary>
        /// Retrieves the available examples listed on the homepage.
        /// </summary>
        /// <returns>An array of strings, each representing an example name on the homepage.</returns>
        /// <remarks>
        /// This method can be useful for verifying which examples are listed on the homepage and checking their availability.
        /// </remarks>
        string[] GetAvailableExamples();

        /// <summary>
        /// Retrieves the URL of an example link on the homepage by its index.
        /// </summary>
        /// <param name="index">The index of the example link to retrieve the URL for.</param>
        /// <returns>A string representing the URL of the example link at the specified index.</returns>
        /// <remarks>
        /// This method can be used to retrieve the URL associated with a particular example and validate if the link is correct.
        /// </remarks>
        string GetExampleLinkUrl(int index);

        /// <summary>
        /// Retrieves the total number of navigation links (li > a) available on the homepage.
        /// </summary>
        /// <returns>An integer representing the total number of navigation links on the homepage.</returns>
        /// <remarks>
        /// This method can be used to verify the number of navigation links on the homepage, which can help in testing or validation.
        /// </remarks>
        int GetNavigationLinkCount(); // Get the total number of navigation links (li > a)
    }
}
