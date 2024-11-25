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
    /// Interface for handling key press operations in the HerokuApp.
    /// Provides methods to retrieve the title, simulate a key press, and get the last key pressed.
    /// </summary>
    public interface IKeyPresses
    {
        /// <summary>
        /// Retrieves the title associated with the key press operations.
        /// </summary>
        /// <returns>The title of the key press operations section as a string.</returns>
        public string GetTitle();

        /// <summary>
        /// Simulates pressing a specific key.
        /// </summary>
        /// <param name="key">The key to simulate pressing, as a string.</param>
        public void PressKey(string key);

        /// <summary>
        /// Retrieves the last key that was pressed.
        /// </summary>
        /// <returns>The last key pressed as a string.</returns>
        public string GetKeyPressed();
    }
}

