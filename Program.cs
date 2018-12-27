using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using PlastiQQAChallenge.TestClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PlastiQQAChallenge
{
    class Program
    {
        private static ITestClient _client = TestClientFactory.GetInstance("Selenium");

        static void Main(string[] args)
        {
            _client.Connect();
            _client.GoToURL("https://www.google.com");
            _client.SendKeys("input[type='text'][title='Search']", "test automation is awesome");
            _client.ClickSafe("input[value='Google Search'][type='submit']", 1000);
            Console.WriteLine($"The SearchTitle for the given keyword is: {_client.PageTitle}");
            Console.Read();

            //Before Refactoring...
            //_driver = new ChromeDriver();
            //_driver.Navigate().GoToUrl("https://www.google.com");
            //var searchTextBox = _driver.FindElement(By.CssSelector("input[type='text'][title='Search']"));
            //if (searchTextBox != null)
            //{
            //    searchTextBox.SendKeys("test automation is awesome");
            //    var searchButton = _driver.FindElement(By.CssSelector("input[value='Google Search'][type='submit']"));
            //    Thread.Sleep(1000);
            //    searchButton.Click();
            //    var searchPageTitle = _driver.Title;
            //    Console.WriteLine($"The SearchTitle for the given keyword is: {searchPageTitle}");
            //    Console.Read();
            //}
        }
    }
}
