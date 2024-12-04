namespace HerokuAppOperations
{
    /// <summary>
    /// Interface for interacting with the Slow Resources page on the HerokuApp website.
    /// Defines methods for retrieving information about the header and content of the page,
    /// including waiting for slow-loading content.
    /// </summary>
    public interface ISlowResources
    {
        /// <summary>
        /// Navigates to the Slow Resources page.
        /// </summary>
        void NavigateToPage();

        /// <summary>
        /// Retrieves the title of the page.
        /// </summary>
        string GetPageTitle();

        /// <summary>
        /// Retrieves the header text from the page.
        /// </summary>
        string GetHeaderText();

        /// <summary>
        /// Waits for the content to load and retrieves it.
        /// </summary>
        string GetContentAfterLoading(int timeoutInSeconds);

        /// <summary>
        /// Tracks network responses for slow resources (specifically long GET requests).
        /// </summary>
        dynamic GetNetworkResponse(string url);

        /// <summary>
        /// Closes the browser.
        /// </summary>
        void CloseBrowser();
    }
}
