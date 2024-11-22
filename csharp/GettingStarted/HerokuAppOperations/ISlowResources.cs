namespace HerokuAppOperations
{
    /// <summary>
    /// Interface for interacting with the Slow Resources page on the HerokuApp website.
    /// Defines methods for retrieving information about the header and content of the page, including waiting for slow-loading content.
    /// </summary>
    public interface ISlowResources
    {
        /// <summary>
        /// Retrieves the header text from the Slow Resources page.
        /// </summary>
        /// <returns>A string representing the header text of the page.</returns>
        string GetHeaderText();

        /// <summary>
        /// Waits for the content to load and retrieves the content text after loading.
        /// </summary>
        /// <param name="timeoutInSeconds">The time to wait for the content to load (in seconds).</param>
        /// <returns>A string representing the content text of the page after it has loaded.</returns>
        string GetContentAfterLoading(int timeoutInSeconds);
    }
}