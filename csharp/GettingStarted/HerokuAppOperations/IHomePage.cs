using System;

namespace HerokuAppWebdriverAdapter
{
    public interface IHomePage
    {
        string GetTitle();
        string[] GetAvailableExamples();
        string GetExampleLinkUrl(int index); // Get the URL of an example link by index

        // Get the total number of navigation links (li > a)
;
    }
}
