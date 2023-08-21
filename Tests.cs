using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using RestSharp;

namespace Tests
{
    class ListOfTests : Jsonplaceholder
    {
        [Test]
        public void GetUsersList()
        {
            RestResponse response = GetUsersRequest();
            Assert.AreEqual("OK", response.StatusCode.ToString());
            Assert.IsTrue(response.Content.Contains("sunt aut facere repellat provident occaecati excepturi optio reprehenderit"));
        }

        [Test]
        public void CreateNewUser()
        {
            RestResponse response = CreateUserRequest();
            Assert.AreEqual("Created", response.StatusCode.ToString());
            Assert.IsTrue(response.Content.Contains("sunt aut facere repellat provident occaecati excepturi optio reprehenderit"));
        }

        [Test]
        public void DeleteUser()
        {
            RestResponse response = DeleteUserRequest();
            Assert.AreEqual("OK", response.StatusCode.ToString());
        }

        [Test]
        public void EditUser()
        {
            RestResponse response = CreateUserRequest();
            Assert.AreEqual("Created", response.StatusCode.ToString());
            Assert.IsTrue(response.Content.Contains("sunt aut facere repellat provident occaecati excepturi optio reprehenderit"));
        }


        [Test]
        public void CheckPageTitle()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://jsonplaceholder.typicode.com/";
            IWebElement Title = driver.FindElement(By.CssSelector("[class='text-6xl bold']"));

            Assert.True(Title.Displayed);
            driver.Close();
        }

        [Test]
        public void CheckNavigation()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://jsonplaceholder.typicode.com/";

            IWebElement runScriptBtn = driver.FindElement(By.CssSelector("[id='run-button']"));
            IWebElement guideBtn = driver.FindElement(By.CssSelector("[class='mr-4 no-underline']"));
            IWebElement result = driver.FindElement(By.CssSelector("[id='result']"));


            runScriptBtn.Click();
            Assert.True(result.Displayed);
            guideBtn.Click();
            driver.Close();
        }
    }
}
