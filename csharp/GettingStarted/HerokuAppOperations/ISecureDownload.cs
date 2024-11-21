using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerokuAppOperations
{
    public interface ISecureFileDownload
    {
        // Method to download the file securely, accepting the file URL, username, and password.
        Task<bool> DownloadFileAsync(string url, string username, string password, string downloadLocation);

        // Method to verify the downloaded file (e.g., checking its integrity).
        bool VerifyDownload(string downloadLocation, string expectedChecksum);

        // Method to handle the downloaded file (e.g., move or rename after download).
        void HandleDownloadedFile(string filePath);
    }
}
