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
    public partial class frmMergeTable : Form
    {
        public frmMergeTable()
        {
            InitializeComponent();

            LoadTableName();
            
        }

        private void LoadTableName()
        {
            pbMerge.Image = IconDAO.Instance.setIconButtonAndImage("icons8-right-50.png");

            List<Table> listTable = TableDAO.Instance.LoadTableList();

            // đổ vào ComboBox
            cbTable.DataSource = listTable;

            cbTable.DisplayMember = "Name";

            foreach (Table item in listTable)
            {
                clbTable.Items.Add(item.Name);
            }

        }

        private event EventHandler<MergeTableEvent> mergeTable;
        public event EventHandler<MergeTableEvent> MergeTable
        {
            add { mergeTable += value; }
            remove { mergeTable -= value; }
        }

        private void btnMerge_Click(object sender, EventArgs e)
        {
            List<int> mergeTableFrom = new List<int>();
            int mergeTableTo = TableDAO.Instance.GetIdTableByNameTable((cbTable.SelectedItem as Table).Name);
            foreach (string item in clbTable.CheckedItems)
            {
                mergeTableFrom.Add(TableDAO.Instance.GetIdTableByNameTable(item));
            }
            
            if (mergeTableFrom.Count() == 0)
            {
                MessageBox.Show("Please check any merge table from!");
            }
            else if (mergeTableTo.Equals(""))
            {
                MessageBox.Show("Please chose a merge table to!");
            }
            else
            {
                string mess = "Do you want to merge table from ";
                foreach(string item in clbTable.CheckedItems)
                {
                    mess += item + " ";
                }
                mess += "to " + (cbTable.SelectedItem as Table).Name;

                if (MessageBox.Show(mess, "Message", MessageBoxButtons.OKCancel)
                == DialogResult.OK)
                {
                    try
                    {
                        foreach (int item in mergeTableFrom)
                        {
                            TableDAO.Instance.MergeTable(item, mergeTableTo);
                        }


                        for (int i = 0; i < clbTable.Items.Count; i++)
                        {
                            clbTable.SetItemChecked(i, false);
                        }
                        MessageBox.Show("Merge table complete.");

                        if (mergeTable != null)
                        {
                            mergeTable(this, new MergeTableEvent(TableDAO.Instance.LoadTableList()));
                        }
                    }
                    catch (Exception) { }
                    
                }
                
            }
        }
    }

    public class MergeTableEvent : EventArgs
    {
        private List<Table> tables;

        public List<Table> Tables { get => tables; set => tables = value; }

        public MergeTableEvent(List<Table> tables)
        {
            this.Tables = tables;
        }
    }
}
