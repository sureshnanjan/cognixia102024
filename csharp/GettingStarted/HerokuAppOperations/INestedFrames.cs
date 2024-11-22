using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerokuAppOperations
{
    public interface INestedFrames
    {
        /// <summary>
        /// Switches to the LEFT frame and retrieves its content.
        /// </summary>
        /// <returns>The text content of the LEFT frame.</returns>
        string GetLeftFrameContent();

        /// <summary>
        /// Switches to the MIDDLE frame and retrieves its content.
        /// </summary>
        /// <returns>The text content of the MIDDLE frame.</returns>
        string GetMiddleFrameContent();

        /// <summary>
        /// Switches to the RIGHT frame and retrieves its content.
        /// </summary>
        /// <returns>The text content of the RIGHT frame.</returns>
        string GetRightFrameContent();

        /// <summary>
        /// Switches to the BOTTOM frame and retrieves its content.
        /// </summary>
        /// <returns>The text content of the BOTTOM frame.</returns>
        string GetBottomFrameContent();

        /// <summary>
        /// Switches back to the main page (default content) from any frame.
        /// </summary>
        void SwitchToMainContent();

        /// <summary>
        /// Checks if a specific frame (by its name or index) is available.
        /// </summary>
        /// <param name="frameName">The name or index of the frame.</param>
        /// <returns>True if the frame exists, otherwise false.</returns>
        bool IsFrameAvailable(string frameName);

        /// <summary>
        /// Switches to a specific frame by its name or index.
        /// </summary>
        /// <param name="frameName">The name or index of the frame to switch to.</param>
        void SwitchToFrame(string frameName);
    }
}
