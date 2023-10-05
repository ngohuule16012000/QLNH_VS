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
using Menu = QLNH.Model.Menu;

namespace QLNH.Views
{
    public partial class frmKitchenArea : Form
    {
        private static int idTableGlobal = -1;

        public frmKitchenArea()
        {
            InitializeComponent();
            
            SetKitchen();
            LoadKitchen();

            btnSearchTable.Image = IconDAO.Instance.setIconButtonAndImage("icons8-search-24.png");
        }

        private void SetKitchen()
        {
            List<Table> listTable = TableDAO.Instance.GetListTable();
            foreach (Table item in listTable)
            {
                int idTable = item.ID;
                // lấy danh sách thức ăn theo bill chưa thanh toán
                List<MenuKitchen> listBillInfo = MenuKitchenDAO.Instance.GetListMenuByTable(idTable);

                if (listBillInfo.Count != 0)
                {
                    foreach (MenuKitchen menu in listBillInfo)
                    {
                        // kiểm tra có tồn tại bàn và thức ăn?
                        int idKitchen = KitchenDAO.Instance.GetKitchenIDByFoodIDAndTableID(idTable, menu.IdFood);
                        if (idKitchen == -1)
                        {
                            // nếu không thì thêm mới Kitchen
                            KitchenDAO.Instance.InsertKitchen(idTable, menu.IdFood, menu.DateCheckIn, menu.Count, "not yet");
                        }
                        else
                        {
                            // update Kitchen khi count change
                            if (menu.Count != KitchenDAO.Instance.GetCountByFoodIDAndTableID(idTable, menu.IdFood))
                            {
                                KitchenDAO.Instance.UpdateCountKitchen(menu.Count, idTable, menu.IdFood);
                            }
                        }
                    }
                }
                else
                {
                    // xoá Table khỏi bếp sau khi thanh toán xong hoặc huỷ bàn ăn
                    KitchenDAO.Instance.DeleteKitchenByTableID(idTable);
                }
            }
        }

        private void LoadKitchen()
        {
            flpKitchenTable.Controls.Clear();

            // lấy ds bàn
            List<Table> listTable = TableDAO.Instance.GetListTable();

            foreach(Table table in listTable)
            {
                // lấy danh sách food theo bàn
                List<Kitchen> listKitchen = KitchenDAO.Instance.GetAllKitchenByTableID(table.ID);

                if(listKitchen.Count > 0)
                {
                    // gom những ds food vào 1 bàn tạo ra 1 yêu cầu cho bếp
                    Button btn = new Button() { Width = 150, Height = 100 };
                    btn.Text = table.Name + Environment.NewLine; // Environment.NewLine = \n
                    btn.TextAlign = ContentAlignment.BottomCenter;
                    btn.Font = new Font(btn.Font, FontStyle.Bold);

                    // set event
                    btn.Click += btn_Click;

                    btn.Tag = table;

                    string status = "already";

                    //get status là already nếu không có thức ăn nào not yet
                    foreach(Kitchen item in listKitchen)
                    {
                        if(item.Status.Equals("not yet"))
                        {
                            status = "not yet";
                            break;
                        }
                    }

                    switch (status)
                    {
                        case "not yet":
                            // button Add Food
                            btn.Text += status;
                            btn.Image = IconDAO.Instance.setIconButtonAndImage("icons8-kitchen-room-48.png");
                            btn.ImageAlign = ContentAlignment.TopCenter;
                            btn.BackColor = Color.LightYellow;
                            break;
                        default:
                            btn.Text += status;
                            btn.Image = IconDAO.Instance.setIconButtonAndImage("icons8-kitchen-room-48.png");
                            btn.ImageAlign = ContentAlignment.TopCenter;
                            btn.BackColor = Color.DarkGreen;
                            btn.ForeColor = Color.White;
                            break;
                    }

                    flpKitchenTable.Controls.Add(btn);
                }
            }
        }

        private void btn_Click(object sender, EventArgs e)
        {
            // lấy table id
            int tableID = ((sender as Button).Tag as Table).ID;
            // ghi lại idtable toàn cục
            idTableGlobal = tableID;
            lbTableName.Text = ((sender as Button).Tag as Table).Name;
            // đổ thức ăn vào flp theo bàn
            ShowKitchenFood(tableID);
        }

        private void ShowKitchenFood(int id)
        {
            flpKitchenFood.Controls.Clear();

            // lấy ds thức ăn theo bàn
            List<Kitchen> listKitchen = KitchenDAO.Instance.GetAllKitchenByTableID(id);

            foreach (Kitchen item in listKitchen)
            {
                // lấy food name theo idFood
                string foodName = FoodDAO.Instance.GetFoodNameByIDFood(item.IdFood)[0].Name;

                Button btn = new Button() { Width = 280, Height = 60 };
                btn.Text = foodName + " (" + item.Count + ")" + "\n\n";

                if(item.Status.Equals("not yet"))
                {
                    btn.Image = IconDAO.Instance.setIconButtonAndImage("icons8-alarm-24.png");
                }
                else
                {
                    btn.Image = IconDAO.Instance.setIconButtonAndImage("icons8-alarm-green-24.png");
                }
                
                btn.Padding = new Padding(10, 5, 10, 0);
                btn.ImageAlign = ContentAlignment.MiddleRight;
                btn.TextAlign = ContentAlignment.MiddleLeft;
                btn.TextImageRelation = TextImageRelation.TextBeforeImage;
                btn.BackColor = Color.Ivory;

                // set event
                btn.Click += btnStatusFood_Click;

                // lưu item vào button
                btn.Tag = item;

                flpKitchenFood.Controls.Add(btn);

            }
        }

        private void btnStatusFood_Click(object sender, EventArgs e)
        {
            string status = ((sender as Button).Tag as Kitchen).Status;
            if(status.Equals("not yet"))
            {
                // update status theo idTable và idFood
                KitchenDAO.Instance.SetStatus("already", ((sender as Button).Tag as Kitchen).IdTable, ((sender as Button).Tag as Kitchen).IdFood);
                (sender as Button).Image = IconDAO.Instance.setIconButtonAndImage("icons8-alarm-green-24.png");
            }
            else
            {
                // update status theo idTable và idFood
                KitchenDAO.Instance.SetStatus("not yet", ((sender as Button).Tag as Kitchen).IdTable, ((sender as Button).Tag as Kitchen).IdFood);
                (sender as Button).Image = IconDAO.Instance.setIconButtonAndImage("icons8-alarm-24.png");
            }

            LoadKitchen();
            ShowKitchenFood(idTableGlobal);
        }

        private void btnAllOrder_Click(object sender, EventArgs e)
        {
            if(idTableGlobal == -1)
            {
                MessageBox.Show("Please choose a table!");
                return;
            }
            //set all status is already
            KitchenDAO.Instance.SetAllStatusAlreadyByTableID(idTableGlobal);
            LoadKitchen();
            ShowKitchenFood(idTableGlobal);
        }

        private void btnSearchTable_Click(object sender, EventArgs e)
        {
            flpKitchenTable.Controls.Clear();
            
            List<Table> listTable = TableDAO.Instance.SearchForLoadTableKitchen(txbSearchTableName.Text);
                
            
            foreach (Table table in listTable)
            {
                // lấy danh sách food theo bàn
                List<Kitchen> listKitchen = KitchenDAO.Instance.GetAllKitchenByTableID(table.ID);

                if (listKitchen.Count > 0)
                {
                    // gom những ds food vào 1 bàn tạo ra 1 yêu cầu cho bếp
                    Button btn = new Button() { Width = 150, Height = 100 };
                    btn.Text = table.Name + Environment.NewLine; // Environment.NewLine = \n
                    btn.TextAlign = ContentAlignment.BottomCenter;
                    btn.Font = new Font(btn.Font, FontStyle.Bold);

                    // set event
                    btn.Click += btn_Click;

                    btn.Tag = table;

                    string status = "already";

                    //get status là already nếu không có thức ăn nào not yet
                    foreach (Kitchen item in listKitchen)
                    {
                        if (item.Status.Equals("not yet"))
                        {
                            status = "not yet";
                            break;
                        }
                    }

                    switch (status)
                    {
                        case "not yet":
                            // button Add Food
                            btn.Text += status;
                            btn.Image = IconDAO.Instance.setIconButtonAndImage("icons8-kitchen-room-48.png");
                            btn.ImageAlign = ContentAlignment.TopCenter;
                            btn.BackColor = Color.LightYellow;
                            break;
                        default:
                            btn.Text += status;
                            btn.Image = IconDAO.Instance.setIconButtonAndImage("icons8-kitchen-room-48.png");
                            btn.ImageAlign = ContentAlignment.TopCenter;
                            btn.BackColor = Color.DarkGreen;
                            btn.ForeColor = Color.White;
                            break;
                    }

                    flpKitchenTable.Controls.Add(btn);
                }
            }

        }

           
    }
}
