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

namespace DSI_CRM_System
{
    /// <summary>
    /// Interaction logic for complaint_type.xaml
    /// </summary>
    public partial class Complaint_Type : Window
    {
        public Complaint_Type()
        {
            InitializeComponent();
        }

        private void btnStaffComplaint_Click(object sender, RoutedEventArgs e)
        {
            Staff_Complaint sc = new Staff_Complaint();
            sc.Show();
            this.Show();
        }

        private void btnItemComplaint_Click(object sender, RoutedEventArgs e)
        {
            Item_Complaint ic = new Item_Complaint();
            ic.Show();
            this.Show();
        }
    }
}
