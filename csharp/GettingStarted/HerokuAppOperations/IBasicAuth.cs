using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerokuAppOperations
{
    public interface IBasicAuth
    {
        // Method to navigate to the Basic Auth page
        void NavigateToBasicAuthPage();

        // Method to validate if the authentication was successful
        bool IsAuthenticationSuccessful();

        // Method to print the success message
        void PrintSuccessMessage();
    }
}
