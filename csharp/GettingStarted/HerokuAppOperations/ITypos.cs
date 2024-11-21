using System;

namespace HerokuAppOperations
{
    /// <summary>
    /// Interface for interacting with the Typos page on the HerokuApp website.
    /// </summary>
    public interface ITypos
    {
        /// <summary>
        /// Retrieves the header text displayed on the Typos page.
        /// </summary>
        /// <returns>A string representing the header text of the page.</returns>
        string GetPageHeader();

        /// <summary>
        /// Retrieves the main content text displayed on the Typos page.
        /// </summary>
        /// <returns>A string representing the main content text of the page.</returns>
        string GetPageContent();

        /// <summary>
        /// Refreshes the Typos page to simulate a retry or load operation.
        /// </summary>
        void RefreshPage();
    }
}
