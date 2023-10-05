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
    public partial class frmAccountProfile : Form
    {
        private Account loginAccount;

        public Account LoginAccount
        {
            get { return loginAccount; }
            set { loginAccount = value; ChangeAccount(loginAccount); }
        }
        public frmAccountProfile(Account acc)
        {
            InitializeComponent();

            LoginAccount = acc;

            if (!loginAccount.Images.Equals(""))
                pbProfile.Image = IconDAO.Instance.setIconButtonAndImage(acc.Images);
        }

        // thay đổi thông tin account trong textbox
        void ChangeAccount(Account acc)
        {
            txbUsername.Text = loginAccount.UserName;
            txbDisplayName.Text = loginAccount.DisplayName;
        }

        // cập nhật thông tin account
        void UpdateAccountInfo()
        {
            string displayName = txbDisplayName.Text;
            string password = txbPassWord.Text;
            string newpass = txbNewPass.Text;
            string reenterPass = txbReEnterPass.Text;
            string userName = txbUsername.Text;
            string image = LoginAccount.Images;

            if (!newpass.Equals(reenterPass))
            {
                MessageBox.Show("Please re-enter the correct password with the new password!");
            }
            else
            {
                if (AccountDAO.Instance.UpdateAccount(userName, displayName, password, newpass, image))
                {
                    MessageBox.Show("Update successful.");
                    if (updateAccount != null)
                    {
                        // cập nhật thành công trả về username cho Account event
                        updateAccount(this, new AccountEvent(AccountDAO.Instance.GetAccountByUserName(userName)));
                    }
                }
                else
                {
                    MessageBox.Show("Please enter the correct password!");
                }
            }
        }

        // tạo sự kiện update
        private event EventHandler<AccountEvent> updateAccount;

        public event EventHandler<AccountEvent> UpdateAccount
        {
            add { updateAccount += value; }
            remove
            {
                updateAccount -= value;
            }
        }

        // sự kiện thoát form
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // sự kiện cập nhật form
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateAccountInfo();
        }

    }

    public class AccountEvent : EventArgs
    {
        private Account acc;

        public Account Acc { get => acc; set => acc = value; }

        public AccountEvent(Account acc)
        {
            this.Acc = acc;
        }
    }
}
