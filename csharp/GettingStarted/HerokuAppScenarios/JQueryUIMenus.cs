using HerokuAppOperations;
using HerokuAppWebdriverAdapter;
using NUnit.Framework;

namespace HerokuAppScenarios
{
    /// <summary>
    /// Test class for the JQuery UI Menus example page.
    /// Contains tests to validate menu interactions and accessibility.
    /// </summary>
    [TestFixture]
    public class JQueryUIMenusTests
    {
        private HomePage _page; // Homepage instance for navigation
        private IJQueryUIMenus _menus; // JQuery UI Menus page object

        /// <summary>
        /// Set up the environment for each test.
        /// Initializes the homepage and navigates to the JQuery UI Menus page.
        /// </summary>
        [SetUp]
        public void SetUp()
        {
            _page = new HomePage();
            _menus = _page.navigateToExample("JQueryUIMenus") as IJQueryUIMenus;
        }

        /// <summary>
        /// Test to verify that the menu structure is accessible.
        /// </summary>
        [Test]
        public void VerifyMenuAccessibility()
        {
            Assert.NotNull(_menus, "JQueryUIMenus page did not load correctly.");

            // Verify the menu accessibility
            Assert.DoesNotThrow(() => _menus.VerifyMenuAccessibility(), "Menu accessibility check failed.");
        }

        /// <summary>
        /// Test to navigate and select a specific menu and submenu item.
        /// </summary>
        [Test]
        public void NavigateAndSelectMenuItem()
        {
            Assert.NotNull(_menus, "JQueryUIMenus page did not load correctly.");

            // Define the main menu and submenu items
            string mainMenu = "Enabled";
            string submenu = "Downloads";

            // Perform navigation and selection
            Assert.DoesNotThrow(() => _menus.SelectMenuItem(mainMenu, submenu), $"Failed to select submenu item '{submenu}' under '{mainMenu}'.");

            // Verify resulting URL or behavior
            string currentUrl = _menus.GetCurrentUrl();
            Assert.IsTrue(currentUrl.Contains("menu"), $"Expected URL to remain within the menu page, but got {currentUrl}.");
        }

        /// <summary>
        /// Test to interact only with the main menu item without selecting a submenu.
        /// </summary>
        [Test]
        public void NavigateToMainMenuOnly()
        {
            Assert.NotNull(_menus, "JQueryUIMenus page did not load correctly.");

            // Define the main menu item
            string mainMenu = "Enabled";

            // Perform navigation without submenu selection
            Assert.DoesNotThrow(() => _menus.SelectMenuItem(mainMenu), $"Failed to select main menu item '{mainMenu}'.");

            // Verify resulting URL or behavior
            string currentUrl = _menus.GetCurrentUrl();
            Assert.IsTrue(currentUrl.Contains("menu"), $"Expected URL to remain within the menu page, but got {currentUrl}.");
        }
    }
}
