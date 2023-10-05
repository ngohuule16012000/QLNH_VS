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
    public partial class frmListTableOrdered : Form
    {
        BindingSource tableOrderList = new BindingSource();
        public frmListTableOrdered()
        {
            InitializeComponent();

            Load();

            LoadTableOrder();
        }

        private void Load()
        {
            dtgvTableOrder.DataSource = tableOrderList;

            nmMonth.Value = mcDateCheck.SelectionStart.Month;

            nmYear.Value = mcDateCheck.SelectionStart.Year;

            btnSearchTableOrder.Image = IconDAO.Instance.setIconButtonAndImage("icons8-search-24.png");
        }

        private void LoadTableOrder()
        {
            tableOrderList.DataSource = TableOrderDAO.Instance.GetListTableOrder();
        }

        private void btnSearchTable_Click(object sender, EventArgs e)
        {
            tableOrderList.DataSource = SearchTableOrderByName(txbSearchTableOrderName.Text);
        }

        List<TableOrder> SearchTableOrderByName(string name)
        {
            List<TableOrder> listTableOrder = TableOrderDAO.Instance.SearchTableOrderByName(name);

            return listTableOrder;
        }

        void GetListTableOrderByDate()
        {
            int month = (int)nmMonth.Value;
            int year = (int)nmYear.Value;
            tableOrderList.DataSource = TableOrderDAO.Instance.GetListTableOrderByDate(month, year);
        }

        private void nmMonth_ValueChanged(object sender, EventArgs e)
        {
            GetListTableOrderByDate();
        }

        private void nmYear_ValueChanged(object sender, EventArgs e)
        {
            GetListTableOrderByDate();
        }
    }
}
