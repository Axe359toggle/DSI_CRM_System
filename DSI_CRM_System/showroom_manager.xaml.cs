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
    /// Interaction logic for showroom_manager.xaml
    /// </summary>
    public partial class Showroom_Manager : Window
    {
        internal static BackButton b1 = new BackButton();

        public Showroom_Manager()
        {
            InitializeComponent();
        }

        
        private void btnMakeComplaintCustomer_Click(object sender, RoutedEventArgs e)
        {
            b1.addWindowAndOpenNextWindow(this, new Customer_Complaint());

            /*
            Customer_Complaint cc = new Customer_Complaint();
            cc.Show();
            this.Hide();
            */
        }

        private void btnResetUnPw_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnMakeBatchComplaint_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
