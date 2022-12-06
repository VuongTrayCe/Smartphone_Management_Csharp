using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Smartphone_Management.GUI.GUI_SanPham.ValidateData
{
    internal class ValidateData
    {
        /* ======================== CÁC PHƯƠNG THỨC VALIDATE CÁC THUỘC TÍNH TRÊN  ========================*/

        private static string posiTntDifferent_0_Regex = @"^[1-9]+[0-9]*$";
        private static string posiIntContains_0_Regex = @"^[0-9]+$";
        private static string isInt_Regex = @"^[-+]?\d+$";
        private static string onlyLetter_Regex = @"[a-zA-Z]+";
        private static string onlyLetterAndNumber_Regex = @"^[A-Za-z0-9]*$";
        private static string isNumber_Regex = @"^(-?[1-9]+\d*([.]\d+)?)$|^(-?0[.]\d*[1-9]+)$|^0$|^0.0$";

        //---------------------------------------------------------------------------------------------------------------------
        // Name phải nhiều hơn numChar ký tự, chỉ gồm chữ
        public bool validateName(string name)
        {
            name = name.Trim();
            return Regex.IsMatch(name, onlyLetter_Regex);
        }
        public bool validateName(string name, int numChar)
        {
            name = name.Trim();
            return Regex.IsMatch(name, onlyLetter_Regex) && name.Length > numChar;
        }


        //---------------------------------------------------------------------------------------------------------------------
        // Username phải nhiều hơn numChar ký tự, chỉ gồm chữ và số

        public bool validateUserName(string username)
        {
            username = username.Trim();
            return Regex.IsMatch(username, onlyLetterAndNumber_Regex);
        }
        public bool validateUserName(string username, int numChar)
        {
            username = username.Trim();
            return Regex.IsMatch(username, onlyLetterAndNumber_Regex) && username.Length > numChar;
        }

        //---------------------------------------------------------------------------------------------------------------------
        // Mật khẩu nhiều hơn numChar ký tự, gồm chữ hoa, chữ thường, ký tự đặc biệt và số
        public bool validatePassword(string password)
        {
            password = password.Trim();
            return Regex.IsMatch(password, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{0,}$");
        }

        public bool validatePassword(string password, int numChar)
        {
            password = password.Trim();
            return Regex.IsMatch(password, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{" + numChar + ",}$");
        }

        //---------------------------------------------------------------------------------------------------------------------
        // Số điện thoại việt nam 
        public bool validatePhone(string phone)
        {
            phone = phone.Trim();
            return Regex.IsMatch(phone, @"(03|05|07|08|09|01[2|6|8|9])+([0-9]{8})\b");
        }

        //---------------------------------------------------------------------------------------------------------------------
        // Email gồm tên miền, ký tự @
        public bool validateEmail(string email)
        {
            email = email.Trim();
            return Regex.IsMatch(email, @"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$");
        }

        //---------------------------------------------------------------------------------------------------------------------
        // Chứng minh nhân dân phải đủ 9 số
        public bool validateCMND(string cmnd)
        {
            cmnd = cmnd.Trim();
            return Regex.IsMatch(cmnd, posiIntContains_0_Regex) && cmnd.Length == 9;
        }

        //---------------------------------------------------------------------------------------------------------------------
        // Kiểm tra chuỗi rỗng
        public bool validateEmpty(string str)
        {
            str = str.Trim();
            if (str.Length == 0)
                return false;
            else
                return true;
        }

        //---------------------------------------------------------------------------------------------------------------------
        // Kiểm tra tuổi từ 0 - num tuổi
        public bool validateAge(string age, int num)
        {
            age = age.Trim();
            return Regex.IsMatch(age, posiIntContains_0_Regex) && int.Parse(age) < num;
        }

        //---------------------------------------------------------------------------------------------------------------------
        // Kiểm tra giá tiền
        public bool validatePrice(string price)
        {
            price = price.Trim();
            var result = Decimal.TryParse(price, out decimal d);
            return result && d >= 0;
        }

        //---------------------------------------------------------------------------------------------------------------------
        // Kiểm tra là số
        public bool validateNumber(string num)
        {
            num = num.Trim();
            return Regex.IsMatch(num, isNumber_Regex);
        }

        //---------------------------------------------------------------------------------------------------------------------
        // Kiểm tra là số nguyên dương khác 0
        public bool validatePosiTntDifferentZero(string num)
        {
            num = num.Trim();
            return Regex.IsMatch(num, posiTntDifferent_0_Regex);
        }

        //---------------------------------------------------------------------------------------------------------------------
        // Kiểm tra số lượng, là số nguyên, >= 0
        public bool validateQuantity(string num)
        {
            num = num.Trim();
            return Regex.IsMatch(num, isInt_Regex) && int.Parse(num) >= 0;
        }

        //---------------------------------------------------------------------------------------------------------------------
        // Format giá tiền
        public string formatPriceVND(string price)
        {
            price = price.Trim();
            return double.Parse(price).ToString("#,###", CultureInfo.GetCultureInfo("vi-VN").NumberFormat) + "đ";
        }

        public string formatPriceUSD(string price)
        {
            price = price.Trim();
            return "$" + double.Parse(price).ToString("#,###", CultureInfo.GetCultureInfo("en-US").NumberFormat);
        }

    }
}
