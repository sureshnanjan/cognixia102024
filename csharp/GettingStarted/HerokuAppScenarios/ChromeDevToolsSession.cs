using OpenQA.Selenium.DevTools;

namespace HerokuAppScenarios
{
    internal class ChromeDevToolsSession
    {
        public static implicit operator ChromeDevToolsSession(DevToolsSession v)
        {
            throw new NotImplementedException();
        }
    }
}