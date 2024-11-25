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
    /// Interface for dynamic controls in the HerokuApp, including methods to enable, disable,
    /// and check the status of a checkbox control, as well as retrieve a title.
    /// </summary>
    public interface IDynamicControls
    {
        /// <summary>
        /// Retrieves the title associated with the dynamic controls.
        /// </summary>
        /// <returns>The title of the dynamic controls as a string.</returns>
        public string GetTitle();

        /// <summary>
        /// Enables the checkbox control.
        /// </summary>
        public void EnableCheckbox();

        /// <summary>
        /// Disables the checkbox control.
        /// </summary>
        public void DisableCheckbox();

        /// <summary>
        /// Checks if the checkbox is enabled.
        /// </summary>
        /// <returns>True if the checkbox is enabled; otherwise, false.</returns>
        public bool IsCheckboxEnabled();
    }
}
