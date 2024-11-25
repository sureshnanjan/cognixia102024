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
    /// Interface for operations related to dynamic content in the HerokuApp.
    /// Provides methods to retrieve the title and text content of a dynamic element.
    /// </summary>
    public interface IDynamicContent
    {
        /// <summary>
        /// Retrieves the title of the dynamic content.
        /// </summary>
        /// <returns>The title of the dynamic content as a string.</returns>
        public string GetTitle();

        /// <summary>
        /// Retrieves the main text content of the dynamic content element.
        /// </summary>
        /// <returns>The text content as a string.</returns>
        public string GetContentText();
    }
}
