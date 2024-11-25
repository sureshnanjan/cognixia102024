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
    /// Interface for handling entry advertisements in the HerokuApp.
    /// Provides methods to retrieve the ad title, check if the ad is displayed, and close the ad.
    /// </summary>
    public interface IEntryAd
    {
        /// <summary>
        /// Retrieves the title of the entry advertisement.
        /// </summary>
        /// <returns>The title of the entry advertisement as a string.</returns>
        public string GetTitle();

        /// <summary>
        /// Checks if the entry advertisement is currently displayed.
        /// </summary>
        /// <returns>True if the ad is displayed; otherwise, false.</returns>
        public bool IsAdDisplayed();

        /// <summary>
        /// Closes the entry advertisement.
        /// </summary>
        public void CloseAd();
    }
}
