using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumCSharpTutorials.BaseClass;
using System.Threading;
using OpenQA.Selenium.Support.UI;

namespace SeleniumCSharpTutorials
{
    [TestFixture]
    public class TestClass : BaseTest
    {
        [Test, Category("Smoke Testing")]
        public void TestMethod1()
        {
            Thread.Sleep(2000);
            //IWebElement cookieButton = driver.FindElement(By.XPath(".//button[@title='Zezwól tylko na niezbędne pliki cookie']"));
            IWebElement cookieButton = driver.FindElement(By.XPath(".//button[@data-cookiebanner='accept_button']"));
            cookieButton.Click();

            IWebElement emailTextField=driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTextField.SendKeys("Selenium C#");
            Thread.Sleep(2000);

            IWebElement regButton = driver.FindElement(By.XPath("//a[@role='button'][@data-testid='open-registration-form-button']"));
            regButton.Click();
            Thread.Sleep(2000);

            IWebElement monthDropDownList=driver.FindElement(By.XPath(".//*[@id='month']"));
            SelectElement element = new SelectElement(monthDropDownList);
            element.SelectByIndex(1); //Select by Index
            element.SelectByText("mar"); // Select by test
            element.SelectByValue("6"); // Select by value
            Thread.Sleep(2000);
        }

        //[Test, Category("Regression Testing")]
        //public void TestMethod2()
        //{
        //    IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@id='email']"));
        //    emailTextField.SendKeys("Selenium C#");
        //}

        //[Test, Category("Smoke Testing")]
        //public void TestMethod3()
        //{
        //    IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@id='email']"));
        //    emailTextField.SendKeys("Selenium C#");
        //    Thread.Sleep(5000);
        //}
    }
}
