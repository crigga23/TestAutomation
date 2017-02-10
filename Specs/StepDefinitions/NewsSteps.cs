using Framework.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace Specs.StepDefinitions
{
    [Binding]
    public class NewsSteps
    {
        private static IWebDriver driver;

        public NewsSteps()
        {
            driver = AutomationHelper.CreateAutomationDriver();
        }


        [Given(@"I am on the bbc news website")]
        public void GivenIAmOnTheBbcNewsWebsite()
        {
            driver.Navigate().GoToUrl("http://bbc.co.uk");
        }
        
        [When(@"I access the UK section")]
        public void WhenIAccessTheUKSection()
        {
            driver.FindElement(By.ClassName("navigation-wide-list")).Click();
            
            // use page object in future!! 
        }
        
        [When(@"I perform a search for '(.*)'")]
        public void WhenIPerformASearchFor(string searchTerm)
        {
            // use page object in future!! 
            driver.FindElement(By.Id("orb-search-q")).SendKeys("Trump");
            driver.FindElement(By.Id("orb-search-button")).Click();
        }
        
        [Then(@"UK related news articles should be displayed")]
        public void ThenUKRelatedNewsArticlesShouldBeDisplayed()
        {
            Assert.IsTrue(driver.Url == "http://bbc.co.uk/news/uk");
        }
        
        [Then(@"news articles relating to Trump should be displayed")]
        public void ThenNewsArticlesRelatingToTrumpShouldBeDisplayed()
        {
            var result = driver.FindElement(By.LinkText("Trump takes office"));

            Assert.IsNotNull(result);
            //h1[itemprop = headline] > a
        }

        [AfterFeature]
        public static void AfterFeature() {
            if (driver != null) driver.Quit();
        }
    }
}
