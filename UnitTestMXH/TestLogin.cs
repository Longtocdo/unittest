using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace UnitTestMXH
{
    // Đánh dấu lớp TestLogin là một lớp chứa các phương thức kiểm tra đăng nhập
    //[Ignore] // Bỏ qua lớp này khi chạy các bài kiểm tra
    [Ignore]
    [TestClass]
    public class TestLogin
    {
        // Phương thức kiểm tra đăng nhập thành công
        [TestMethod]
        public void LoginSuccess_Long_34()
        {
            // Tên người dùng và mật khẩu
            string name_long_34 = "longtocdo03";
            string pass_long_34 = "prolaanh00";

            // Khởi tạo driver Chrome
            ChromeDriverService chrome = ChromeDriverService.CreateDefaultService();
            chrome.HideCommandPromptWindow = true;
            IWebDriver driver = new ChromeDriver(chrome);

            // Điều hướng đến trang Instagram
            driver.Navigate().GoToUrl("https://www.instagram.com/");

            // Nhập tên người dùng và mật khẩu, sau đó đăng nhập
            driver.FindElement(By.CssSelector("input[type='text']")).SendKeys(name_long_34);
            driver.FindElement(By.CssSelector("input[type='password']")).SendKeys(pass_long_34);
            driver.FindElement(By.CssSelector("button._acan._acap._acas._aj1-._ap30")).Click();

            // Kiểm tra URL hiện tại
            Assert.AreEqual(driver.Url, "https://www.instagram.com/");
        }
        public TestContext TestContext { get; set; }


        // Phương thức kiểm tra đăng nhập với mật khẩu sai
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
            @"D:\unittest\UnitTestMXH\DataLoginFail.csv", "DataLoginFail#csv",
            DataAccessMethod.Sequential)]
        [TestMethod]
        public void LoginFailure_Long_34_WrongUsername()
        {
            // Đọc dữ liệu đầu vào từ file CSV
            string name_long_34 = TestContext.DataRow[0].ToString();
            string pass_long_34 = TestContext.DataRow[1].ToString();

            // Khởi tạo driver Chrome
            ChromeDriverService chrome = ChromeDriverService.CreateDefaultService();
            chrome.HideCommandPromptWindow = true;
            IWebDriver driver = new ChromeDriver(chrome);

            // Điều hướng đến trang Instagram
            driver.Navigate().GoToUrl("https://www.instagram.com/");

            // Nhập tên người dùng và mật khẩu, sau đó đăng nhập
            driver.FindElement(By.CssSelector("input[type='text']")).SendKeys(name_long_34);
            driver.FindElement(By.CssSelector("input[type='password']")).SendKeys(pass_long_34);
            driver.FindElement(By.CssSelector("button._acan._acap._acas._aj1-._ap30")).Click();

            // Chờ hiển thị thông báo
            Thread.Sleep(2000);

            // Lấy văn bản của thông báo nếu tồn tại
            IWebElement notificationElement = driver.FindElement(By.XPath("//*[@id=\"loginForm\"]/span/div"));
            string notification = notificationElement.Text;

            // Kiểm tra thông báo
            Assert.AreEqual(notification, "Sorry, your password was incorrect. Please double-check your password.");

            // Đóng trình duyệt
            driver.Quit();
        }

        // Phương thức kiểm tra đăng nhập với mật khẩu sai từ file CSV khác
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
           @"D:\unittest\UnitTestMXH\LoginWrongPass.csv", "LoginWrongPass#csv",
           DataAccessMethod.Sequential)]
        [TestMethod]
        public void LoginWrongPass_Long_34()
        {
            // Đọc dữ liệu đầu vào từ file CSV
            string name_long_34 = TestContext.DataRow[0].ToString();
            string pass_long_34 = TestContext.DataRow[1].ToString();

            // Khởi tạo driver Chrome
            ChromeDriverService chrome = ChromeDriverService.CreateDefaultService();
            chrome.HideCommandPromptWindow = true;
            IWebDriver driver = new ChromeDriver(chrome);

            // Điều hướng đến trang Instagram
            driver.Navigate().GoToUrl("https://www.instagram.com/");

            // Nhập tên người dùng và mật khẩu, sau đó đăng nhập
            driver.FindElement(By.CssSelector("input[type='text']")).SendKeys(name_long_34);
            driver.FindElement(By.CssSelector("input[type='password']")).SendKeys(pass_long_34);
            driver.FindElement(By.CssSelector("button._acan._acap._acas._aj1-._ap30")).Click();

            // Chờ hiển thị thông báo
            Thread.Sleep(2000);

            // Lấy văn bản của thông báo nếu tồn tại
            IWebElement notificationElement = driver.FindElement(By.ClassName("_ab2z"));
            string notification = notificationElement.Text;

            // Kiểm tra thông báo
            Assert.AreEqual(notification, "Sorry, your password was incorrect. Please double-check your password.");

            // Đóng trình duyệt
            driver.Quit();
        }
    }
}
