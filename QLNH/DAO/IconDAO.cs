using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace QLNH.DAO
{
    class IconDAO
    {
        private static IconDAO instance;
        private string CurrentDirectory = System.IO.Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);

        internal static IconDAO Instance 
        {
            get { if (instance == null) instance = new IconDAO(); return instance; } 
            private set => instance = value; 
        }

        private IconDAO() { }

        public Image setIconButtonAndImage(string image)
        {
            var current = CurrentDirectory;
            //if (!image.Equals(".ico"))
            try
            {
                string pathImage = current.Replace("bin\\Debug", "Images\\" + image);
                return Image.FromFile(pathImage);
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
                string pathImage = current.Replace("bin\\Debug", "Images\\icons8-database-error-48.png");
                return Image.FromFile(pathImage);
            }
                
        }
    }
}
