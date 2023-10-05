using QLNH.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNH.DAO
{
    public class CategoryDAO
    {
        private static CategoryDAO instance;

        public static CategoryDAO Instance 
        {
            get { if (instance == null) instance = new CategoryDAO(); return instance; }
            private set => instance = value; 
        }

        private CategoryDAO() { }

        // lấy danh sách Category trả về list
        public List<Category> GetListCategory()
        {
            List<Category> list = new List<Category>();

            string query = "select * from FoodCategory";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Category category = new Category(item);
                list.Add(category);
            }

            return list;
        }

        // lấy Category từ id
        public Category GetCategoryByID(int id)
        {
            Category category = null;

            string query = "select * from FoodCategory where id = " + id;

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                category = new Category(item);
                return category;
            }


            return category;
        }
        
        public List<Category> SearchCategoryByName(string name)
        {
            List<Category> list = new List<Category>();

            string query = string.Format("select * from FoodCategory where dbo.fuChuyenCoDauThanhKhongDau(name) like N'%' + dbo.fuChuyenCoDauThanhKhongDau(N'{0}') + '%'", name);

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Category category = new Category(item);
                list.Add(category);
            }

            return list;
        }

        public bool InsertCategory(string name, string image)
        {
            string query = string.Format("insert FoodCategory(name, image) values (N'{0}', N'{1}')", name, image);

            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool UpdateCategory(int id, string name, string image)
        {
            string query = string.Format("update FoodCategory set name = N'{0}' , image = N'{2}' where id = {1}", name, id, image);

            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool DeleteCategory(int id)
        {
            // xoá BillInfo trước khi xoá Food
            FoodDAO.Instance.DeleteFoodByCategoryID(id);

            string query = string.Format("delete FoodCategory where id = {0}", id);

            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
    }
}
