// --------------------------------------------------------------------------------------------------------------------
// © [Your Company Name], [Year]. All rights reserved.
// This code is the property of [Your Company Name] and is protected by copyright law. Unauthorized reproduction or
// distribution of this code, or any portion of it, may result in civil and criminal penalties and will be prosecuted
// to the maximum extent possible under the law.
// --------------------------------------------------------------------------------------------------------------------

namespace HerokuAppOperations
{
    /// <summary>
    /// Defines the interface for A/B Testing operations within the HerokuApp platform.
    /// </summary>
    /// <remarks>
    /// A/B Testing involves running experiments on a website by providing two different versions 
    /// (A and B) to different user segments. This interface provides methods to opt in or opt out 
    /// of A/B tests for user scenarios on the HerokuApp.
    /// </remarks>
    public interface IABTesting
    {
        /// <summary>
        /// Simulates opting into an A/B test.
        /// </summary>
        /// <remarks>
        /// Use this method when the user should be included in the A/B testing group. 
        /// This action may simulate enabling a feature or redirecting the user to a different 
        /// version of a page.
        /// </remarks>
        void OptInABTest();

        /// <summary>
        /// Simulates opting out of an A/B test.
        /// </summary>
        /// <remarks>
        /// Use this method to ensure the user is not part of the A/B testing group.
        /// This action may revert any changes or ensure that the user sees the default version 
        /// of the page.
        /// </remarks>
        void OptOutABTest();
    }
}
