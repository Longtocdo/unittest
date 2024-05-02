using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace UnitTestMXH
{
    [TestClass]
    public class TestSearch
    {
        // Phương thức kiểm tra tìm kiếm thành công
        //[Ignore] // Bỏ qua phương thức kiểm tra này khi chạy
        [TestMethod]
        public void SerchSuccess()
        {
            // Tên người dùng và mật khẩu
            string name = "longtocdo03";
            string pass = "prolaanh00";

            // Khởi tạo driver Chrome
            ChromeDriverService chrome = ChromeDriverService.CreateDefaultService();
            chrome.HideCommandPromptWindow = true;
            IWebDriver driver = new ChromeDriver(chrome);

            // Điều hướng đến trang Instagram
            driver.Navigate().GoToUrl("https://www.instagram.com/");

            // Nhập tên người dùng và mật khẩu, sau đó đăng nhập
            driver.FindElement(By.CssSelector("input[type='text']")).SendKeys(name);
            driver.FindElement(By.CssSelector("input[type='password']")).SendKeys(pass);
            driver.FindElement(By.CssSelector("button._acan._acap._acas._aj1-._ap30")).Click();
            Thread.Sleep(4000);

            // Điều hướng đến trang người dùng đang theo dõi
            driver.Navigate().GoToUrl("https://www.instagram.com/longtocdo03/following/?next=%2F");
            Thread.Sleep(3000);

            // Tìm kiếm Adele và chuyển đến trang cá nhân của Adele
            driver.FindElement(By.CssSelector("input[type='text']")).SendKeys("adele");
            Thread.Sleep(3000);
            driver.FindElement(By.CssSelector("span._ap3a._aaco._aacw._aacx._aad7._aade")).Click();

            // Kiểm tra URL hiện tại
            Assert.AreEqual(driver.Url, "https://www.instagram.com/adele/?next=%2F");
        }

        // Phương thức kiểm tra tìm kiếm không thành công
        [TestMethod]
        public void SerchFailure()
        {
            // Tên người dùng và mật khẩu
            string name = "longtocdo03";
            string pass = "prolaanh00";

            // Khởi tạo driver Chrome
            ChromeDriverService chrome = ChromeDriverService.CreateDefaultService();
            chrome.HideCommandPromptWindow = true;
            IWebDriver driver = new ChromeDriver(chrome);

            // Điều hướng đến trang Instagram
            driver.Navigate().GoToUrl("https://www.instagram.com/");

            // Nhập tên người dùng và mật khẩu, sau đó đăng nhập
            driver.FindElement(By.CssSelector("input[type='text']")).SendKeys(name);
            driver.FindElement(By.CssSelector("input[type='password']")).SendKeys(pass);
            driver.FindElement(By.CssSelector("button._acan._acap._acas._aj1-._ap30")).Click();
            Thread.Sleep(4000);

            // Điều hướng đến trang người dùng đang theo dõi
            driver.Navigate().GoToUrl("https://www.instagram.com/longtocdo03/following/?next=%2F");
            Thread.Sleep(3000);

            // Tìm kiếm tên người dùng, kỳ vọng không tìm thấy kết quả
            driver.FindElement(By.CssSelector("input[type='text']")).SendKeys(name);
            Thread.Sleep(3000);
            IWebElement resultElm = driver.FindElement(By.ClassName("_aano"));
            string result = resultElm.Text;

            // Kiểm tra thông báo
            Assert.AreEqual(result, "No results found.");
        }
    }
}
