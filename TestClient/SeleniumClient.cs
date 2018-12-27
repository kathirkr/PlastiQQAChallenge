using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using System;
using System.Threading;

namespace PlastiQQAChallenge.TestClient
{
    public class SeleniumClient : ITestClient
    {
        private IWebDriver _driver;

        public SeleniumClient()
        {

        }

        public string PageTitle  { get { return _driver.Title; } }


        public void ClickSafe(string path, int waitTimeSpan)
        {
            var searchButton = _driver.FindElement(By.CssSelector(path));
            Thread.Sleep(waitTimeSpan);
            searchButton.Click();
        }

        public void Connect(BrowserType btype = BrowserType.Chrome)
        {
            switch (btype)
            {
                case BrowserType.Chrome:
                    _driver = new ChromeDriver();
                    break;
                case BrowserType.IE:
                    _driver = new InternetExplorerDriver();
                    break;
            }                
        }

        public void GoToURL(string url)
        {
            _driver.Navigate().GoToUrl(url);
        }

        public void SendKeys(string path, string text)
        {
            var searchTextBox = _driver.FindElement(By.CssSelector(path));
            searchTextBox.SendKeys(text);
        }
    }
}
