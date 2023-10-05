using QLNH.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNH.DAO
{
    public class MenuKitchenDAO
    {
        private static MenuKitchenDAO instance;

        public static MenuKitchenDAO Instance
        {
            get { if (instance == null) instance = new MenuKitchenDAO(); return instance; }
            private set => instance = value;
        }

        private MenuKitchenDAO() { }

        // lấy thông tin table
        public List<MenuKitchen> GetListMenuByTable(int id)
        {
            List<MenuKitchen> listMenu = new List<MenuKitchen>();

            string query = "select f.id as idFood, b.dateCheckIn, bi.count from BillInfo as bi, Bill as b, Food as f where bi.idBill = b.id and bi.idFood = f.id and b.status = 0 and b.idTable = " + id;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                MenuKitchen menu = new MenuKitchen(item);
                listMenu.Add(menu);
            }

            return listMenu;
        }
    }
}
