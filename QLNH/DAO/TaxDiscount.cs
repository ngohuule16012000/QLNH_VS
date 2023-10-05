using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNH.DAO
{
    class TaxDiscount
    {
        private static int tax = 10;
        private static int discount = 0;
        private static int year = 2022;

        public static int Tax { get => tax; set => tax = value; }
        public static int Discount { get => discount; set => discount = value; }
        public static int Year { get => year; set => year = value; }
    }
}
