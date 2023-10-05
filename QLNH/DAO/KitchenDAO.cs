using QLNH.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNH.DAO
{
    public class KitchenDAO
    {
        private static KitchenDAO instance;

        public static KitchenDAO Instance
        {
            get { if (instance == null) instance = new KitchenDAO(); return instance; }
            private set => instance = value;
        }

        private KitchenDAO() { }

        public void InsertKitchen(int idTable, int idFood, DateTime? dateCheckIn, int count, string status)
        {
            string query = string.Format("insert Kitchen( idTable, idFood, dateCheckIn, count, status) values ({0}, {1}, N'{2:MM/dd/yyyy}', {3}, N'{4}')", idTable, idFood, dateCheckIn, count, status);
            DataProvider.Instance.ExecuteNonQuery(query);
        }

        public int GetKitchenIDByFoodIDAndTableID(int idTable, int idFood)
        {
            // lấy data
            DataTable data = DataProvider.Instance.ExecuteQuery("select * from Kitchen where idFood = " + idFood + " and idTable = " + idTable);

            // có data
            if (data.Rows.Count > 0)
            {
                // lấy dòng đầu tiên
                Kitchen kitchen = new Kitchen(data.Rows[0]);
                return kitchen.ID;
            }
            return -1;
        }

        public int GetCountByFoodIDAndTableID(int idTable, int idFood)
        {
            // lấy data
            DataTable data = DataProvider.Instance.ExecuteQuery("select * from Kitchen where idTable = " + idTable + " and idFood = " + idFood);

            // có data
            if (data.Rows.Count > 0)
            {
                // lấy dòng đầu tiên
                Kitchen kitchen = new Kitchen(data.Rows[0]);
                return kitchen.Count;
            }
            return -1;
        }

        public List<Kitchen> GetListKitchen()
        {
            List<Kitchen> listKitchen = new List<Kitchen>();

            string query = "select * from Kitchen";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Kitchen kitchen = new Kitchen(item);
                listKitchen.Add(kitchen);
            }

            return listKitchen;
        }

        public void DeleteKitchenByTableID(int id)
        {
            DataProvider.Instance.ExecuteNonQuery("delete from Kitchen where idTable = " + id);
        }

        public List<Kitchen> GetAllKitchenByTableID(int id)
        {
            List<Kitchen> listKitchen = new List<Kitchen>();

            string query = "select * from Kitchen where idTable = " + id;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Kitchen kitchen = new Kitchen(item);
                listKitchen.Add(kitchen);
            }

            return listKitchen;
        }

        public void UpdateCountKitchen(int count, int idTable, int idFood)
        {
            DataProvider.Instance.ExecuteNonQuery("update Kitchen set count = " + count + " where idTable = " + idTable + " and idFood = " + idFood + " and status = N'not yet'");
        }

        public void SetStatus(string status, int idTable, int idFood)
        {
            string query = string.Format("update Kitchen set status = N'{0}' where idTable = {1} and idFood = {2}", status, idTable, idFood);
            DataProvider.Instance.ExecuteNonQuery(query);
        }

        public void SetAllStatusAlreadyByTableID(int id)
        {
            DataProvider.Instance.ExecuteNonQuery("update Kitchen set status = N'already' where idTable = " + id);
        }
    }
}
