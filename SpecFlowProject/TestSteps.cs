using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

using TechTalk.SpecFlow;

namespace SpecFlowProject
{
    [Binding]
    public class TestSteps {

        IWebDriver driver = new ChromeDriver();

        [Given(@"I have navigated to ""(.*)""")]
        public void GivenIHaveNavigatedTo(string p0)
        {
            driver.Url = p0;
        }


        [Then(@"I should be able to see the link to the shopping cart")]
        public void ThenIShouldBeAbleToSeeTheLinkToTheShoppingCart()
        {
            IWebElement shoppingCart = driver.FindElement(By.CssSelector(".minicart.parbahse"));
        }


    }



}
