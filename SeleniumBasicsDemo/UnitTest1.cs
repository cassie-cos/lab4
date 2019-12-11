using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;

namespace SeleniumBasicsDemo
{
    [TestClass]
    public class TestNwapp
    {
        IWebDriver driver;

        [TestMethod]
        public void Login_logout_app()
        {
            driver = new ChromeDriver();
            driver.Url = "http://localhost:5000";

            LoginPage loginPage = new LoginPage(driver);
            Assert.IsTrue(loginPage.Login("user", "user").isLoginSuccessfull(), "failed to login");
            Assert.IsTrue(loginPage.Logout().isLogoutSuccessfull(), "failed to login");
        }

     


        [TestMethod]
        public void AddProduct_app()
        {
            driver = new ChromeDriver();
            driver.Url = "http://localhost:5000";

            Add_product_Page AddPage = new Add_product_Page(driver);
            Assert.IsTrue(AddPage.Add("test", "80", "30 in", "40", "40", "5").isAddSuccessfull(), "failed to add");
        }

        [TestMethod]
        public void B_ExistProduct_app()
        {
            driver = new ChromeDriver();
            driver.Url = "http://localhost:5000";

            Ex_product_Page Exist = new Ex_product_Page(driver);
            Assert.IsTrue(Exist.Exist().isNameSuccessfull(), "no product");
        }


        [TestMethod]
        public void DeleteProduct_app()
        {
            driver = new ChromeDriver();
            driver.Url = "http://localhost:5000";

            Delete_Page Delete = new Delete_Page(driver);
            Assert.IsTrue(Delete.Delete().isDeleteSuccessfull(), "failed to deled");
        }


        [TestCleanup]
        public void closeBrowserr()
        {
            driver.Close();
        }
    }
}
