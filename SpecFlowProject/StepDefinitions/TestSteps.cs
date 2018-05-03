using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Collections.ObjectModel;

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
            IWebElement shoppingCart = driver.FindElement(By.CssSelector(".minicart.parbase"));
        }

        [Then(@"I should be able to navigate to the about page")]
        public void ThenIShouldBeAbleToNavigateToTheAboutPage()
        {

            ReadOnlyCollection<IWebElement> buttons = driver.FindElements(By.XPath("//a[@role='button']"));
            foreach(IWebElement button in buttons) {
                Console.WriteLine(button.GetAttribute("text"));
                if (button.GetAttribute("text").Contains("About")) {
                    button.Click();
                    break;
                }
            }

        }


        [Then(@"chill for a while")]
        public void ThenChillForAWhile() {
            System.Threading.Thread.Sleep(5000);
        }

        [Then(@"I should see the White guide logo")]
        public void ThenIShouldSeeTheWhiteGuideLogo()
        {
            IWebElement logo = driver.FindElement(By.ClassName("logo"));
        }


        [After]
        public void TearDown() {
            driver.Close();
        }
    }



}
