using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Microsoft.Win32;
using System.IO;

namespace DSI_CRM_System
{
    /// <summary>
    /// Interaction logic for received_item_details.xaml
    /// </summary>
    public partial class Received_Item_Details : Window
    {
        public Received_Item_Details()
        {
            InitializeComponent();
        }

        

        private void btnFile_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.DefaultExt = ".jpg";
            ofd.Filter = "JPeg Image| *.jpg | Bitmap Image | *.bmp | Gif Image | *.gif";
            if(ofd.ShowDialog()==true)
            {
                string filename = ofd.FileName;
                txtItemDefectImage.Text = filename;

                string path = File.ReadAllText(filename); 
            }
        }
    }
}
