using QLNH.DAO;
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
    public partial class frmChartRevenue : Form
    {
        public frmChartRevenue()
        {
            InitializeComponent();
            LoadChart();
        }

        private void LoadChart()
        {
            chart1.Series["Money"].Points.Clear();
            int month = 1;
            DataTable dt;
            DateTime date1;
            DateTime date2;
            int year = (int)nmYear.Value;

            while (month < 12)
            {
                date1 = new DateTime(year, month, 1);
                date2 = date1.AddMonths(1).AddDays(-1);
                
                dt = BillDAO.Instance.GetTotalBillByDate(date1, date2);
                if (!dt.Rows[0][0].ToString().Equals(""))
                {
                    double total = Convert.ToDouble(dt.Rows[0][0].ToString());
                    chart1.Series["Money"].Points.AddXY(month, total);
                }
                else
                {
                    chart1.Series["Money"].Points.AddXY(month, 0);
                }
                        
                month += 1;
            }
        }

        private void nmYear_ValueChanged(object sender, EventArgs e)
        {
            LoadChart();
        }
    }
}
