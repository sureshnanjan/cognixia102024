using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerokuAppOperations
{
    public interface IFrames
    {


        /// <summary>
        /// This method is called when the user clicks on nested frames
        /// on the webpage, typically for interacting with frames embedded within other frames.
        /// </summary>
        void OnClickingNestedframes();

        /// <summary>
        /// This method is used to check or interact with the top frame on the webpage.
        /// It can be used to verify properties or perform actions specific to the topmost frame.
        /// </summary>
        void CheckTopframe();

        /// <summary>
        /// This method is used to check or interact with the bottom frame on the webpage.
        /// It can be used to verify properties or perform actions specific to the bottom frame.
        /// </summary>
        void CheckBottomframe();

        /// <summary>
        /// This method is used to check or interact with the left frame on the webpage.
        /// It can be used to verify properties or perform actions specific to the leftmost frame.
        /// </summary>
        void CheckLeftframe();

        /// <summary>
        /// This method is used to check or interact with the right frame on the webpage.
        /// It can be used to verify properties or perform actions specific to the rightmost frame.
        /// </summary>
        void CheckRightframe();

        /// <summary>
        /// This method is used to check or interact with the middle frame on the webpage.
        /// It can be used to verify properties or perform actions specific to the middle frame.
        /// </summary>
        void CheckMiddleframe();

        /// <summary>
        /// This method is invoked when the user clicks on iframe,
        /// typically for interacting with inline frames (iframe elements) embedded in the webpage.
        /// </summary>
        void OnClickingiFrame();
    }
}