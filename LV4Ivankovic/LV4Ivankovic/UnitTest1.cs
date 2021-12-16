using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace SeleniumTests
{
    [TestFixture]
    public class UntitledTestCase
    {
        private IWebDriver driver;
        private StringBuilder verificationErrors;
        private string baseURL;
        private bool acceptNextAlert = true;

        [SetUp]
        public void SetupTest()
        {
            driver = new FirefoxDriver();
            baseURL = "https://www.google.com/";
            verificationErrors = new StringBuilder();
        }

        [TearDown]
        public void TeardownTest()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
            Assert.AreEqual("", verificationErrors.ToString());
        }

        [Test]
        public void TheUntitledTestCaseTest()
        {
            driver.Navigate().GoToUrl("http://demowebshop.tricentis.com/");
            driver.FindElement(By.Id("pollanswers-1")).Click();
            driver.FindElement(By.Id("vote-poll-1")).Click();
            driver.FindElement(By.XPath("//input[@value='Go to cart']")).Click();
            driver.FindElement(By.Id("CountryId")).Click();
            new SelectElement(driver.FindElement(By.Id("CountryId"))).SelectByText("Antigua and Barbuda");
            driver.FindElement(By.Id("StateProvinceId")).Click();
            driver.FindElement(By.Id("StateProvinceId")).Click();
            driver.FindElement(By.Id("termsofservice")).Click();
            driver.FindElement(By.Name("giftcardcouponcode")).Click();
            driver.FindElement(By.Name("giftcardcouponcode")).Clear();
            driver.FindElement(By.Name("giftcardcouponcode")).SendKeys("abcde");
            driver.FindElement(By.Name("discountcouponcode")).Click();
            driver.FindElement(By.Name("discountcouponcode")).Clear();
            driver.FindElement(By.Name("discountcouponcode")).SendKeys("abcde");
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Enter your coupon here'])[1]/following::div[2]")).Click();
            driver.FindElement(By.Name("giftcardcouponcode")).Clear();
            driver.FindElement(By.Name("giftcardcouponcode")).SendKeys("---");
            driver.FindElement(By.Id("checkout")).Click();
            driver.FindElement(By.LinkText("Computers")).Click();
            driver.FindElement(By.XPath("//img[@alt='Picture for category Desktops']")).Click();
            driver.FindElement(By.LinkText("Desktop PC with CDRW")).Click();
            driver.FindElement(By.XPath("//form[@id='product-details-form']/div/div/div[2]")).Click();
            driver.FindElement(By.LinkText("Books")).Click();
            driver.FindElement(By.XPath("//input[@value='Add to cart']")).Click();
            driver.FindElement(By.XPath("//input[@value='Add to cart']")).Click();
            driver.FindElement(By.XPath("//input[@value='Add to cart']")).Click();
            driver.FindElement(By.XPath("//input[@value='Add to cart']")).Click();
            // ERROR: Caught exception [ERROR: Unsupported command [doubleClick | xpath=//input[@value='Add to cart'] | ]]
            driver.FindElement(By.XPath("//input[@value='Add to cart']")).Click();
            driver.FindElement(By.XPath("//input[@value='Add to cart']")).Click();
            driver.FindElement(By.XPath("//input[@value='Add to cart']")).Click();
            driver.FindElement(By.XPath("//input[@value='Add to cart']")).Click();
            driver.FindElement(By.XPath("//input[@value='Add to cart']")).Click();
            driver.FindElement(By.XPath("//input[@value='Add to cart']")).Click();
            driver.FindElement(By.LinkText("Copy of Computing and Internet EX")).Click();
            driver.FindElement(By.XPath("//img[@alt='Tricentis Demo Web Shop']")).Click();
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Desktop PC with CDRW'])[1]/following::a[2]")).Click();
            driver.FindElement(By.Id("addtocart_5_EnteredQuantity")).Click();
            driver.FindElement(By.Id("addtocart_5_EnteredQuantity")).Clear();
            driver.FindElement(By.Id("addtocart_5_EnteredQuantity")).SendKeys("-5");
            driver.FindElement(By.Id("add-to-cart-button-5")).Click();
            driver.FindElement(By.Id("addtocart_5_EnteredQuantity")).Click();
            driver.FindElement(By.Id("addtocart_5_EnteredQuantity")).Click();
            // ERROR: Caught exception [ERROR: Unsupported command [doubleClick | id=addtocart_5_EnteredQuantity | ]]
            driver.FindElement(By.Id("addtocart_5_EnteredQuantity")).Clear();
            driver.FindElement(By.Id("addtocart_5_EnteredQuantity")).SendKeys("10000");
            driver.FindElement(By.Id("add-to-cart-button-5")).Click();
            driver.FindElement(By.XPath("//img[@alt='Tricentis Demo Web Shop']")).Click();
            driver.FindElement(By.LinkText("News")).Click();
            driver.FindElement(By.LinkText("details")).Click();
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Leave your comment'])[1]/following::div[3]")).Click();
            // ERROR: Caught exception [ERROR: Unsupported command [doubleClick | id=AddNewComment_CommentTitle | ]]
            driver.FindElement(By.Id("AddNewComment_CommentTitle")).Clear();
            driver.FindElement(By.Id("AddNewComment_CommentTitle")).SendKeys("aaaaaaaaaaaaaaaa");
            driver.FindElement(By.Id("AddNewComment_CommentText")).Clear();
            driver.FindElement(By.Id("AddNewComment_CommentText")).SendKeys("aaaaaaaaaaaaaaaaaaaaaaaa");
            driver.FindElement(By.Name("add-comment")).Click();
            driver.FindElement(By.LinkText("Orders")).Click();
        }
        private bool IsElementPresent(By by)
        {
            try
            {
                driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        private bool IsAlertPresent()
        {
            try
            {
                driver.SwitchTo().Alert();
                return true;
            }
            catch (NoAlertPresentException)
            {
                return false;
            }
        }

        private string CloseAlertAndGetItsText()
        {
            try
            {
                IAlert alert = driver.SwitchTo().Alert();
                string alertText = alert.Text;
                if (acceptNextAlert)
                {
                    alert.Accept();
                }
                else
                {
                    alert.Dismiss();
                }
                return alertText;
            }
            finally
            {
                acceptNextAlert = true;
            }
        }
    }
}
