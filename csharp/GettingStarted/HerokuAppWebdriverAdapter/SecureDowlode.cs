﻿using HerokuAppOperations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerokuAppWebdriverAdapter
{
    public class SecureFileDownload : ISecureFileDownload
    {
        // Method to download the file securely
        public async Task<bool> DownloadFileAsync(string url, string username, string password, string downloadLocation)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    // Add credentials for basic authentication (if required)
                    var byteArray = new System.Text.UTF8Encoding().GetBytes($"{username}:{password}");
                    client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Basic", Convert.ToBase64String(byteArray));

                    // Get the file as a byte array
                    byte[] fileData = await client.GetByteArrayAsync(url);

                    // Save the file to the specified location
                    File.WriteAllBytes(downloadLocation, fileData);
                    Console.WriteLine("File downloaded successfully.");
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error downloading file: {ex.Message}");
                return false;
            }
        }

        // Method to verify the downloaded file's checksum
        public bool VerifyDownload(string downloadLocation, string expectedChecksum)
        {
            try
            {
                // Calculate the checksum of the downloaded file
                using (var sha256 = SHA256.Create())
                {
                    byte[] fileBytes = File.ReadAllBytes(downloadLocation);
                    string actualChecksum = BitConverter.ToString(sha256.ComputeHash(fileBytes)).Replace("-", "").ToLower();

                    // Compare with the expected checksum
                    if (actualChecksum.Equals(expectedChecksum, StringComparison.OrdinalIgnoreCase))
                    {
                        Console.WriteLine("Checksum matches.");
                        return true;
                    }
                    else
                    {
                        Console.WriteLine("Checksum does not match.");
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error verifying file: {ex.Message}");
                return false;
            }
        }

        // Method to handle the downloaded file (e.g., move it to a specific directory)
        public void HandleDownloadedFile(string filePath)
        {
            try
            {
                // Example of handling: moving the file to a different directory
                string targetDirectory = @"C:\Downloads\Processed";
                string targetFilePath = Path.Combine(targetDirectory, Path.GetFileName(filePath));

                // Ensure the directory exists
                Directory.CreateDirectory(targetDirectory);

                // Move the file
                File.Move(filePath, targetFilePath);
                Console.WriteLine($"File moved to: {targetFilePath}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error handling the downloaded file: {ex.Message}");
            }
        }
    }
}
