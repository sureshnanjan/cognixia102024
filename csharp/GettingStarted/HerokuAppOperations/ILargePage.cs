// --------------------------------------------------------------------------------------------------------------------
// © [Your Company Name], [Year]. All rights reserved.
// This code is the property of [Your Company Name] and is protected by copyright law. Unauthorized reproduction or
// distribution of this code, or any portion of it, may result in civil and criminal penalties and will be prosecuted
// to the maximum extent possible under the law.
// --------------------------------------------------------------------------------------------------------------------

using System;  // Importing System namespace for general functionality.
using System.Collections.Generic;  // Importing collections namespace for working with collections.
using System.Linq;  // Importing LINQ namespace for querying collections.
using System.Text;  // Importing Text namespace for string manipulation.
using System.Threading.Tasks;  // Importing Task namespace for asynchronous programming.

namespace HerokuAppOperations
{
    // Interface ILargePage defines the contract for any large page operations.
    // It contains method signatures that must be implemented by classes that interact with large pages.
    public interface ILargePage
    {
        // Method to get the page's title.
        // Returns a string containing the title of the page.
        string GetTitle();

        // Method to get the text content on the page.
        // Returns a string containing the page's content.
        string GetPageContent();
    }
}
