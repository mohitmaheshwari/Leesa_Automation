using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using Vanuetti.Automation.Framework;

namespace LeesaUITests.Pages
{
    public class BasePage
    {
        private By ClosePopUp => By.CssSelector("button.leadinModal-close");
        public static bool ThreadRunning = false;
        public Browser browser => Browser.Instance;
        public string GetCurrentURL()
        {
            return browser.GetUrl();
        }

        public void NavigateToURL(string url)
        {
            browser.NavigateToURL(url);
        }

        public void GoBack()
        {
            browser.webDriver.Navigate().Back();
        }

        public bool IsNewTabOpened()
        {
            bool result = browser.webDriver.WindowHandles.Count > 1;
            if (result)
            {
                browser.SwitchToNewTab();
                browser.webDriver.Close();
                browser.SwitchToDefaultTab();
            }
            return result;
        }

        public void HandlePopUp(bool threadState)
        {
            ThreadRunning = threadState;
            while (ThreadRunning)
            {
                try
                {
                    var closePopUp = browser.webDriver.FindElement(ClosePopUp);
                    if (closePopUp.Displayed)
                    {
                        closePopUp.Click();
                    }
                }
                catch
                {

                }
            }
        }

        public string NavigateToUrlWithApiAndReturnSource(string url)
        {
            try
            {
                using (WebClient web1 = new WebClient())
                {
                    string data = web1.DownloadString(url);
                    return data;
                }
            }
            catch (Exception ex)
            {
                return "";
            }
        }
    }


}
