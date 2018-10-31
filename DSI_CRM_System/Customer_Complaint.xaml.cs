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
    /// Interaction logic for customer_complaint.xaml
    /// </summary>
    public partial class Customer_Complaint : Window
    {
        public Customer_Complaint()
        {
            InitializeComponent();
        }

       

        private void btnInPerson_Click(object sender, RoutedEventArgs e)
        {
          //  Button btn = sender as Button;
          //  btn.Background = btn.Background == Brushes.Red ? (SolidColorBrush)(new BrushConverter().ConvertFrom("#FFDDDDDD")) : Brushes.Red;

        }

        private void btnByCall_Click(object sender, RoutedEventArgs e)
        {
         //   Button btn = sender as Button;
         //   btn.Background = btn.Background == Brushes.Red ? (SolidColorBrush)(new BrushConverter().ConvertFrom("#FFDDDDDD")) : Brushes.Red;

        }

        private void btnOk_Click(object sender, RoutedEventArgs e)
        {
            Customer_Details cd = new Customer_Details();
            cd.Show();
            this.Hide();
        }

        private void btnCCBack_Click(object sender, RoutedEventArgs e)
        {
            Showroom_Manager sm = new Showroom_Manager();
            sm.Show();
            this.Close();
        }

        private void btnHome_Click(object sender, RoutedEventArgs e)
        {
            Showroom_Manager sm = new Showroom_Manager();
            sm.Show();
            this.Close();
        }

        private void btnLogOut_Click(object sender, RoutedEventArgs e)
        {
       
        }
    }
}
