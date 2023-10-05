using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNH.Model
{
    public class Account
    {
        public Account(string userName, string displayName, int type, string images, string passWord = null)
        {
            this.UserName = userName;
            this.DisplayName = displayName;
            this.Type = type;
            this.Images = images;
            this.PassWord = passWord;
        }

        public Account(DataRow row)
        {
            this.UserName = row["userName"].ToString();
            this.DisplayName = row["displayName"].ToString();
            this.Type = (int)row["type"];
            this.Images = row["Images"].ToString();
            this.PassWord = row["PassWord"].ToString();
        }

        private string userName;
        private string displayName;
        private string passWord;
        private int type;
        private string images;

        public string UserName { get => userName; set => userName = value; }
        public string DisplayName { get => displayName; set => displayName = value; }
        public int Type { get => type; set => type = value; }
        public string PassWord { get => passWord; set => passWord = value; }
        public string Images { get => images; set => images = value; }
    }
}
