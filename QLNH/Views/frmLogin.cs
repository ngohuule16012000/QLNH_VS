using QLNH.DAO;
using QLNH.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNH.Views
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        // sự kiện nhấn Login
        private void btnLogin_Click(object sender, EventArgs e)
        {
            // lấy giá trị từ textbox
            string userName = txbUsername.Text;
            string passWord = txbPassWord.Text;
            if (Login(userName, passWord))
            {
                // gọi AccountDAO lấy data account từ username truyền vào
                Account loginAccount = AccountDAO.Instance.GetAccountByUserName(userName);

                // khởi tạo form Table Manager truyền loginAccount
                frmTableManager f = new frmTableManager(loginAccount);

                // đóng form Login
                this.Hide();

                // hiện form TableManager dưới dạng Dialog
                f.ShowDialog();

                // đóng dialog thì hiện form Login
                this.Show();
            }
            else
            {
                MessageBox.Show("Username or password is wrong!");
            }
        }

        bool Login(string username, string password)
        {
            // lấy data từ AccountDAO
            return AccountDAO.Instance.Login(username, password);
        }

        // thoát khỏi ứng dụng
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // gọi sự kiện hiện Message box sau khi nhấn Exit
        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Không nhấn Ok thì ko thực thi event.
            if(MessageBox.Show("Do you want to exit?", "Message", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
    }
}
