using System;


namespace HerokuAppOperations
{

    /// <summary>
    /// Interface representing an Entry Advertisement Modal with methods to interact with it.
    /// </summary>
    public interface IEntryAds
    {
        /// <summary>
        /// Checks if the modal is currently displayed on the screen.
        /// </summary>
        /// <returns>
        /// Returns <c>true</c> if the modal is displayed, otherwise <c>false</c>.
        /// </returns>
        bool IsModalDisplayed();

        /// <summary>
        /// Closes the modal window if it is currently open.
        /// </summary>
        void CloseModal();

        /// <summary>
        /// Retrieves the content displayed within the modal's body.
        /// </summary>
        /// <returns>
        /// A string representing the content within the modal's body.
        /// </returns>
        string GetModalBodyContent();

        /// <summary>
        /// Clicks the "Click Here" link to reopen the modal after it has been closed.
        /// </summary>
        void ReopenModal();
    }
}
