using NUnit.Framework;
using HerokuAppOperations;

namespace HerokuAppTests
{
    /// <summary>
    /// Test suite for verifying the functionality of the Basic Authentication feature on the Heroku App.
    /// </summary>
    [TestFixture]
    public class BasicAuthTests
    {
        private IBasicAuth basicAuth;

        /// <summary>
        /// Sets up the environment before each test by initializing the <see cref="BasicAuth"/> object.
        /// </summary>
        [SetUp]
        public void SetUp()
        {
            basicAuth = new BasicAuth();
        }

        /// <summary>
        /// Tests the authentication process with invalid credentials.
        /// Verifies that the user stays on the login page after an authentication failure.
        /// </summary>
        [Test]
        public void Test_AuthenticationWithInvalidCredentials_ShouldFailAndStayOnLoginPage()
        {
            // Navigate to the Basic Auth page
            basicAuth.NavigateToBasicAuthPage();

            // Enter invalid credentials
            basicAuth.EnterUsername("invalidUser");
            basicAuth.EnterPassword("invalidPass");

            // Check if the user is still on the login page
            Assert.IsTrue(basicAuth.IsOnLoginPage(), "User should still be on the login page after failed authentication.");
        }

        /// <summary>
        /// Tests the authentication process with valid credentials.
        /// Verifies that the user is authenticated and redirected to the appropriate page.
        /// </summary>
        [Test]
        public void Test_AuthenticationWithValidCredentials_ShouldAuthenticateAndRedirect()
        {
            // Navigate to the Basic Auth page
            basicAuth.NavigateToBasicAuthPage();

            // Enter valid credentials
            basicAuth.EnterUsername("admin");
            basicAuth.EnterPassword("admin");

            // Check if the authentication is successful
            Assert.IsTrue(basicAuth.IsAuthenticationSuccessful(), "User should be authenticated and redirected.");
        }

        /// <summary>
        /// Tests the logout functionality.
        /// Verifies that after logging out, the user is redirected to the login page.
        /// </summary>
        [Test]
        public void Test_LogOut_ShouldRedirectToLoginPage()
        {
            // Navigate to the Basic Auth page
            basicAuth.NavigateToBasicAuthPage();

            // Enter valid credentials
            basicAuth.EnterUsername("admin");
            basicAuth.EnterPassword("admin");

            // Check if the authentication is successful
            Assert.IsTrue(basicAuth.IsAuthenticationSuccessful(), "User should be authenticated.");

            // Log out and clear session cookies to prevent session persistence
            basicAuth.LogOut();
            // basicAuth.ClearCookies();

            // Verify if the user is redirected to the login page
            basicAuth.NavigateToBasicAuthPage(); // Revisit the page to trigger re-login prompt
            Assert.IsTrue(basicAuth.IsOnLoginPage(), "User should be redirected to the login page after logout.");
        }

        /// <summary>
        /// Tests the authentication process with valid credentials.
        /// Verifies that the user is authenticated and redirected to the appropriate page.
        /// (Duplicate test, consider removing if unnecessary.)
        /// </summary>
        [Test]
        public void Test_AuthenticationWithValidCredentials_ShouldAuthenticateAndDisplaySuccessMessage()
        {
            // Navigate to the Basic Auth page
            basicAuth.NavigateToBasicAuthPage();

            // Enter valid credentials
            basicAuth.EnterUsername("admin");
            basicAuth.EnterPassword("admin");

            // Check if the authentication is successful
            Assert.IsTrue(basicAuth.IsAuthenticationSuccessful(), "User should be authenticated and redirected.");
        }

        /// <summary>
        /// Tests the authentication process with an invalid username.
        /// Verifies that the user stays on the login page after entering an invalid username.
        /// </summary>
        [Test]
        public void Test_AuthenticationWithInvalidUsername_ShouldFailAndStayOnLoginPage()
        {
            // Navigate to the Basic Auth page
            basicAuth.NavigateToBasicAuthPage();

            // Enter invalid username
            basicAuth.EnterUsername("invalidUser");
            basicAuth.EnterPassword("admin");

            // Check if the user is still on the login page
            Assert.IsTrue(basicAuth.IsOnLoginPage(), "User should still be on the login page after invalid username.");
        }

        /// <summary>
        /// Tests the authentication process with an invalid password.
        /// Verifies that the user stays on the login page after entering an incorrect password.
        /// </summary>
        [Test]
        public void Test_AuthenticationWithInvalidPassword_ShouldFailAndStayOnLoginPage()
        {
            // Navigate to the Basic Auth page
            basicAuth.NavigateToBasicAuthPage();

            // Enter valid username and invalid password
            basicAuth.EnterUsername("admin");
            basicAuth.EnterPassword("wrongPassword");

            // Check if the user is still on the login page
            Assert.IsTrue(basicAuth.IsOnLoginPage(), "User should still be on the login page after invalid password.");
        }

        /// <summary>
        /// Tests the authentication process when no credentials are provided.
        /// Verifies that the user stays on the login page after not providing any credentials.
        /// </summary>
        [Test]
        public void Test_AuthenticationWithNoCredentials_ShouldFailAndStayOnLoginPage()
        {
            // Navigate to the Basic Auth page
            basicAuth.NavigateToBasicAuthPage();

            // Enter no credentials
            basicAuth.EnterUsername("");
            basicAuth.EnterPassword("");

            // Check if the user is still on the login page
            Assert.IsTrue(basicAuth.IsOnLoginPage(), "User should still be on the login page after no credentials.");
        }

        /// <summary>
        /// Tests accessing the Basic Authentication page without authentication.
        /// Verifies that the user is prompted for credentials.
        /// </summary>
        [Test]
        public void Test_AccessingBasicAuthPageWithoutAuthentication_ShouldPromptForCredentials()
        {
            // Navigate to the Basic Auth page (without credentials)
            basicAuth.NavigateToBasicAuthPage();

            // Ensure the authentication dialog appears (alert is present)
            Assert.IsTrue(basicAuth.IsOnLoginPage(), "User should be prompted for credentials when accessing the Basic Auth page.");
        }

        /// <summary>
        /// Tests the login and logout cycle.
        /// Verifies that after logging out, the user is redirected to the login page.
        /// </summary>
        [Test]
        public void Test_LoginAndLogoutCycle_ShouldWorkCorrectly()
        {
            // Navigate to the Basic Auth page
            basicAuth.NavigateToBasicAuthPage();

            // Enter valid credentials
            basicAuth.EnterUsername("admin");
            basicAuth.EnterPassword("admin");

            // Check if the authentication is successful
            Assert.IsTrue(basicAuth.IsAuthenticationSuccessful(), "User should be authenticated.");

            // Log out and clear session cookies
            basicAuth.LogOut();
            // basicAuth.ClearCookies();

            // Revisit the Basic Auth page to ensure the user is logged out
            basicAuth.NavigateToBasicAuthPage();
            Assert.IsTrue(basicAuth.IsOnLoginPage(), "User should be redirected to the login page after logout.");
        }

        /// <summary>
        /// Tests the authentication process with long username and password.
        /// Verifies that the user is authenticated successfully even with long credentials.
        /// </summary>
       // [Test]
        //public void Test_AuthenticationWithLongUsernameAndPassword_ShouldAuthenticateSuccessfully()
        //{
        //    // Navigate to the Basic Auth page
        //    basicAuth.NavigateToBasicAuthPage();

        //    // Enter long username and password
        //    basicAuth.EnterUsername(new string('a', 100)); // 100 character username
        //    basicAuth.EnterPassword(new string('b', 100)); // 100 character password

        //    // Check if the authentication is successful
        //    Assert.IsTrue(basicAuth.IsAuthenticationSuccessful(), "User should be authenticated with long credentials.");
        //}
    }
}