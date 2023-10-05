using QLNH.DAO;
using QLNH.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Menu = QLNH.Model.Menu;
namespace QLNH.Views
{
    public partial class frmBill : Form
    {
        private static int getIdBill = -1;
        private static double getDiscount = -1;
        private static double getTotalPrice = -1;
        private static int lengthLine = 60;
        private static int iDTable = -1;
        public frmBill(int idTable, string tableName, int idBill, List<Menu> list, double discount, double totalPrice, double tax)
        {
            InitializeComponent();
            iDTable = idTable;
            LoadBill(tableName, idBill, list, discount, totalPrice, tax);
        }


        private void LoadBill(string tableName, int idBill, List<Menu> list, double discount, double totalPrice, double tax)
        {
            getIdBill = idBill;
            getDiscount = discount;
            getTotalPrice = totalPrice;
            lbTable.Text = "Table " + tableName;
            lbBill.Text = "Bill No." + idBill;
            DateTime now = DateTime.Now;
            lbDate.Text = "Date: " + now;
            string mess = "Bill detail\n";
            CultureInfo culture = new CultureInfo("vi-VN"); //en-US

            tlpFoodBill.RowCount = list.Count();
            tlpFoodBill.Height += (list.Count() - 1) * 24;
            
            int countRow = 0;
            double price = 0;
            foreach (Menu item in list)
            {
                Label temp1 = new Label();
                Label temp2 = new Label();
                temp1.Width = 250;
                temp1.Text = item.Count + " " + item.FoodName;
                temp2.Text = item.TotalPrice.ToString("c", culture).Replace(",00 ₫", "");
                temp2.TextAlign = ContentAlignment.MiddleRight;
                tlpFoodBill.Controls.Add(temp1, 0, countRow);
                tlpFoodBill.Controls.Add(temp2, 1, countRow);
                countRow += 1;
                price += item.TotalPrice;
            }


            Label t1 = new Label();
            Label t2 = new Label();
            t1.Text = "Price:";
            t2.Text = price.ToString("c", culture).Replace(",00 ₫", "");
            t2.TextAlign = ContentAlignment.MiddleRight;
            tlpPrice.Controls.Add(t1, 0, 0);
            tlpPrice.Controls.Add(t2, 1, 0);
            
            label2.Text = new string('-', 100);

            int h = countRow * 24;

            //change location form to fit form
            this.Height += h;
            panel1.Height += h;
            panel3.Height += h;
            label6.Location = new Point(label6.Location.X, label6.Location.Y + h);
            label2.Location = new Point(label2.Location.X, label2.Location.Y + h);
            btnCheck.Location = new Point(btnCheck.Location.X, btnCheck.Location.Y + h);
            tlpPrice.Location = new Point(tlpPrice.Location.X, tlpPrice.Location.Y + h);

            // discount
            Label disc1 = new Label();
            disc1.Text = "Discount:";
            Label disc2 = new Label();
            disc2.TextAlign = ContentAlignment.MiddleRight;
            disc2.Text = discount.ToString("c", culture).Replace(",00 ₫", "");
            tlpBill.Controls.Add(disc1, 0, 0);
            tlpBill.Controls.Add(disc2, 1, 0);

            //tax
            Label tax1 = new Label();
            tax1.Text = "Tax:";
            Label tax2 = new Label();
            tax2.TextAlign = ContentAlignment.MiddleRight;
            tax2.Text = tax.ToString("c", culture).Replace(",00 ₫", "");
            tlpBill.Controls.Add(tax1, 0, 1);
            tlpBill.Controls.Add(tax2, 1, 1);

            //Total
            Label total1 = new Label();
            total1.Text = "Total:";
            Label total2 = new Label();
            total2.TextAlign = ContentAlignment.MiddleRight;
            total2.Text = totalPrice.ToString("c", culture).Replace(",00 ₫", "");
            tlpBill.Controls.Add(total1, 0, 2);
            tlpBill.Controls.Add(total2, 1, 2);
            tlpBill.Location = new Point(tlpBill.Location.X, tlpBill.Location.Y + h);

            lbDetail.Text = mess;
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (getIdBill != -1 && getDiscount != -1 && getTotalPrice != -1)
            {
                // gọi CheckOut
                BillDAO.Instance.CheckOut(getIdBill, (int)getDiscount, (float)getTotalPrice);

                // delete re order by date
                int year = DateTime.Now.Year;
                int month = DateTime.Now.Month;
                int day = DateTime.Now.Day;
                TableOrderDAO.Instance.DeleteOrder(iDTable, new DateTime(year, month, day, 0, 0, 0));

                MessageBox.Show("Check bill successful.");
                this.Hide();
            }
            else
            {
                MessageBox.Show("Erorr check bill!");
            }
        }

        private void tlpPrice_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
