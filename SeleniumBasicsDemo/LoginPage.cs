using OpenQA.Selenium;
using System;

namespace SeleniumBasicsDemo
{

    class LoginPage
    {
        private IWebDriver driver;
      
        public LoginPage(IWebDriver driver)
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

        private IWebElement logoutField
        {
            get
            {
                return driver.FindElement(By.LinkText("Logout"));
            }
        }

        public MainPage Login(String login, String passwod)
        {
            loginField.SendKeys(login);
            passwordField.SendKeys(passwod);
            passwordField.Submit();
         
            return new MainPage(driver);
        }
        public MainPage Logout()
        {
            logoutField.Click();

            return new MainPage(driver);
        }
    }
}
