using QLNH.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNH.DAO
{
    class FoodDAO
    {
        private static FoodDAO instance;

        internal static FoodDAO Instance 
        {
            get { if (instance == null) instance = new FoodDAO(); return instance; }
            private set => instance = value; 
        }

        public FoodDAO() { }

        // kích thước button mỗi table
        public static int FoodWidth = 110;
        public static int FoodHeight = 130;

        public List<Food> SearchForLoadFood(string name)
        {
            List<Food> list = new List<Food>();

            string query = string.Format("select * from Food where dbo.fuChuyenCoDauThanhKhongDau(name) like N'%' + dbo.fuChuyenCoDauThanhKhongDau(N'{0}') + '%'", name);

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Food food = new Food(item);
                list.Add(food);
            }

            return list;
        }

        public void DeleteFoodByCategoryID(int id)
        {
            DataProvider.Instance.ExecuteQuery("delete Food where idCategory = " + id);
        }

        // lấy danh sách Food từ id Category
        public List<Food> GetFoodByCategoryID(int id)
        {
            List<Food> list = new List<Food>();

            string query = "select * from Food where idCategory = "+ id;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach(DataRow item in data.Rows)
            {
                Food food = new Food(item);
                list.Add(food);
            }

            return list;
        }

        public List<Food> GetIDByFoodName(string name)
        {
            List<Food> list = new List<Food>();
            string query = string.Format("select * from Food where name = N'{0}'", name);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Food food = new Food(item);
                list.Add(food);
            }

            return list;
        }

        // lấy danh sách Food
        public List<Food> GetListFood()
        {
            List<Food> list = new List<Food>();

            string query = "select * from Food";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Food food = new Food(item);
                list.Add(food);
            }

            return list;
        }

        public List<Food> GetFoodNameByIDFood(int id)
        {
            List<Food> list = new List<Food>();

            string query = "select * from Food where id = " + id;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Food food = new Food(item);
                list.Add(food);
            }

            return list;
        }

        // tìm thức ăn từ name food
        public List<Food> SearchFoodByName(string name)
        {
            List<Food> list = new List<Food>();

            string query = string.Format("select * from Food where dbo.fuChuyenCoDauThanhKhongDau(name) like N'%' + dbo.fuChuyenCoDauThanhKhongDau(N'{0}') + '%'", name);

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Food food = new Food(item);
                list.Add(food);
            }

            return list;
        }

        public bool InsertFood(string name, int id, float price, string image)
        {
            string query = string.Format("insert Food(name, idCategory, price, image) values (N'{0}', {1}, {2}, N'{3}')", name, id, price, image);
            
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool UpdateFood(int idFood, string name, int id, float price, string image)
        {
            string query = string.Format("update Food set name = N'{0}', idCategory = {1}, price = {2} , image = N'{4}' where id = {3}", name, id, price, idFood, image);

            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool DeleteFood(int idFood)
        {
            // xoá BillInfo trước khi xoá Food
            BillInfoDAO.Instance.DeleteBillInfoByFoodID(idFood);

            string query = string.Format("delete Food where id = {0}", idFood);

            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
    }
}
