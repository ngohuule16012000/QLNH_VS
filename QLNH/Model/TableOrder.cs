using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNH.Model
{
    public class TableOrder
    {
        public TableOrder(int id, int idTable, string tableName, DateTime? dateCheck, string status)
        {
            this.ID = id;
            this.IdTable = idTable;
            this.TableName = tableName;
            this.DateCheck = dateCheck;
            this.Status = status;
        }

        public TableOrder(DataRow row)
        {
            this.ID = (int)row["id"];
            this.IdTable = (int)row["idTable"];
            this.TableName = row["tableName"].ToString();
            this.DateCheck = (DateTime?)row["dateCheck"];
            this.Status = row["status"].ToString();
        }

        private string status;
        private DateTime? dateCheck;
        private string tableName;
        private int idTable;
        private int iD; // ctrl + R + E

        public int ID { get => iD; set => iD = value; }
        public int IdTable { get => idTable; set => idTable = value; }
        public string TableName { get => tableName; set => tableName = value; }
        public DateTime? DateCheck { get => dateCheck; set => dateCheck = value; }
        public string Status { get => status; set => status = value; }
        
    }
}
