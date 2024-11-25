using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerokuAppOperations
{
    public interface INotificationMessage
    {
        /// <summary>
        /// Clicks the notification link to trigger a new message.
        /// </summary>
        void ClickNotificationLink();

        /// <summary>
        /// Retrieves the current notification message text.
        /// </summary>
        /// <returns>The text of the notification message.</returns>
        string GetNotificationMessage();

        /// <summary>
        /// Verifies if the notification message matches one of the expected values.
        /// </summary>
        /// <param name="expectedMessages">An array of expected notification messages.</param>
        /// <returns>True if the notification message matches any expected value; otherwise, false.</returns>
        bool IsNotificationMessageValid(string[] expectedMessages);

        /// <summary>
        /// Clears the current notification message, if applicable.
        /// </summary>
        void ClearNotificationMessage();
    }
}
