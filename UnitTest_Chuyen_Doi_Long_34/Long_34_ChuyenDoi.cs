using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Unit_Long_34_Chuyen_Doi_Tien;

namespace CurrencyConverterTests
{
    [Ignore]
    [TestClass] // Đánh dấu lớp UnitTest_Long_34 là một lớp kiểm thử
    public class UnitTest_Long_34
    {
        private ChuyenDoi_Long_34 converter; // Khai báo một biến đối tượng ChuyenDoi_Long_34 để kiểm tra
        public TestContext TestContext { get; set; } // Khai báo một đối tượng TestContext để truy cập dữ liệu test

        [TestInitialize] // Thiết lập dữ liệu dùng chung cho các test case trước khi chạy
        public void SetUp_Long_34()
        {
            // Khởi tạo đối tượng ChuyenDoi_Long_34 với tỷ giá USD sang EUR và VND cố định
            decimal usdToEurRate_Long_34 = 0.85m;
            decimal usdToVndRate_Long_34 = 23000m;
            converter = new ChuyenDoi_Long_34(usdToEurRate_Long_34, usdToVndRate_Long_34);
        }

        [TestMethod] // Đánh dấu phương thức Test_ConvertUsdToEur_Long_34 là một test case
        public void Test_ConvertUsdToEur_Long_34()
        {
            decimal amountInUsd_Long_34 = 100; // Số tiền USD cần chuyển đổi
            decimal expected = 85; // Kết quả mong đợi khi chuyển đổi từ USD sang EUR với tỷ giá 0.85
            decimal actual = converter.ConvertUsdToEur_Long_34(amountInUsd_Long_34); // Thực hiện chuyển đổi
            Assert.AreEqual(expected, actual); // So sánh kết quả thực tế với kết quả mong đợi
        }

        [TestMethod] // Đánh dấu phương thức Test_ConvertUsdToVnd_Long_34 là một test case
        public void Test_ConvertUsdToVnd_Long_34()
        {
            decimal amountInUsd_Long_34 = 100; // Số tiền USD cần chuyển đổi
            decimal expected = 2300000; // Kết quả mong đợi khi chuyển đổi từ USD sang VND với tỷ giá 23000
            decimal actual = converter.ConvertUsdToVnd_Long_34(amountInUsd_Long_34); // Thực hiện chuyển đổi
            Assert.AreEqual(expected, actual); // So sánh kết quả thực tế với kết quả mong đợi
        }

        [TestMethod] // Đánh dấu phương thức Test_ConvertEurToUsd_Long_34 là một test case
        public void Test_ConvertEurToUsd_Long_34()
        {
            decimal amountInEur_Long_34 = 85; // Số tiền EUR cần chuyển đổi
            decimal expected = 100; // Kết quả mong đợi khi chuyển đổi từ EUR sang USD với tỷ giá 0.85
            decimal actual = converter.ConvertEurToUsd_Long_34(amountInEur_Long_34); // Thực hiện chuyển đổi
            Assert.AreEqual(expected, actual); // So sánh kết quả thực tế với kết quả mong đợi
        }

        [TestMethod] // Đánh dấu phương thức Test_ConvertVndToUsd_Long_34 là một test case
        public void Test_ConvertVndToUsd_Long_34()
        {
            decimal amountInVnd_Long_34 = 2300000; // Số tiền VND cần chuyển đổi
            decimal expected = 100; // Kết quả mong đợi khi chuyển đổi từ VND sang USD với tỷ giá 23000
            decimal actual = converter.ConvertVndToUsd_Long_34(amountInVnd_Long_34); // Thực hiện chuyển đổi
            Assert.AreEqual(expected, actual); // So sánh kết quả thực tế với kết quả mong đợi
        }

        [TestMethod] // Kiểm tra ngoại lệ khi số tiền âm
        [ExpectedException(typeof(ArgumentException))] // Kỳ vọng ném ra ngoại lệ loại ArgumentException
        public void Test_NegativeAmount_Long_34()
        {
            converter.ConvertUsdToEur_Long_34(-1); // Thực hiện chuyển đổi với số tiền âm, ngoại lệ sẽ được ném ra
        }

        // Test với dữ liệu đọc từ file .csv
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
                  "D:\\unittest\\UnitTest_Chuyen_Doi_Long_34\\CurrencyConverter_Long_34.csv","CurrencyConverter_Long_34#csv",
          DataAccessMethod.Sequential)]
        [TestMethod]
        public void TestWithDataSource_Long_34()
        {
            try
            {
                decimal amount_Long_34 = decimal.Parse(TestContext.DataRow[0].ToString()); // Lấy số tiền từ dữ liệu test
                string fromCurrency_Long_34 = TestContext.DataRow[1].ToString(); // Lấy đơn vị tiền tệ đầu vào từ dữ liệu test
                string toCurrency_Long_34 = TestContext.DataRow[2].ToString(); // Lấy đơn vị tiền tệ đầu ra từ dữ liệu test
                decimal expected = decimal.Parse(TestContext.DataRow[3].ToString()); // Lấy kết quả mong đợi từ dữ liệu test

                decimal actual = 0; // Khởi tạo biến lưu kết quả thực tế của chuyển đổi
                switch (fromCurrency_Long_34)
                {
                    case "USD": // Nếu đơn vị tiền tệ đầu vào là USD
                        if (toCurrency_Long_34 == "EUR") // Nếu đơn vị tiền tệ đầu ra là EUR
                            actual = converter.ConvertUsdToEur_Long_34(amount_Long_34); // Thực hiện chuyển đổi từ USD sang EUR
                        else if (toCurrency_Long_34 == "VND") // Nếu đơn vị tiền tệ đầu ra là VND
                            actual = converter.ConvertUsdToVnd_Long_34(amount_Long_34); // Thực hiện chuyển đổi từ USD sang VND
                        break;
                    case "EUR": // Nếu đơn vị tiền tệ đầu vào là EUR
                        if (toCurrency_Long_34 == "USD") // Nếu đơn vị tiền tệ đầu ra là USD
                            actual = converter.ConvertEurToUsd_Long_34(amount_Long_34); // Thực hiện chuyển đổi từ EUR sang USD
                        break;
                    case "VND": // Nếu đơn vị tiền tệ đầu vào là VND
                        if (toCurrency_Long_34 == "USD") // Nếu đơn vị tiền tệ đầu ra là USD
                            actual = converter.ConvertVndToUsd_Long_34(amount_Long_34); // Thực hiện chuyển đổi từ VND sang USD
                        break;
                }

                Assert.AreEqual(expected, actual); // So sánh kết quả thực tế với kết quả mong đợi
            }
            catch (Exception ex)
            {
                Assert.Fail($"Test failed with exception: {ex.Message}");
            }
        }
    }
}
