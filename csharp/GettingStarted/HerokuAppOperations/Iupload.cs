using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerokuAppOperations
{
    public interface Iupload
    {
       

        /// <summary>
        /// Uploads a file to the target webpage.
        /// </summary>
        /// <param name="filePath">The full path to the file to be uploaded.</param>
        public void UploadFile();


        public void ChooseFile(string filePath);

        /// <summary>
        /// Verifies if the file upload was successful.
        /// </summary>
        /// <returns>A boolean indicating success or failure.</returns>
       

        /// <summary>
        /// Closes the browser.
        /// </summary>
        public void CloseBrowser();
    }
}
