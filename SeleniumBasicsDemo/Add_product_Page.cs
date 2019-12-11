using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumBasicsDemo
{
    class Add_product_Page
    {
        private IWebDriver driver;

        public Add_product_Page(IWebDriver driver)
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
        private IWebElement Create_new
        {
            get
            {
                return driver.FindElement(By.LinkText("Create new"));
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

        public MainPage Add(String product, String unitptice, String quantityperunit,  
            String unitsinsrock, String unitsonorder, String reorderlevel)
        {
            loginField.SendKeys("user");
            passwordField.SendKeys("user");
            passwordField.Submit();

            All_Products.Click();
            Create_new.Click();
            Product_Name.SendKeys(product);
            Product_Name.Click();

            Category_Id.Click();
            Category_Id.FindElement(By.XPath("//option[. = 'Beverages']")).Click();
            Supplier_Id.Click();
            Supplier_Id.FindElement(By.XPath("//option[. = 'Tokyo Traders']")).Click();

            Unit_Price.SendKeys(unitptice);
            Unit_Price.Click();
            QuantityPer_Unit.SendKeys(quantityperunit);
            QuantityPer_Unit.Click();
            UnitsIn_Stock.SendKeys(unitsinsrock);
            Unit_Price.Click();
            UnitsOn_Order.SendKeys(unitsonorder);
            UnitsOn_Order.Click();
            Reorder_Level.SendKeys(reorderlevel);
            Reorder_Level.Click();
            Button_OK.Click();

            return new MainPage(driver);
        }
    }
}
