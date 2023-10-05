using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNH.Model
{
    public class Category
    {
        public Category(int id, string name, string image)
        {
            this.ID = id;
            this.Name = name;
            this.Image = image;
            
        }

        public Category(DataRow row)
        {
            this.ID = (int)row["id"];
            this.Name = row["name"].ToString();
            this.Image = row["image"].ToString();
        }

        private int iD;
        private string name;
        private string image;

        public int ID { get => iD; set => iD = value; }
        public string Name { get => name; set => name = value; }
        public string Image { get => image; set => image = value; }
    }
}
