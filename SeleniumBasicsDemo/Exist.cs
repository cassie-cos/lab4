using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumBasicsDemo
{
    class Ex_product_Page
    {
        private IWebDriver driver;

        public Ex_product_Page(IWebDriver driver)
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

        private IWebElement Element
        {
            get
            {
                return driver.FindElement(By.LinkText("test"));
            }
        }

        private IWebElement Product_Name
        {
            get
            {
                return driver.FindElement(By.Id("ProductName"));
            }
        }

        private IWebElement Category_Id
        {
            get
            {
                return driver.FindElement(By.Id("CategoryId"));
            }
        }

        private IWebElement Supplier_Id
        {
            get
            {
                return driver.FindElement(By.Id("SupplierId"));
            }
        }

        private IWebElement Unit_Price
        {
            get
            {
                return driver.FindElement(By.Id("UnitPrice"));
            }
        }

        private IWebElement QuantityPer_Unit
        {
            get
            {
                return driver.FindElement(By.Id("QuantityPerUnit"));
            }
        }

        private IWebElement UnitsIn_Stock
        {
            get
            {
                return driver.FindElement(By.Id("UnitsInStock"));
            }
        }

        private IWebElement UnitsOn_Order
        {
            get
            {
                return driver.FindElement(By.Id("UnitsOnOrder"));
            }
        }

        private IWebElement Reorder_Level
        {
            get
            {
                return driver.FindElement(By.Id("ReorderLevel"));
            }
        }

        private IWebElement Button_OK
        {
            get
            {
                return driver.FindElement(By.CssSelector(".btn"));
            }
        }


        public MainPage Exist()
        {
            loginField.SendKeys("user");
            passwordField.SendKeys("user");
            passwordField.Submit();

            All_Products.Click();
            Element.Click();

            Assert.AreEqual(Product_Name.GetAttribute("value"), "test");
            Assert.AreEqual(Category_Id.FindElement(By.CssSelector("#CategoryId > option:nth-child(2)")).GetAttribute("text"), "Beverages");
            Assert.AreEqual(Supplier_Id.FindElement(By.CssSelector("#SupplierId > option:nth-child(5)")).GetAttribute("text"), "Tokyo Traders");
            Assert.AreEqual(Unit_Price.GetAttribute("value"), "80,0000");
            Assert.AreEqual(QuantityPer_Unit.GetAttribute("value"), "30 in");
            Assert.AreEqual(UnitsIn_Stock.GetAttribute("value"), "40");
            Assert.AreEqual(UnitsOn_Order.GetAttribute("value"), "40");
            Assert.AreEqual(Reorder_Level.GetAttribute("value"), "5");

            Button_OK.Click();

            return new MainPage(driver);
        }

    }
}
