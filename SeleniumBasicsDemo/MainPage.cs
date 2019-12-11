using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumBasicsDemo
{
    class MainPage
    {
        private IWebDriver driver;

        public MainPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public bool isLoginSuccessfull()
        {
            bool isLoginSuccessfull = false;
            try
            {
                IWebElement homePageLabel = driver.FindElement(By.XPath(".//*[text()='Home page']"));
                isLoginSuccessfull = homePageLabel.Displayed;
            }
            catch (NoSuchElementException e)
            {
                isLoginSuccessfull = false;
            }
            return isLoginSuccessfull;
        }

        public bool isLogoutSuccessfull()
        {
            bool isLogoutSuccessfull = false;
            try
            {
                IWebElement logoimg = driver.FindElement(By.XPath(".//*[text()='Login']"));
                isLogoutSuccessfull = logoimg.Displayed;
            }
            catch (NoSuchElementException e)
            {
                isLogoutSuccessfull = false;
            }
            return isLogoutSuccessfull;
        }

        public bool isAddSuccessfull()
        {
            bool isAddSuccessfull = false;
            try
            {

                IWebElement add = driver.FindElement(By.LinkText("test"));
                isAddSuccessfull = add.Displayed;
            }
            catch (NoSuchElementException e)
            {
                isAddSuccessfull = false;
            }
            return isAddSuccessfull;
        }
        public bool isNameSuccessfull()
        {
            bool isNameSuccessfull = false;
            try
            {

                IWebElement add = driver.FindElement(By.LinkText("All Products"));
                isNameSuccessfull = add.Displayed;
            }
            catch (NoSuchElementException e)
            {
                isNameSuccessfull = false;
            }
            return isNameSuccessfull;
        }

        public bool isDeleteSuccessfull()
        {
            bool isDeleteSuccessfull = false;
            try
            {
                IWebElement Delete = driver.FindElement(By.LinkText("test"));
                isDeleteSuccessfull = Delete.Displayed;
            }
            catch (NoSuchElementException e)
            {
                isDeleteSuccessfull = false;
            }
            return isDeleteSuccessfull;
        }
    }
}