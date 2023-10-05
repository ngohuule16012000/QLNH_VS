using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNH.Model
{
    public class Kitchen
    {
        public Kitchen(int id, int idTable, int idFood, DateTime? dateCheckIn, int count, string status)
        {
            this.ID = id;
            this.IdTable = idTable;
            this.IdFood = idFood;
            this.DateCheckIn = dateCheckIn;
            this.Count = count;
            this.Status = status;
        }

        public Kitchen(DataRow row)
        {
            this.ID = (int)row["id"];
            this.IdTable = (int)row["idTable"];
            this.IdFood = (int)row["idFood"];
            this.DateCheckIn = (DateTime?)row["dateCheckIn"];
            this.Count = (int)row["count"];
            this.Status = row["status"].ToString();
        }

        private int iD;
        private int idTable;
        private int idFood;
        private DateTime? dateCheckIn;
        private int count;
        private string status;

        public int ID { get => iD; set => iD = value; }
        public int IdTable { get => idTable; set => idTable = value; }
        public int IdFood { get => idFood; set => idFood = value; }
        public DateTime? DateCheckIn { get => dateCheckIn; set => dateCheckIn = value; }
        public int Count { get => count; set => count = value; }
        public string Status { get => status; set => status = value; }
        
    }
}
