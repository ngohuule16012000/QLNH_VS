using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNH.DAO
{
    class Upload
    {
        private static Upload instance;

        internal static Upload Instance 
        {
            get { if (instance == null) instance = new Upload(); return instance; }
            private set => instance = value; 
        }

        private string CurrentDirectory = System.IO.Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);

        private Upload() { }

        public string UploadImage()
        {
            string imageLocation = "";
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png| All Files(*.*)|*.*";
                dialog.Title = "Please select an image";
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLocation = dialog.FileName;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("An error occured!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return imageLocation;
        }

        public string saveImage(string filename)
        {
            string pathImage = "";
            var current = CurrentDirectory;
            pathImage = current.Replace("bin\\Debug", "Images\\" + filename);
            return pathImage;
        }

    }
}
