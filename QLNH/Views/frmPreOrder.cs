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
    public partial class frmPreOrder : Form
    {
        private static int tableIdglobal = -1;
        public frmPreOrder()
        {
            InitializeComponent();

            Load();
            LoadTable();
        }

        private void LoadTable()
        {
            flpTable.Controls.Clear();

            //lấy data
            List<Table> tableList = TableDAO.Instance.LoadTableList();

            foreach (Table item in tableList)
            {
                // tạo button width và height
                Button btn = new Button() { Width = TableDAO.TableWidth, Height = TableDAO.TableHeight };
                btn.Text = item.Name + Environment.NewLine; // Environment.NewLine = \n
                btn.TextAlign = ContentAlignment.BottomCenter;
                btn.Font = new Font(btn.Font, FontStyle.Bold);

                // set event
                btn.Click += btn_Click;

                // lưu item vào button
                btn.Tag = item;

                string status = "Empty";
                if (TableOrderDAO.Instance.GetStatusById(item.ID, mcDateCheck.SelectionStart))
                {
                    status = "Order";
                }
                bool ckyear = DateTime.Now.Year == mcDateCheck.SelectionStart.Year;
                bool ckmonth = DateTime.Now.Month == mcDateCheck.SelectionStart.Month;
                bool ckday = DateTime.Now.Day == mcDateCheck.SelectionStart.Day;
                // set màu cho status
                if (item.Status == "Full" && ckyear && ckmonth && ckday)
                {
                    btn.Text += item.Status;
                    btn.Image = IconDAO.Instance.setIconButtonAndImage("icons8-table-49.png");
                    //btn.Image = Properties.Resources.icons8_table_49;
                    btn.ImageAlign = ContentAlignment.TopCenter;
                    btn.BackColor = Color.DarkViolet;
                    btn.ForeColor = Color.White;
                }
                else
                {
                    switch (status)
                    {
                        case "Empty":
                            // button Add Food

                            if (item.Status == "Full")
                            {
                                btn.Text += "Empty";
                            }
                            else
                            {
                                btn.Text += item.Status;
                            }
                            btn.Image = IconDAO.Instance.setIconButtonAndImage("icons8-table-47.png");
                            btn.ImageAlign = ContentAlignment.TopCenter;
                            btn.BackColor = Color.LightYellow;
                            break;
                        default:
                            btn.Text += "Ordered";
                            btn.Image = IconDAO.Instance.setIconButtonAndImage("icons8-table-49.png");
                            //btn.Image = Properties.Resources.icons8_table_49;
                            btn.ImageAlign = ContentAlignment.TopCenter;
                            btn.BackColor = Color.DarkGreen;
                            btn.ForeColor = Color.White;
                            break;
                    }
                }

                // thêm button vào flow layout panel
                flpTable.Controls.Add(btn);
            }
        }

        private void btn_Click(object sender, EventArgs e)
        {
            int tableID = ((sender as Button).Tag as Table).ID;
            tableIdglobal = tableID;
            lbTableName.Text = TableDAO.Instance.GetTableNameByIdTable(tableIdglobal);

            if (TableOrderDAO.Instance.GetStatusById(tableIdglobal, mcDateCheck.SelectionStart))
            {
                btnUnOrder.Enabled = true;
                lbDate.Text = TableOrderDAO.Instance.GetTimeByIdAndDate(tableID, mcDateCheck.SelectionStart);
            }
            else
            {
                btnUnOrder.Enabled = false;
                lbDate.Text = "Null";
            }

            
        }

        private void Load()
        {
            // set combobox hour
            List<int> Hour = new List<int>();
            int i;
            for(i = 0; i < 24; i++)
            {
                Hour.Add(i);
            }
            cbHour.DataSource = Hour;

            // set combobox minute
            List<int> Minute = new List<int>();
            for (i = 0; i < 60; i++)
            {
                Minute.Add(i);
            }
            cbMinute.DataSource = Minute;

            //button Search Table
            btnSearchTable.Image = IconDAO.Instance.setIconButtonAndImage("icons8-search-24.png");

            lbCalendar.Text = mcDateCheck.SelectionStart.ToString().Split(' ')[0];

            // xoá order cũ
            TableOrderDAO.Instance.DeleteOrderLastDate();

        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            if(tableIdglobal == -1)
            {
                MessageBox.Show("Please choose a table!");
                return;
            }
            bool ckyear = DateTime.Now.Year == mcDateCheck.SelectionStart.Year;
            bool ckmonth = DateTime.Now.Month == mcDateCheck.SelectionStart.Month;
            bool ckday = DateTime.Now.Day == mcDateCheck.SelectionStart.Day;
            if (TableOrderDAO.Instance.GetStatusById(tableIdglobal, mcDateCheck.SelectionStart) || (TableDAO.Instance.CheckFull(tableIdglobal) 
                && ckyear && ckmonth && ckday))
            {
                MessageBox.Show("Please choose another table!");
            }
            else
            {
                int year = mcDateCheck.SelectionStart.Year;
                int month = mcDateCheck.SelectionStart.Month;
                int day = mcDateCheck.SelectionStart.Day;
                int hour = (int)cbHour.SelectedItem;
                int minute = (int)cbMinute.SelectedItem;
                if(DateTime.Now.Year <= year && DateTime.Now.Month <= month && DateTime.Now.Day <= day)
                {
                    TableOrderDAO.Instance.SetOrder(tableIdglobal, new DateTime(year, month, day, hour, minute, 0));
                    // load date
                    lbDate.Text = TableOrderDAO.Instance.GetTimeByIdAndDate(tableIdglobal, mcDateCheck.SelectionStart);
                    LoadTable();
                }
                else
                {
                    MessageBox.Show("Please choose another date!");
                }
                
            }
            

            
        }

        private void btnSearchTable_Click(object sender, EventArgs e)
        {
           
            flpTable.Controls.Clear();
            List<Table> tableList;

            if ("order".Contains(txbSearchTableName.Text.ToLower()))
            {
                tableList = TableDAO.Instance.GetListTableOrderOnDate();
            }
            else
            {
                tableList = TableDAO.Instance.SearchForLoadTableOrder(txbSearchTableName.Text);
            }

            foreach (Table item in tableList)
            {
                // loại bỏ order if status là empty
                if ("empty".Contains(txbSearchTableName.Text.ToLower()))
                {
                    if (TableOrderDAO.Instance.GetStatusById(item.ID, mcDateCheck.SelectionStart))
                    {
                        continue;
                    }
                }
                // tạo button width và height
                Button btn = new Button() { Width = TableDAO.TableWidth, Height = TableDAO.TableHeight };
                btn.Text = item.Name + Environment.NewLine; // Environment.NewLine = \n
                btn.TextAlign = ContentAlignment.BottomCenter;
                btn.Font = new Font(btn.Font, FontStyle.Bold);

                string status = "Empty";
                if (TableOrderDAO.Instance.GetStatusById(item.ID, mcDateCheck.SelectionStart))
                {
                    status = "Order";
                }

                // set màu cho status
                if (item.Status == "Full")
                {
                    btn.Text += item.Status;
                    btn.Image = IconDAO.Instance.setIconButtonAndImage("icons8-table-49.png");
                    //btn.Image = Properties.Resources.icons8_table_49;
                    btn.ImageAlign = ContentAlignment.TopCenter;
                    btn.BackColor = Color.DarkViolet;
                    btn.ForeColor = Color.White;
                }
                else
                {
                    switch (status)
                    {
                        case "Empty":
                            // button Add Food
                            btn.Text += item.Status;
                            btn.Image = IconDAO.Instance.setIconButtonAndImage("icons8-table-47.png");
                            btn.ImageAlign = ContentAlignment.TopCenter;
                            btn.BackColor = Color.LightYellow;
                            break;
                        default:
                            btn.Text += "Ordered";
                            btn.Image = IconDAO.Instance.setIconButtonAndImage("icons8-table-49.png");
                            //btn.Image = Properties.Resources.icons8_table_49;
                            btn.ImageAlign = ContentAlignment.TopCenter;
                            btn.BackColor = Color.DarkGreen;
                            btn.ForeColor = Color.White;
                            break;
                    }
                }

                // set event
                btn.Click += btn_Click;

                // lưu item vào button
                btn.Tag = item;


                // thêm button vào flow layout panel
                flpTable.Controls.Add(btn);
            }
        }

        private void btnUnOrder_Click(object sender, EventArgs e)
        {
            if (tableIdglobal == -1)
            {
                MessageBox.Show("Please choose a table!");
                return;
            }

            TableOrderDAO.Instance.DeleteOrder(tableIdglobal, mcDateCheck.SelectionStart);
            LoadTable();
        }

        private void mcDateCheck_DateChanged(object sender, DateRangeEventArgs e)
        {
            LoadTable();
            lbCalendar.Text = mcDateCheck.SelectionStart.ToString().Split(' ')[0];
        }

        private void btnViewList_Click(object sender, EventArgs e)
        {
            frmListTableOrdered f = new frmListTableOrdered();
            f.ShowDialog();
        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(string.Format("Do you sure to want to delete all on {0}", mcDateCheck.SelectionStart.ToString().Split(' ')[0]), "Message", MessageBoxButtons.OKCancel)
                == DialogResult.OK)
            {
                TableOrderDAO.Instance.DeleteAllInDate(mcDateCheck.SelectionStart);
                LoadTable();
            }
        }

        private void lbTableName_Click(object sender, EventArgs e)
        {

        }
    }
}
