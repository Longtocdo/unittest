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
    //[Ignore]
    [TestClass]
    public class TestSearch
    {
        // Phương thức kiểm tra tìm kiếm thành công
        //[Ignore] // Bỏ qua phương thức kiểm tra này khi chạy
        [TestMethod]
        public void SerchSuccess_Long_34()
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
            Thread.Sleep(4000);
            // Điều hướng đến trang người dùng đang theo dõi
            Thread.Sleep(3000);

            // Tìm kiếm Adele và chuyển đến trang cá nhân của Adele
            driver.Navigate().GoToUrl("https://www.instagram.com/longtocdo03/?next=%2F");
            Thread.Sleep(3000);

            long_34_drive.Click();
            driver.FindElement(By.CssSelector("body > div.x1n2onr6.xzkaem6 > div:nth-child(2) > div > div > div.x9f619.x1n2onr6.x1ja2u2z > div > div.x1uvtmcs.x4k7w5x.x1h91t0o.x1beo9mf.xaigb6o.x12ejxvf.x3igimt.xarpa2k.xedcshv.x1lytzrv.x1t2pt76.x7ja8zs.x1n2onr6.x1qrby5j.x1jfb8zj > div > div > div > div > div.x7r02ix.xf1ldfh.x131esax.xdajt7p.xxfnqb6.xb88tzc.xw2csxc.x1odjw0f.x5fp0pe > div > div > div.xwib8y2.x1swvt13.x1pi30zi.x1y1aw1k > div > input")).SendKeys("adele");
            Thread.Sleep(3000);
            driver.FindElement(By.CssSelector("span._ap3a._aaco._aacw._aacx._aad7._aade")).Click();

            // Kiểm tra URL hiện tại
            Assert.AreEqual(driver.Url, "https://www.instagram.com/adele/?next=%2F");
        }

        // Phương thức kiểm tra tìm kiếm không thành công
        [Ignore]
        [TestMethod]
        public void SerchFailure_Long_34()
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
            Thread.Sleep(4000);

            // Điều hướng đến trang người dùng đang theo dõi
            driver.Navigate().GoToUrl("https://www.instagram.com/longtocdo03/following/");
            Thread.Sleep(5000);

            // Tìm kiếm tên người dùng, kỳ vọng không tìm thấy kết quả
            driver.FindElement(By.CssSelector("input[type='text']")).SendKeys(name_long_34);
            Thread.Sleep(5000);
            IWebElement resultElm = driver.FindElement(By.ClassName("_aano"));
            string result = resultElm.Text;

            // Kiểm tra thông báo
            Assert.AreEqual(result, "No results found.");
        }
    }
}
