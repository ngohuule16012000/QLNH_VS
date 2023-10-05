using QLNH.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNH.DAO
{
    public class BillDAO
    {
        // singleton
        private static BillDAO instance;

        public static BillDAO Instance 
        {
            get { if (instance == null) instance = new BillDAO(); return instance; }
            private set => instance = value; 
        }

        private BillDAO() { }
        
        // lấy bill từ table id còn trống, trả về id của bill
        public int GetUnCheckBillIDByTableID(int id)
        {
            // lấy data
            DataTable data = DataProvider.Instance.ExecuteQuery("select * from Bill where idTable = " + id + " and status = 0");
            
            // có data
            if(data.Rows.Count > 0)
            {
                // lấy dòng đầu tiên
                Bill bill = new Bill(data.Rows[0]);
                return bill.ID;
            }
            return -1;
        }

        // check out Bill bằng update
        public void CheckOut(int id,  int discount, float totalPrice)
        {
            string query = "update Bill set dateCheckOut = getdate(), status = 1, " + "discount = " + discount + ", totalPrice = " + totalPrice + " where id = " + id;
            DataProvider.Instance.ExecuteNonQuery(query);

        }

        // chèn thông tin bill
        public void InsertBill(int id)
        {
            DataProvider.Instance.ExecuteNonQuery("exec USP_InsertBill @idTable ", new object[] { id });
        }

        // Lấy danh sách Bill theo ngày
        public DataTable GetBillListByDate(DateTime checkIn, DateTime checkOut)
        {
            return DataProvider.Instance.ExecuteQuery("exec USP_GetListBillByDate @checkIn , @checkOut", new object[] { checkIn, checkOut });
        }

        public DataTable GetTotalBillByDate(DateTime checkIn, DateTime checkOut)
        {
            return DataProvider.Instance.ExecuteQuery("exec USP_GetTotalBillByDate @checkIn , @checkOut", new object[] { checkIn, checkOut });
        }

        internal DataTable GetTotalBillByYear(DateTime checkIn, DateTime checkOut)
        {
            return DataProvider.Instance.ExecuteQuery("exec USP_GetTotalBillByYear @checkIn , @checkOut", new object[] { checkIn, checkOut });
        }

        public DataTable GetBillListByDateAndPage(DateTime checkIn, DateTime checkOut, int pageNum)
        {
            return DataProvider.Instance.ExecuteQuery("exec USP_GetListBillByDateAndPage @checkIn , @checkOut , @page", new object[] { checkIn, checkOut, pageNum});
        }

        // lấy tổng số bill từ check date
        public int GetBillNumByDate(DateTime checkIn, DateTime checkOut)
        {
            return (int)DataProvider.Instance.ExecuteScalar("exec USP_GetNumBillByDate @checkIn , @checkOut", new object[] { checkIn, checkOut });
        }

        // lấy id Bill mới nhất (lớn nhất)
        public int getMaxIDBill()
        {
            try
            {
                return (int)DataProvider.Instance.ExecuteScalar("select max(id) from Bill");
            }
            catch
            {
                return 1;
            }
        }

        public int GetNewestBill()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT TOP 1 * FROM Bill where status = 1 ORDER BY ID DESC");

            // có data
            if (data.Rows.Count > 0)
            {
                // lấy dòng đầu tiên
                Bill bill = new Bill(data.Rows[0]);
                return bill.IdTable;
            }
            return -1;
        }
    }
}
