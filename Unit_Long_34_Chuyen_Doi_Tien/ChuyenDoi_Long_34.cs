using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit_Long_34_Chuyen_Doi_Tien
{

    public class ChuyenDoi_Long_34
    {
        // Tỷ giá USD sang EUR
        private decimal usdToEurRate_long_34;
        // Tỷ giá USD sang VND
        private decimal usdToVndRate_long_34;

        // Constructor để khởi tạo lớp ChuyenDoi_Long_34
        public ChuyenDoi_Long_34(decimal usdToEurRate, decimal usdToVndRate)
        {
            // Kiểm tra nếu tỷ giá là âm hoặc bằng 0
            if (usdToEurRate <= 0 || usdToVndRate <= 0)
                // Ném một ngoại lệ nếu tỷ giá không hợp lệ
                throw new ArgumentException("Exchange rates must be positive");

            // Gán tỷ giá vào biến thành viên
            this.usdToEurRate_long_34 = usdToEurRate;
            this.usdToVndRate_long_34 = usdToVndRate;
        }

        // Phương thức chuyển đổi USD sang EUR
        public decimal ConvertUsdToEur_Long_34(decimal amountInUsd)
        {
            // Kiểm tra nếu số lượng tiền âm
            if (amountInUsd < 0)
                // Ném một ngoại lệ nếu số tiền âm
                throw new ArgumentException("Amount cannot be negative");
            // Chuyển đổi số lượng tiền từ USD sang EUR và trả về kết quả
            return amountInUsd * usdToEurRate_long_34;
        }

        // Phương thức chuyển đổi USD sang VND
        public decimal ConvertUsdToVnd_Long_34(decimal amountInUsd)
        {
            // Kiểm tra nếu số lượng tiền âm
            if (amountInUsd < 0)
                // Ném một ngoại lệ nếu số tiền âm
                throw new ArgumentException("Amount cannot be negative");
            // Chuyển đổi số lượng tiền từ USD sang VND và trả về kết quả
            return amountInUsd * usdToVndRate_long_34;
        }

        // Phương thức chuyển đổi EUR sang USD
        public decimal ConvertEurToUsd_Long_34(decimal amountInEur)
        {
            // Kiểm tra nếu số lượng tiền âm
            if (amountInEur < 0)
                // Ném một ngoại lệ nếu số tiền âm
                throw new ArgumentException("Amount cannot be negative");
            // Chuyển đổi số lượng tiền từ EUR sang USD và trả về kết quả
            return amountInEur / usdToEurRate_long_34;
        }

        // Phương thức chuyển đổi VND sang USD
        public decimal ConvertVndToUsd_Long_34(decimal amountInVnd)
        {
            // Kiểm tra nếu số lượng tiền âm
            if (amountInVnd < 0)
                // Ném một ngoại lệ nếu số tiền âm
                throw new ArgumentException("Amount cannot be negative");
            // Chuyển đổi số lượng tiền từ VND sang USD và trả về kết quả
            return amountInVnd / usdToVndRate_long_34;
        }
    }
}
