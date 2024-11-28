// --------------------------------------------------------------------------------------------------------------------
// © [Your Company Name], [Year]. All rights reserved.
// This code is the property of [Your Company Name] and is protected by copyright law. Unauthorized reproduction or
// distribution of this code, or any portion of it, may result in civil and criminal penalties and will be prosecuted
// to the maximum extent possible under the law.
// --------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HerokuAppOperations;
using OpenQA.Selenium;

namespace HerokuAppWebdriverAdapter
{
    public class DynamicContent : HerokuAppCommon, IDynamicContent
    {
        private By contentArea;

        public DynamicContent(IWebDriver arg) : base(arg)
        {
            this.contentArea = By.Id("content");
        }

        public string GetTitle()
        {
            return this.driver.Title;
        }

        public string GetContentText()
        {
            return this.driver.FindElement(contentArea).Text;
        }
    

    }
}
