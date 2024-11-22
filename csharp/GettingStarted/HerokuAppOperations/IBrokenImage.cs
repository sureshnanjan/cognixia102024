using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerokuAppOperations
{
    public interface IBrokenImage
    {
        /// <summary>
        /// Validates all images on a given web page and returns the number of broken images.
        /// </summary>
        /// <param name="url">The URL of the web page to validate.</param>
        /// <returns>The number of broken images.</returns>
        int ValidateImages(string url);
    }

}
