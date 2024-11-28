// --------------------------------------------------------------------------------------------------------------------
// © [Your Company Name], [Year]. All rights reserved.
// This code is the property of [Your Company Name] and is protected by copyright law. Unauthorized reproduction or
// distribution of this code, or any portion of it, may result in civil and criminal penalties and will be prosecuted
// to the maximum extent possible under the law.
// --------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerokuAppOperations
{
    /// <summary>
    /// Interface for handling JavaScript error operations in the HerokuApp.
    /// Provides methods to retrieve the title and check if an error message is displayed.
    /// </summary>
    public interface IJsError
    {
        /// <summary>
        /// Retrieves the title associated with the JavaScript error.
        /// </summary>
        /// <returns>The title of the JavaScript error as a string.</returns>
        public string GetTitle();

        /// <summary>
        /// Checks if the JavaScript error message is currently displayed.
        /// </summary>
        /// <returns>True if the error message is displayed; otherwise, false.</returns>
        public bool IsErrorMessageDisplayed();
    }
}
