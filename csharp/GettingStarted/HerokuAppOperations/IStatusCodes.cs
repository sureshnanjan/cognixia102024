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
        /// <remarks>
        /// This method will take the user to a page that corresponds to the given status code.
        /// The page will show information about the specific status code (e.g., 200 OK, 404 Not Found).
        /// </remarks>
        void NavigateToStatusCode(string code);

        /// <summary>
        /// Retrieves the header text displayed on the Status Codes page.
        /// </summary>
        /// <returns>A string representing the header text of the page.</returns>
        /// <remarks>
        /// This method will return the main header text from the Status Codes page, 
        /// which usually gives a title or context for the status codes shown on that page.
        /// </remarks>
        string GetPageHeader();

        /// <summary>
        /// Retrieves the descriptive text of the HTTP status code displayed on the page.
        /// </summary>
        /// <returns>A string representing the description of the HTTP status code.</returns>
        /// <remarks>
        /// This method will return the description text corresponding to the status code,
        /// such as "OK" for a 200 code or "Not Found" for a 404 code.
        /// </remarks>
        string GetStatusCodeText();

        /// <summary>
        /// Retrieves the title of the page.
        /// </summary>
        /// <returns>A string representing the title of the page.</returns>
        /// <remarks>
        /// This method will return the title of the web page, typically found in the 
        /// <title> tag in the HTML, representing the status code's page title.
        /// </remarks>
        string GetPageTitle();

        /// <summary>
        /// Retrieves the error message displayed on the page, if any.
        /// </summary>
        /// <returns>A string representing any error message displayed on the page.</returns>
        /// <remarks>
        /// This method returns the error message that may be shown when a particular status code page
        /// indicates an issue, such as a 404 error message or other descriptive error messages.
        /// </remarks>
        string GetErrorMessage();
    }
}
