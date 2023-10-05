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
    public partial class frmTaxDiscount : Form
    {
        public frmTaxDiscount(int tax, int discount)
        {
            InitializeComponent();
            nmTax.Value = tax;
            nmDiscount.Value = discount;
        }

        private void nmTax_ValueChanged(object sender, EventArgs e)
        {
            TaxDiscount.Tax = (int)nmTax.Value;
        }

        private void nmDiscount_ValueChanged(object sender, EventArgs e)
        {
            TaxDiscount.Discount = (int)nmDiscount.Value;
        }
    }
}
