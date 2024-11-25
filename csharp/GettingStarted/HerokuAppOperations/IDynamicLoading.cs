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
    /// Interface for dynamic loading operations in the HerokuApp.
    /// Provides methods to retrieve the title, start a loading operation, 
    /// and check the visibility of an element after loading is complete.
    /// </summary>
    public interface IDynamicLoading
    {
        /// <summary>
        /// Retrieves the title of the dynamic loading section.
        /// </summary>
        /// <returns>The title of the dynamic loading section as a string.</returns>
        public string GetTitle();

        /// <summary>
        /// Starts the loading operation.
        /// </summary>
        public void StartLoading();

        /// <summary>
        /// Checks if a specific element is visible after the loading operation completes.
        /// </summary>
        /// <returns>True if the element is visible after loading; otherwise, false.</returns>
        public bool IsElementVisibleAfterLoading();
    }
}
