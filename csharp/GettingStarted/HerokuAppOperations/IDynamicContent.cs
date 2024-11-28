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
    /// Defines operations for interacting with dynamic content elements in the HerokuApp.
    /// </summary>
    /// <remarks>
    /// This interface provides methods for retrieving the title and main content text of a dynamic element.
    /// These operations are useful in automated test scenarios to validate the dynamic content on the page.
    /// </remarks>
    public interface IDynamicContent
    {
        /// <summary>
        /// Retrieves the title of the dynamic content element.
        /// </summary>
        /// <returns>A string representing the title of the dynamic content.</returns>
        /// <remarks>
        /// This method can be used to ensure that the dynamic content element is loaded correctly by verifying the title.
        /// </remarks>
        public string GetTitle();

        /// <summary>
        /// Retrieves the main text content of the dynamic content element.
        /// </summary>
        /// <returns>A string representing the text content of the dynamic element.</returns>
        /// <remarks>
        /// This method is useful for fetching and validating the actual content displayed by dynamic elements on the page.
        /// It can be applied in test cases to ensure the content matches expectations after an action is performed.
        /// </remarks>
        public string GetContentText();
    }
}
