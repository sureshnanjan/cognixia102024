// --------------------------------------------------------------------------------------------------------------------
// © [Your Company Name], [Year]. All rights reserved.
// This code is the property of [Your Company Name] and is protected by copyright law. Unauthorized reproduction or
// distribution of this code, or any portion of it, may result in civil and criminal penalties and will be prosecuted
// to the maximum extent possible under the law.
// --------------------------------------------------------------------------------------------------------------------

using System;

namespace HerokuAppOperations
{
    /// <summary>
    /// Defines the interface for Add/Remove operations in the HerokuApp application.
    /// </summary>
    /// <remarks>
    /// This interface provides methods to interact with a dynamic list of elements on the HerokuApp platform. 
    /// It includes functionalities for adding, removing, and counting elements, as well as retrieving the page title.
    /// </remarks>
    public interface IAddRemove
    {
        /// <summary>
        /// Retrieves the title of the current page.
        /// </summary>
        /// <returns>A string representing the page title.</returns>
        /// <remarks>
        /// This method can be used for validation or debugging purposes, ensuring that the test is running on 
        /// the correct page within the application.
        /// </remarks>
        public string GetTitle();

        /// <summary>
        /// Adds a new element to the dynamic list on the page.
        /// </summary>
        /// <remarks>
        /// This method simulates the user clicking the "Add Element" button, which dynamically 
        /// creates a new element on the page.
        /// </remarks>
        public void AddElement();

        /// <summary>
        /// Deletes an existing element from the dynamic list on the page.
        /// </summary>
        /// <remarks>
        /// This method simulates the user clicking the "Delete" button associated with an element,
        /// removing it from the list dynamically.
        /// </remarks>
        public void DeleteElement();

        /// <summary>
        /// Retrieves the current count of elements in the dynamic list.
        /// </summary>
        /// <returns>An integer representing the number of elements currently displayed on the page.</returns>
        /// <remarks>
        /// This method is useful for assertions during testing, such as verifying that the correct 
        /// number of elements has been added or removed dynamically.
        /// </remarks>
        public int GetCountofElements();
    }
}
