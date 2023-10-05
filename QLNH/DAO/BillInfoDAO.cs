using QLNH.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNH.DAO
{
    public class BillInfoDAO
    {
        // singleton
        private static BillInfoDAO instance;

        public static BillInfoDAO Instance 
        {
            get { if (instance == null) instance = new BillInfoDAO(); return instance; }
            private set => instance = value; 
        }

        public BillInfoDAO() { }

        // xoá BillInfo từ id Food 
        public void DeleteBillInfoByFoodID(int id)
        {
            DataProvider.Instance.ExecuteQuery("delete BillInfo where idFood = " + id);
        }

        public void DeleteBillInfoByBillID(int id)
        {
            DataProvider.Instance.ExecuteQuery("delete BillInfo where idBill = " + id);
        }

        // lấy list Billinfo từ idBill
        public List<BillInfo> GetListBillInfo(int id)
        {
            List<BillInfo> listBillInfo = new List<BillInfo>();

            DataTable data = DataProvider.Instance.ExecuteQuery("select * from BillInfo where idBill = " + id);

            foreach(DataRow item in data.Rows)
            {
                BillInfo info = new BillInfo(item);
                listBillInfo.Add(info);
            }

            return listBillInfo;
        }

        // chèn thông tin billInfo
        public void InsertBillInfo(int idBill, int idFood, int count)
        {
            DataProvider.Instance.ExecuteNonQuery("exec USP_InsertBillInfo @idBill , @idFood , @count", new object[] { idBill, idFood, count });
        }

    }
}
