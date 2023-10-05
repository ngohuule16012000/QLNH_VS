using QLNH.DAO;
using QLNH.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNH.Views
{
    public partial class frmAdmin : Form
    {
        BindingSource foodList = new BindingSource();

        BindingSource categoryList = new BindingSource();

        BindingSource tableList = new BindingSource();

        BindingSource accountList = new BindingSource();

        public Account loginAccount;

        private string CurrentDirectory = System.IO.Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);

        public frmAdmin()
        {
            InitializeComponent();
            Load();
            
        }

        #region Method

        // trả về danh sách thức ăn được tìm kiếm
        List<Food> SearchFoodByName(string name)
        {
            List<Food> listFood = FoodDAO.Instance.SearchFoodByName(name);

            return listFood;
        }

        List<Category> SearchCategoryByName(string name)
        {
            List<Category> listCategory = CategoryDAO.Instance.SearchCategoryByName(name);

            return listCategory;
        }

        
        List<Table> SearchTableByName(string name)
        {
            List<Table> listTable = TableDAO.Instance.SearchTableByName(name);

            return listTable;
        }

        List<Account> SearchAccountByName(string name)
        {
            List<Account> listAccount = AccountDAO.Instance.SearchAccountByName(name);

            return listAccount;
        }

        private new void Load()
        {
            dtgvFood.DataSource = foodList;
            dtgvCategory.DataSource = categoryList;
            dtgvTable.DataSource = tableList;
            dtgvAccount.DataSource = accountList;

            setIconButton();

            LoadMonthYear();

            LoadDateTimePickerBill();

            LoadListBillByDate(dtpkFromDate.Value, dtpkToDate.Value);

            LoadListBillByYear(dtpkFromDate.Value, dtpkToDate.Value);

            LoadListFood();

            LoadListCategory();

            LoadListTable();

            LoadAccount();

            LoadCategoryIntoCombox(cbFoodCategory);

            AddFoodBinding();

            AddCategoryBinding();

            AddTableBinding();

            AddAccountBinding();
        }

        

        private void LoadMonthYear()
        {
            // set month
            nmMonth.Value = DateTime.Now.Month;

            // set year
            nmYear.Value = DateTime.Now.Year;
        }

        private void setIconButton()
        {
            // Food
            btnAddFood.Image = IconDAO.Instance.setIconButtonAndImage("icons8-add-24.png");
            btnDeleteFood.Image = IconDAO.Instance.setIconButtonAndImage("icons8-delete-24.png");
            btnEditFood.Image = IconDAO.Instance.setIconButtonAndImage("icons8-edit-24.png");
            btnShowFood.Image = IconDAO.Instance.setIconButtonAndImage("icons8-view-24.png");
            btnSearchFood.Image = IconDAO.Instance.setIconButtonAndImage("icons8-search-24.png");

            // Category
            btnAddCategory.Image = IconDAO.Instance.setIconButtonAndImage("icons8-add-24.png");
            btnDeleteCategory.Image = IconDAO.Instance.setIconButtonAndImage("icons8-delete-24.png");
            btnEditCategory.Image = IconDAO.Instance.setIconButtonAndImage("icons8-edit-24.png");
            btnShowCategory.Image = IconDAO.Instance.setIconButtonAndImage("icons8-view-24.png");
            btnSearchCategory.Image = IconDAO.Instance.setIconButtonAndImage("icons8-search-24.png");

            // Table
            btnAddTable.Image = IconDAO.Instance.setIconButtonAndImage("icons8-add-24.png");
            btnDeleteTable.Image = IconDAO.Instance.setIconButtonAndImage("icons8-delete-24.png");
            btnEditTable.Image = IconDAO.Instance.setIconButtonAndImage("icons8-edit-24.png");
            btnShowTable.Image = IconDAO.Instance.setIconButtonAndImage("icons8-view-24.png");
            btnSearchTable.Image = IconDAO.Instance.setIconButtonAndImage("icons8-search-24.png");

            // Account
            btnAddAccount.Image = IconDAO.Instance.setIconButtonAndImage("icons8-add-24.png");
            btnDeleteAccount.Image = IconDAO.Instance.setIconButtonAndImage("icons8-delete-24.png");
            btnEditAccount.Image = IconDAO.Instance.setIconButtonAndImage("icons8-edit-24.png");
            btnShowAccount.Image = IconDAO.Instance.setIconButtonAndImage("icons8-view-24.png");
            btnResetPassword.Image = IconDAO.Instance.setIconButtonAndImage("icons8-reset-24.png");
            btnSearchAccount.Image = IconDAO.Instance.setIconButtonAndImage("icons8-search-24.png");

            //Revenue
            btnChart.Image = IconDAO.Instance.setIconButtonAndImage("icons8-area-chart-48.png");


        }

        // đổ data vào textbox và numeric qua binding
        void AddAccountBinding()
        {
            txbUserName.DataBindings.Add(new Binding("Text", dtgvAccount.DataSource, "UserName", true, DataSourceUpdateMode.Never));
            txbDisplayName.DataBindings.Add(new Binding("Text", dtgvAccount.DataSource, "DisplayName", true, DataSourceUpdateMode.Never));
            nmAccountType.DataBindings.Add(new Binding("Value", dtgvAccount.DataSource, "Type", true, DataSourceUpdateMode.Never));
            txbImageAccount.DataBindings.Add(new Binding("Text", dtgvAccount.DataSource, "Images", true, DataSourceUpdateMode.Never));
        }

        // gọi AccountDAO lấy list account từ database
        void LoadAccount()
        {
            // đổ dữ liệu vào accountList
            accountList.DataSource = AccountDAO.Instance.GetListAccount();
        }

        // đặt mặc định ngày đầu tháng và cuối tháng trong time picker
        void LoadDateTimePickerBill()
        {
            DateTime today = DateTime.Now;

            dtpkFromDate.Value = new DateTime(today.Year, today.Month, 1);

            dtpkToDate.Value = dtpkFromDate.Value.AddMonths(1).AddDays(-1);
        }

        // gọi BillDAO lấy data list bill by date, đổ data vào data grid view Bill
        void LoadListBillByDate(DateTime checkIn, DateTime checkOut)
        {
            dtgvBill.DataSource = BillDAO.Instance.GetBillListByDate(checkIn, checkOut);

            using (DataTable dt = BillDAO.Instance.GetTotalBillByDate(checkIn, checkOut))
            {
                if (!dt.Rows[0][0].ToString().Equals(""))
                {
                    float total = (float)Convert.ToDouble(dt.Rows[0][0].ToString());
                    CultureInfo culture = new CultureInfo("vi-VN");
                    txbTotalMonth.Text = total.ToString("c", culture);
                }
                else
                {
                    txbTotalMonth.Text = "0";
                }
               
            }
        }

        private void LoadListBillByYear(DateTime checkIn, DateTime checkOut)
        {
            using (DataTable dt = BillDAO.Instance.GetTotalBillByYear(checkIn, checkOut))
            {
                if (!dt.Rows[0][0].ToString().Equals(""))
                {
                    float total = (float)Convert.ToDouble(dt.Rows[0][0].ToString());
                    CultureInfo culture = new CultureInfo("vi-VN");
                    txbTotalYear.Text = total.ToString("c", culture);
                }
                else
                {
                    txbTotalYear.Text = "0";
                }

            }
        }

        // tạo Binding hiển thị thông tin Food lên textbox và numeric
        void AddFoodBinding()
        {
            txbFoodName.DataBindings.Add(new Binding("Text", dtgvFood.DataSource, "Name", true, DataSourceUpdateMode.Never));
            txbFoodID.DataBindings.Add(new Binding("Text", dtgvFood.DataSource, "ID", true, DataSourceUpdateMode.Never));
            nmFoodPrice.DataBindings.Add(new Binding("Value", dtgvFood.DataSource, "Price", true, DataSourceUpdateMode.Never));
            txbImageFood.DataBindings.Add(new Binding("Text", dtgvFood.DataSource, "Image", true, DataSourceUpdateMode.Never));
        }

        // tạo Binding hiển thị thông tin Category lên textbox và numeric
        void AddCategoryBinding()
        {
            txbCategoryName.DataBindings.Add(new Binding("Text", dtgvCategory.DataSource, "Name", true, DataSourceUpdateMode.Never));
            txbCategoryID.DataBindings.Add(new Binding("Text", dtgvCategory.DataSource, "ID", true, DataSourceUpdateMode.Never));
            txbImageCategory.DataBindings.Add(new Binding("Text", dtgvCategory.DataSource, "Image", true, DataSourceUpdateMode.Never));

        }

        void AddTableBinding()
        {
            txbTableName.DataBindings.Add(new Binding("Text", dtgvTable.DataSource, "Name", true, DataSourceUpdateMode.Never));
            txbTableID.DataBindings.Add(new Binding("Text", dtgvTable.DataSource, "ID", true, DataSourceUpdateMode.Never));
            txbTableStatus.DataBindings.Add(new Binding("Text", dtgvTable.DataSource, "Status", true, DataSourceUpdateMode.Never));
        }

        // load Category vào combox
        void LoadCategoryIntoCombox(ComboBox cb)
        {
            cb.DataSource = CategoryDAO.Instance.GetListCategory();
            cb.DisplayMember = "Name";
        }

        // lấy danh sách thức ăn đổ vào foodList
        void LoadListFood()
        {
            foodList.DataSource = FoodDAO.Instance.GetListFood();
        }

        // lấy danh sách thức ăn đổ vào categoryList
        void LoadListCategory()
        {
            categoryList.DataSource = CategoryDAO.Instance.GetListCategory();
        }

        // lấy danh sách thức ăn đổ vào tableList
        void LoadListTable()
        {
            tableList.DataSource = TableDAO.Instance.GetListTable();
        }

        //thông báo thêm account
        void AddAccount(string userName, string displayName, int type, string image)
        {
            try
            {
                //không có ảnh thì lưu
                if (!image.Equals("") && !File.Exists(Upload.Instance.saveImage(image)))
                {
                    pbAccount.Image.Save(Upload.Instance.saveImage(image));
                    MessageBox.Show("Image saved.");
                }

                if (AccountDAO.Instance.InsertAccount(userName, displayName, type, image))
                {
                    MessageBox.Show("Add account successful.");
                }
                else
                {
                    MessageBox.Show("add account failed!");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("add account failed! Username existed.");
            }

            LoadAccount();
        }

        //thông báo sửa account
        void EditAccount(string userName, string displayName, int type, string image)
        {

            bool flag = false;

            try
            {
                if (!image.Equals(""))
                {
                    flag = true;
                }
                else
                {
                    if (MessageBox.Show("Image is empty. Do you set the image empty?", "Message", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        flag = true;
                    }
                }
            }
            catch (Exception) { }

            if (AccountDAO.Instance.UpdateAccount(userName, displayName, type, image) && flag==true)
            {
                MessageBox.Show("Update account successful.");
            }
            else
            {
                MessageBox.Show("Update account failed!");
            }

            LoadAccount();
        }

        //thông báo xoá account
        void DeleteAccount(string userName)
        {
            // không xoá tk đang sd
            if (loginAccount.UserName.Equals(userName))
            {
                MessageBox.Show("This account is using!");
                return;
            }

            if (AccountDAO.Instance.DeleteAccount(userName))
            {
                MessageBox.Show("Delete account successful.");
            }
            else
            {
                MessageBox.Show("Delete account failed!");
            }

            LoadAccount();
        }

        // thông báo reset pass
        void ResetPass(string userName)
        {
            if (AccountDAO.Instance.ResetPassword(userName))
            {
                MessageBox.Show("Reset password successful.");
            }
            else
            {
                MessageBox.Show("Reset password failed!");
            }
        }

        #endregion

        #region Events

        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            string userName = txbUserName.Text;

            string displayName = txbDisplayName.Text;

            int type = (int)nmAccountType.Value;

            string image = txbImageAccount.Text;

            AddAccount(userName, displayName, type, image);

        }

        private void btnEditAccount_Click(object sender, EventArgs e)
        {
            string userName = txbUserName.Text;

            string displayName = txbDisplayName.Text;

            int type = (int)nmAccountType.Value;

            string image = txbImageAccount.Text;

            EditAccount(userName, displayName, type, image);
        }

        private void btnDeleteAccount_Click(object sender, EventArgs e)
        {
            string userName = txbUserName.Text;
            bool flag = false;
            if (MessageBox.Show(string.Format("Do you want to delete account {0}", userName), "Delete", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                flag = true;
            }

            if (flag)
            {
                DeleteAccount(userName);
            }
        }

        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            string userName = txbUserName.Text;

            ResetPass(userName);
        }

        // sự kiện xem Account
        private void btnShowAccount_Click(object sender, EventArgs e)
        {
            LoadAccount();
        }

        // sự kiện nhấn Search food
        private void btnSearchFood_Click(object sender, EventArgs e)
        {
            foodList.DataSource = SearchFoodByName(txbSearchFoodName.Text);
        }

        // sự kiện khi id Food trên textbox thay đổi, thay đổi combo box category
        private void txbFoodID_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (dtgvFood.SelectedCells.Count > 0 && dtgvFood.SelectedCells[0].OwningRow.Cells["IDCategory"].Value != null)
                {
                    int id = (int)dtgvFood.SelectedCells[0].OwningRow.Cells["IDCategory"].Value;

                    // lấy category từ id của cột IDCategory
                    Category category = CategoryDAO.Instance.GetCategoryByID(id);

                    // đưa category lên combo box
                    cbFoodCategory.SelectedItem = category;

                    int index = -1;

                    int i = 0;

                    foreach (Category item in cbFoodCategory.Items)
                    {
                        if (item.ID == category.ID)
                        {
                            index = i;
                            break;
                        }
                        i++;
                    }

                    cbFoodCategory.SelectedIndex = index;

                    pbFood.Image = IconDAO.Instance.setIconButtonAndImage(txbImageFood.Text);
                }
            }
            catch { }
            
        }

        private void txbCategoryID_TextChanged(object sender, EventArgs e)
        {
            try
            {
                pbCategory.Image = IconDAO.Instance.setIconButtonAndImage(txbImageCategory.Text);
            }
            catch { }
        }

        private void txbUserName_TextChanged(object sender, EventArgs e)
        {
            if (!txbImageAccount.Text.Equals(""))
            {
                pbAccount.Image = IconDAO.Instance.setIconButtonAndImage(txbImageAccount.Text);
            }
            else
            {
                pbAccount.Image = IconDAO.Instance.setIconButtonAndImage("profile.png");
            }
                
        }

        // sự kiện thêm Food
        private void btnAddFood_Click(object sender, EventArgs e)
        {
            string name = txbFoodName.Text;

            int categoryID = (cbFoodCategory.SelectedItem as Category).ID;

            float price = (float)nmFoodPrice.Value;

            string image = txbImageFood.Text;

            try
            {
                //không có ảnh thì lưu
                if (!image.Equals("") && !File.Exists(Upload.Instance.saveImage(image)))
                {
                    pbFood.Image.Save(Upload.Instance.saveImage(image));
                    MessageBox.Show("Image saved.");
                }
            }
            catch (Exception) { }

            if (FoodDAO.Instance.InsertFood(name, categoryID, price, image))
            {
                MessageBox.Show("Add food successful.");
                LoadListFood();

                if (insertFood != null)
                {
                    // gọi sự kiện insert
                    insertFood(this, new EventArgs());
                }
            }
            else
            {
                MessageBox.Show("Error when adding the food!");
            }
        }

        // sự kiện sửa Food
        private void btnEditFood_Click(object sender, EventArgs e)
        {
            string name = txbFoodName.Text;

            int categoryID = (cbFoodCategory.SelectedItem as Category).ID;

            float price = (float)nmFoodPrice.Value;

            int id = Convert.ToInt32(txbFoodID.Text);

            string image = txbImageFood.Text;

            bool flag = false;

            try
            {
                if (!image.Equals(""))
                {
                    flag = true;
                }
                else
                {
                    if(MessageBox.Show("Image is empty. Do you set the image empty?", "Message", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        flag = true;
                    }
                }
                
            }
            catch (Exception) { }

            if (FoodDAO.Instance.UpdateFood(id, name, categoryID, price, image) && flag == true)
            {
                MessageBox.Show("Edit food successful.");
                LoadListFood();

                if (updateFood != null)
                {
                    // gọi sự kiện update
                    updateFood(this, new EventArgs());
                }
            }
            else
            {
                MessageBox.Show("Error when editing the food!");
            }
        }

        // sự kiện xoá Food
        private void btnDeleteFood_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txbFoodID.Text);
            string image = txbImageFood.Text;
            pbFood.ImageLocation = Upload.Instance.saveImage(image);
            bool flag = false;
            if (MessageBox.Show(string.Format("Do you want to delete food {0}", txbFoodName.Text), "Delete", MessageBoxButtons.OKCancel) == DialogResult.OK){
                flag = true;
            }

            if (FoodDAO.Instance.DeleteFood(id))
            {
                if (flag)
                {
                    //delete image
                    File.Exists(pbFood.ImageLocation);
                    try
                    {
                        //xoá ảnh tồn tại
                        if (File.Exists(pbFood.ImageLocation))
                        {
                            File.Delete(pbFood.ImageLocation);
                            MessageBox.Show("Image deleted.");
                        }
                    }
                    catch (Exception) { }

                    MessageBox.Show("Delete food successful.");
                    LoadListFood();

                    if (deleteFood != null)
                    {
                        // gọi sự kiện delete
                        deleteFood(this, new EventArgs());
                    }
                }
            }
            else
            {
                MessageBox.Show("Error when deleting the food!");
            }
        }

        // sự kiện thêm Category
        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            string name = txbCategoryName.Text;
            string image = txbImageCategory.Text;

            try
            {
                //không có ảnh thì lưu
                if (!image.Equals("") && !File.Exists(Upload.Instance.saveImage(image)))
                {
                    pbCategory.Image.Save(Upload.Instance.saveImage(image));
                    MessageBox.Show("Image saved.");
                }
            }
            catch (Exception) { }

            if (CategoryDAO.Instance.InsertCategory(name, image))
            {
                MessageBox.Show("Add category successful.");
                LoadListCategory();
                LoadCategoryIntoCombox(cbFoodCategory);

                if (insertCategory != null)
                {
                    // gọi sự kiện insert
                    insertCategory(this, new EventArgs());
                }
            }
            else
            {
                MessageBox.Show("Error when adding the food!");
            }

        }

        // sự kiện sửa Category
        private void btnEditCategory_Click(object sender, EventArgs e)
        {
            string name = txbCategoryName.Text;

            int id = Convert.ToInt32(txbCategoryID.Text);

            string image = txbImageCategory.Text;

            bool flag = false;

            try
            {
                if (!image.Equals(""))
                {
                    flag = true;
                }
                else
                {
                    if (MessageBox.Show("Image is empty. Do you set the image empty?", "Message", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        flag = true;
                    }
                }
            }
            catch (Exception) { }

            if (CategoryDAO.Instance.UpdateCategory(id, name, image) && flag == true)
            {
                MessageBox.Show("Edit category successful.");
                LoadListCategory();
                LoadCategoryIntoCombox(cbFoodCategory);

                if (updateCategory != null)
                {
                    // gọi sự kiện update
                    updateCategory(this, new EventArgs());
                }
            }
            else
            {
                MessageBox.Show("Error when editing the category!");
            }
        }

        // sự kiện xoá Category
        private void btnDeleteCategory_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txbCategoryID.Text);
            string image = txbImageCategory.Text;
            pbCategory.ImageLocation = Upload.Instance.saveImage(image);

            bool flag = false;
            if (MessageBox.Show(string.Format("Do you want to delete category {0}", txbCategoryName.Text), "Delete", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                flag = true;
            }

            if (CategoryDAO.Instance.DeleteCategory(id))
            {
                if (flag)
                {
                    //delete image
                    File.Exists(pbCategory.ImageLocation);
                    try
                    {
                        //xoá ảnh tồn tại
                        if (File.Exists(pbCategory.ImageLocation))
                        {
                            File.Delete(@pbCategory.ImageLocation);
                            MessageBox.Show("Image deleted.");
                        }
                    }
                    catch (Exception) { }

                    MessageBox.Show("Delete category successful.");
                    LoadListCategory();
                    LoadCategoryIntoCombox(cbFoodCategory);

                    if (deleteCategory != null)
                    {
                        // gọi sự kiện delete
                        deleteCategory(this, new EventArgs());
                    }
                }
            }
            else
            {
                MessageBox.Show("Error when deleting the category!");
            }
        }

        // load danh sách bill theo ngày khi click button view bill
        private void btnViewBill_Click(object sender, EventArgs e)
        {
            LoadListBillByDate(dtpkFromDate.Value, dtpkToDate.Value);
            LoadListBillByYear(dtpkFromDate.Value, dtpkToDate.Value);
        }

        // sự kiện show food
        private void btnShowFood_Click(object sender, EventArgs e)
        {
            LoadListFood();
        }

        // Food event
        // tạo sự kiện insertFood
        private event EventHandler insertFood;
        
        public event EventHandler InsertFood
        {
            add { insertFood += value; }
            remove { insertFood -= value; }
        }

        // tạo sự kiện deleteFood
        private event EventHandler deleteFood;

        public event EventHandler DeleteFood
        {
            add { deleteFood += value; }
            remove { deleteFood -= value; }
        }

        // tạo sự kiện updateFood
        private event EventHandler updateFood;

        public event EventHandler UpdateFood
        {
            add { updateFood += value; }
            remove { updateFood -= value; }
        }

        // sự kiện show Category
        private void btnShowCategory_Click(object sender, EventArgs e)
        {
            LoadListCategory();
        }

        // Category event
        // tạo sự kiện insertCategory
        private event EventHandler insertCategory;

        public event EventHandler InsertCategory
        {
            add { insertCategory += value; }
            remove { insertCategory -= value; }
        }

        // tạo sự kiện deleteCategory
        private event EventHandler deleteCategory;

        public event EventHandler DeleteCategory
        {
            add { deleteCategory += value; }
            remove { deleteCategory -= value; }
        }

        // tạo sự kiện updateCategory
        private event EventHandler updateCategory;

        public event EventHandler UpdateCategory
        {
            add { updateCategory += value; }
            remove { updateCategory -= value; }
        }

        // sự kiện thêm table
        private void btnAddTable_Click(object sender, EventArgs e)
        {
            string name = txbTableName.Text;

            string status = txbTableStatus.Text;

            if (TableDAO.Instance.InsertTable(name, status))
            {
                MessageBox.Show("Add table successful.");
                LoadListTable();

                if (insertTable != null)
                {
                    // gọi sự kiện insert
                    insertTable(this, new EventArgs());
                }
            }
            else
            {
                MessageBox.Show("Error when adding the table!");
            }
        }

        // sự kiện xoá table
        private void btnDeleteTable_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txbTableID.Text);
            bool flag = false;
            if (MessageBox.Show(string.Format("Do you want to delete table {0}", txbTableName.Text), "Delete", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                flag = true;
            }

            if (TableDAO.Instance.DeleteTable(id))
            {
                if (flag)
                {
                    MessageBox.Show("Delete table successful.");
                    LoadListTable();

                    if (deleteTable != null)
                    {
                        // gọi sự kiện delete
                        deleteTable(this, new EventArgs());
                    }
                }
            }
            else
            {
                MessageBox.Show("Error when deleting the table!");
            }
        }

        // sự kiện sửa table
        private void btnEditTable_Click(object sender, EventArgs e)
        {
            string name = txbTableName.Text;

            string status = txbTableStatus.Text;

            int id = Convert.ToInt32(txbTableID.Text);

            if (TableDAO.Instance.UpdateTable(id, name, status))
            {
                MessageBox.Show("Edit table successful.");
                LoadListTable();

                if (updateTable != null)
                {
                    // gọi sự kiện update
                    updateTable(this, new EventArgs());
                }
            }
            else
            {
                MessageBox.Show("Error when editing the table!");
            }
        }

        // sự kiện show Table

        private void btnShowTable_Click(object sender, EventArgs e)
        {
            LoadListTable();
        }

        // Category event
        // tạo sự kiện insertCategory
        private event EventHandler insertTable;

        public event EventHandler InsertTable
        {
            add { insertTable += value; }
            remove { insertTable -= value; }
        }

        // tạo sự kiện deleteCategory
        private event EventHandler deleteTable;

        public event EventHandler DeleteTable
        {
            add { deleteTable += value; }
            remove { deleteTable -= value; }
        }

        // tạo sự kiện updateCategory
        private event EventHandler updateTable;

        public event EventHandler UpdateTable
        {
            add { updateTable += value; }
            remove { updateTable -= value; }
        }

        // sự kiện Click first page quay về trang 1 trong list bill
        private void btnFirstBillPage_Click(object sender, EventArgs e)
        {
            txbBillPage.Text = "1";
        }

        // sự kiện Click last page quay về trang cuối trong list bill
        private void btnLastBillPage_Click(object sender, EventArgs e)
        {
            try
            {
                int sumRecord = BillDAO.Instance.GetBillNumByDate(dtpkFromDate.Value, dtpkToDate.Value);

                // mỗi trang 10 bill
                int lastPage = sumRecord / 10;

                if (sumRecord % 10 != 0)
                {
                    lastPage++;
                }

                txbBillPage.Text = lastPage.ToString();
            }
            catch (Exception) { }


        }

        // show list bill mới khi textbox bill page thay đổi
        private void txbBillPage_TextChanged(object sender, EventArgs e)
        {
            dtgvBill.DataSource = BillDAO.Instance.GetBillListByDateAndPage(dtpkFromDate.Value, dtpkToDate.Value, Convert.ToInt32(txbBillPage.Text));
        }

        // quay lại trang trước
        private void btnPreviousBillPage_Click(object sender, EventArgs e)
        {
            try
            {
                int page = Convert.ToInt32(txbBillPage.Text);

                if (page > 1)
                {
                    page--;
                }

                txbBillPage.Text = page.ToString();

            }
            catch (Exception) { }

        }

        // sang trang tiếp theo
        private void btnNextBillPage_Click(object sender, EventArgs e)
        {
            try
            {
                int page = Convert.ToInt32(txbBillPage.Text);

                int sumRecord = BillDAO.Instance.GetBillNumByDate(dtpkFromDate.Value, dtpkToDate.Value);

                if (page < sumRecord)
                {
                    page++;
                }

                txbBillPage.Text = page.ToString();
            }
            catch (Exception) { }

        }

        private void btnUploadImageFood_Click(object sender, EventArgs e)
        {
            pbFood.ImageLocation = Upload.Instance.UploadImage();

            // update image name
            if (pbFood.ImageLocation.Equals(""))
            {
                pbFood.Image = IconDAO.Instance.setIconButtonAndImage(txbImageFood.Text);
            }
            else
            {
                String[] i = pbFood.ImageLocation.ToString().Split('\\');
                int count = i.Length;
                string filename = i[count - 1];
                if (!filename.Equals(""))
                    txbImageFood.Text = filename;
                pbFood.Image = IconDAO.Instance.setIconButtonAndImage(txbImageFood.Text);
            }
        }

        private void btnUploadmageCategory_Click(object sender, EventArgs e)
        {
            pbCategory.ImageLocation = Upload.Instance.UploadImage();

            // update image name
            if (pbCategory.ImageLocation.Equals(""))
            {
                pbCategory.Image = IconDAO.Instance.setIconButtonAndImage(txbImageCategory.Text);
            }
            else
            {
                String[] i = pbCategory.ImageLocation.ToString().Split('\\');
                int count = i.Length;
                string filename = i[count - 1];
                if (!filename.Equals(""))
                    txbImageCategory.Text = filename;
                pbCategory.Image = IconDAO.Instance.setIconButtonAndImage(txbImageCategory.Text);
            }
        }

        private void btnUploadmageAccont_Click(object sender, EventArgs e)
        {
            pbAccount.ImageLocation = Upload.Instance.UploadImage();

            // update image name
            if (pbAccount.ImageLocation.Equals(""))
            {
                pbAccount.Image = IconDAO.Instance.setIconButtonAndImage(txbImageAccount.Text);
            }
            else
            {
                String[] i = pbAccount.ImageLocation.ToString().Split('\\');
                int count = i.Length;
                string filename = i[count - 1];
                if (!filename.Equals(""))
                    txbImageAccount.Text = filename;
                pbAccount.Image = IconDAO.Instance.setIconButtonAndImage(txbImageAccount.Text);
            }
        }

        private void btnSearchCategory_Click(object sender, EventArgs e)
        {
            categoryList.DataSource = SearchCategoryByName(txbSearchCategoryName.Text);
        }

        #endregion

        private void btnSearchTable_Click(object sender, EventArgs e)
        {
            tableList.DataSource = SearchTableByName(txbSearchTableName.Text);
        }

        private void btnSearchAccount_Click(object sender, EventArgs e)
        {
            accountList.DataSource = SearchAccountByName(txbSearchAccountName.Text);
        }

        private void btnChart_Click(object sender, EventArgs e)
        {
            frmChartRevenue f = new frmChartRevenue();
            f.ShowDialog();

        }

        private void nmMonth_ValueChanged(object sender, EventArgs e)
        {
            int month = (int)nmMonth.Value;

            DateTime today = DateTime.Now;

            dtpkFromDate.Value = new DateTime(today.Year, month, 1);

            dtpkToDate.Value = dtpkFromDate.Value.AddMonths(1).AddDays(-1);

            LoadListBillByDate(dtpkFromDate.Value, dtpkToDate.Value);
        }

        private void nmYear_ValueChanged(object sender, EventArgs e)
        {
            int year = (int)nmYear.Value;

            DateTime today = DateTime.Now;

            dtpkFromDate.Value = new DateTime(year, today.Month, 1);

            dtpkToDate.Value = dtpkFromDate.Value.AddMonths(1).AddDays(-1);

            LoadListBillByDate(dtpkFromDate.Value, dtpkToDate.Value);
            LoadListBillByYear(dtpkFromDate.Value, dtpkToDate.Value);
        }
    }
}
