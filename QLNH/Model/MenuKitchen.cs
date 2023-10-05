using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNH.Model
{
    public class MenuKitchen
    {
        public MenuKitchen(int idFood, DateTime? dateCheckIn, int count)
        {
            this.IdFood = idFood;
            this.DateCheckIn = dateCheckIn;
            this.Count = count;
        }

        public MenuKitchen(DataRow row)
        {
            this.IdFood = (int)row["idFood"];
            this.DateCheckIn = (DateTime?)row["dateCheckIn"];
            this.Count = (int)row["count"];
        }

        private int idFood;
        private DateTime? dateCheckIn;
        private int count;

        public int IdFood { get => idFood; set => idFood = value; }
        public DateTime? DateCheckIn { get => dateCheckIn; set => dateCheckIn = value; }
        public int Count { get => count; set => count = value; }
    }
}
