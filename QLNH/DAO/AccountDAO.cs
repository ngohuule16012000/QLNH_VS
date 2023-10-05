using QLNH.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace QLNH.DAO
{
    public class AccountDAO
    {
        // singleton
        private static AccountDAO instance;

        public static AccountDAO Instance 
        {
            get { if (instance == null) instance = new AccountDAO(); return instance; }
            private set => instance = value; 
        }

        private AccountDAO() { }

        public List<Account> SearchAccountByName(string name)
        {
            List<Account> list = new List<Account>();

            string query = string.Format("select * from Account where dbo.fuChuyenCoDauThanhKhongDau(UserName) like N'%' + dbo.fuChuyenCoDauThanhKhongDau(N'{0}') + '%'", name);

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Account account = new Account(item);
                list.Add(account);
            }

            return list;
        }

        // kiểm tra đăng nhập
        public bool Login(string userName, string passWord)
        {
            // mã hoá password
            byte[] temp = ASCIIEncoding.ASCII.GetBytes(passWord);
            
            // hash pass
            byte[] hasData = new MD5CryptoServiceProvider().ComputeHash(temp);

            // chuyển chuỗi
            string hasPass = "";

            foreach (byte item in hasData)
            {
                hasPass += item;
            }
            //var list = hasData.ToString();
            //list.Reverse();

            // sử dụng store produre tránh sql injection
            string query = "exec USP_Login @userName , @passWord";

            // sử dụng hàm ExecuteQuery từ DataProvider
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { userName, hasPass /*list*/ });

            return result.Rows.Count > 0;
        }

        // trả kết quả update account từ db
        public bool UpdateAccount(string userName, string displayName, string pass, string newPass, string image)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("exec USP_UpdateAccount @userName , @displayName , @password , @newPassword , @image", new object[] { userName, displayName, pass, newPass, image});

            return result > 0;
        }

        // gọi ExecuteQuery từ DataProvider thực thi query lấy danh sách Account trả về dạng DataTalbe
        public DataTable GetListAccount()
        {
            return DataProvider.Instance.ExecuteQuery("select UserName, DisplayName, Type, Images from Account");
        }

        // lấy account từ username
        public Account GetAccountByUserName(string userName)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("select * from account where userName = '" + userName +"'");

            foreach(DataRow item in data.Rows)
            {
                return new Account(item);
            }

            return null;
        }

        // thêm account vào db
        public bool InsertAccount(string name, string displayName, int type, string image)
        {
            string query = string.Format("insert Account(UserName, DisplayName, Type, PassWord, Images) values (N'{0}', N'{1}', {2}, N'{3}', N'{4}')", name, displayName, type, "20720532132149213101239102231223249249135100218", image);

            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        // sửa account vào db
        public bool UpdateAccount(string name, string displayName, int type, string image)
        {
            string query = string.Format("update Account set DisplayName = N'{1}', Type = {2}, Images = N'{3}' where UserName = N'{0}'", name, displayName, type, image);

            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        // xoá account trong db
        public bool DeleteAccount(string name)
        {
            string query = string.Format("delete Account where UserName = N'{0}'", name);

            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        // reset pass trong dp
        public bool ResetPassword(string name)
        {
            // pass 0: 20720532132149213101239102231223249249135100218
            string query = string.Format("update Account set passWord = N'20720532132149213101239102231223249249135100218' where UserName = N'{0}'", name);

            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
    }
}
