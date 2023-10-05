using QLNH.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNH.DAO
{
    public class TableOrderDAO
    {
        private static TableOrderDAO instance;

        public static TableOrderDAO Instance
        {
            get { if (instance == null) instance = new TableOrderDAO(); return instance; }
            private set => instance = value;
        }

        private TableOrderDAO() { }

        public void SetOrder(int id, DateTime dateCheck)
        {
            DataProvider.Instance.ExecuteNonQuery("exec USP_InsertTableOrder @idTable , @dateCheck", new object[] { id , dateCheck});
        }

        public void DeleteOrder(int id, DateTime dateCheck)
        {
            DataProvider.Instance.ExecuteNonQuery("exec USP_DeleteTableOrder @idTable , @dateCheck", new object[] { id, dateCheck });
        }
        public void DeleteAllInDate(DateTime dateCheck)
        {
            DataProvider.Instance.ExecuteNonQuery("exec USP_DeleteTableOrderInDate @dateCheck", new object[] { dateCheck });
        }

        public List<TableOrder> SearchTableOrderByName(string name)
        {
            List<TableOrder> list = new List<TableOrder>();

            string query = string.Format("select * from TableOrder where dbo.fuChuyenCoDauThanhKhongDau(tableName) like N'%' + dbo.fuChuyenCoDauThanhKhongDau(N'{0}') + '%'", name);

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                TableOrder tableOrder = new TableOrder(item);
                list.Add(tableOrder);
            }

            return list;
        }

        public object GetListTableOrderByDate(int month, int year)
        {
            List<TableOrder> list = new List<TableOrder>();

            DataTable data = DataProvider.Instance.ExecuteQuery("exec USP_GetListTableOrderByDate @month , @year", new object[] { month, year });

            foreach (DataRow item in data.Rows)
            {
                TableOrder tableOrder = new TableOrder(item);
                list.Add(tableOrder);
            }

            return list;
        }

        public bool GetStatusById(int id, DateTime dateCheck)
        {
            try
            {
                return (int)DataProvider.Instance.ExecuteScalar("exec USP_GetStatusById @idTable , @dateCheck", new object[] { id, dateCheck }) > 0;
            }
            catch
            {
                return false;
            }
        }

        public List<TableOrder> GetListTableOrder()
        {
            List<TableOrder> list = new List<TableOrder>();

            string query = "select * from TableOrder";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                TableOrder tableOrder = new TableOrder(item);
                list.Add(tableOrder);
            }

            return list;
        }

        public bool InsertTableOrder(string idTable, DateTime dateCheck, string status)
        {
            throw new NotImplementedException();
        }

        public string GetTimeByIdAndDate(int id, DateTime dateCheck)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("exec USP_GetTimeByIdAndDate @idTable , @dateCheck", new object[] { id, dateCheck });

            TableOrder tableOrder = new TableOrder(data.Rows[0]);

            return tableOrder.DateCheck.ToString();
        }

        public void DeleteOrderLastDate()
        {
            DataProvider.Instance.ExecuteNonQuery("exec USP_DeleteOrderLastDate");
        }
    }
}
