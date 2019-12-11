using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumBasicsDemo
{
    class Delete_Page
    {
        
        private IWebDriver driver;

        public Delete_Page(IWebDriver driver)
        {
            this.driver = driver;
        }

        private IWebElement loginField
        {
            get
            {
                return driver.FindElement(By.Id("Name"));
            }
        }

        private IWebElement passwordField
        {
            get
            {
                return driver.FindElement(By.Id("Password"));
            }
        }

        private IWebElement All_Products
        {
            get
            {
                return driver.FindElement(By.LinkText("All Products"));
            }
        }

        private IWebElement Product_Name
        {
            get
            {
                return driver.FindElement(By.Id("ProductName"));
            }
        }
       
        private IWebElement Button_OK
        {
            get
            {
                return driver.FindElement(By.CssSelector(".btn"));
            }
        }

        private IWebElement Element
        {
            get
            {
                return driver.FindElement(By.XPath("/html/body/div[3]/table/tbody/tr[78]/td[12]/a"));
                 
            }
        }

        public MainPage Delete()
        {
            loginField.SendKeys("user");
            passwordField.SendKeys("user");
            passwordField.Submit();

            All_Products.Click();
            Element.Click();
            string DialogWindow = driver.SwitchTo().Alert().Text;
            Assert.AreEqual(DialogWindow, "Are you sure?");
            driver.SwitchTo().Alert().Accept();

            return new MainPage(driver);
        }
    }
}
