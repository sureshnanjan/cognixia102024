namespace HerokuAppOperations
{
    /// <summary>
    /// Interface for interacting with the Status Codes page on the HerokuApp website.
    /// Defines methods for navigation and retrieving information about the HTTP status codes.
    /// </summary>
    public interface IStatusCodes
    {
        /// <summary>
        /// Navigates to the page for a specific HTTP status code.
        /// </summary>
        /// <param name="code">The HTTP status code to navigate to (e.g., "200", "404").</param>
        void NavigateToStatusCode(string code);

        /// <summary>
        /// Retrieves the header text displayed on the Status Codes page.
        /// </summary>
        /// <returns>A string representing the header text of the page.</returns>
        string GetPageHeader();

        /// <summary>
        /// Retrieves the descriptive text of the HTTP status code displayed on the page.
        /// </summary>
        /// <returns>A string representing the description of the HTTP status code.</returns>
        string GetStatusCodeText();
    }
}
