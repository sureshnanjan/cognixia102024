/*
Licensed to the Software Freedom Conservancy (SFC) under one
or more contributor license agreements. See the NOTICE file
distributed with this work for additional information
regarding copyright ownership. The SFC licenses this file
to you under the Apache License, Version 2.0 (the
"License"); you may not use this file except in compliance
with the License. You may obtain a copy of the License at
 
  http://www.apache.org/licenses/LICENSE-2.0
 
Unless required by applicable law or agreed to in writing,
software distributed under the License is distributed on an
"AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
KIND, either express or implied. See the License for the
specific language governing permissions and limitations
under the License.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerokuAppOperations
{
    // This interface defines the contract for secure file download operations.
    // An interface in C# is a type that defines a set of methods and properties
    // that the implementing class must provide. It is used to achieve abstraction
    // and multiple inheritance in C#.
    public interface ISecureFileDownload
    {
        // Method to download the file securely, accepting the file URL, username, and password.
        // This method should contain the logic to download a file from a specified URL using
        // the provided username and password for authentication. The downloaded file should
        // be saved to the specified download location.
        Task<bool> DownloadFileAsync(string url, string username, string password, string downloadLocation);

        // Method to verify the downloaded file (e.g., checking its integrity).
        // This method should contain the logic to verify the integrity of the downloaded file
        // by comparing its checksum with the expected checksum.
        bool VerifyDownload(string downloadLocation, string expectedChecksum);

        // Method to handle the downloaded file (e.g., move or rename after download).
        // This method should contain the logic to handle the downloaded file, such as moving it
        // to a different location or renaming it after the download is complete.
        void HandleDownloadedFile(string filePath);
    }
}