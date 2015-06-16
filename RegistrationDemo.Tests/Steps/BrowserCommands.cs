using Baseclass.Contrib.SpecFlow.Selenium.NUnit.Bindings;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace RegistrationDemo.Tests.Steps
{
    [Binding]
    public class BrowserCommands
    {
        [Given(@"I open seleniumframework website")]
        public void GivenIOpenSeleniumframeworkWebsite()
        {
            Browser.Current.Navigate().GoToUrl("http://www.seleniumframework.com");
            Browser.Current.Manage().Window.Maximize();
        }

        [Given(@"I navigate to ABOUT link")]
        public void GivenINavigateToABOUTLink()
        {
            Browser.Current.FindElement(By.LinkText("ABOUT")).Click();
        }

        [Then(@"I print the html")]
        public void ThenIPrintTheHtml()
        {
            Console.WriteLine("Browser html-{0}", Browser.Current.Title);
        }

        [Then(@"I perform selenium browser commands")]
        public void ThenIPerformSeleniumBrowserCommands()
        {
            // code that turns phrase into concrete actions
            Console.Write("Printing website title ... ");
            Console.WriteLine(Browser.Current.Title);

            Console.Write("Printing current URL ... ");
            Console.WriteLine(Browser.Current.Url);

            Console.Write("Printing page source ... ");
            Console.WriteLine(Browser.Current.PageSource);

            Console.Write("Clicking ABOUT link ...");
            Browser.Current.FindElement(By.LinkText("ABOUT")).Click();

            Browser.Current.Navigate().Back();
            Browser.Current.Navigate().Forward();

            Console.Write("Printing title again ... ");
            Console.WriteLine(Browser.Current.Title);

            Console.WriteLine("Refreshing the browser");
            Browser.Current.Navigate().Refresh();
            Console.WriteLine("Exiting the browser now");
        }
    }
}
