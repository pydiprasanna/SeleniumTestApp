using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium.Firefox;
using NUnit.Framework;
using System.Threading;

namespace SeleniumTest.CodeBindings
{
    [Binding]
    public class SearchKeywordSteps
    {
        private IWebDriver _driver;

        [Given(@"I am on google search page")]
        public void GivenIAmOnGoogleSearchPage()
        {
            _driver = new FirefoxDriver();
            _driver.Navigate().GoToUrl("http://www.google.com/ncr");
        }
        
        [When(@"I Search for a keyword called '(.*)'")]
        public void WhenISearchForAKeywordCalled(string keyword)
        {
            ScenarioContext.Current.Pending(); IWebElement query = _driver.FindElement(By.Name("q"));
            query.SendKeys(keyword);
            query.Submit();
        }
        
        [Then(@"I should see '(.*)' on the goole search")]
        public void ThenIShouldSeeOnTheGooleSearch(string keyword)
        {
            Thread.Sleep(5000);
            Assert.That(_driver.Title, Is.EqualTo(keyword));
        }
    }
}
