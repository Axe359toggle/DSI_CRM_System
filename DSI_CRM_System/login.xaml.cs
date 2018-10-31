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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DSI_CRM_System
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class login : Window
    {
      

        public login()
        {
            InitializeComponent();
          
            txt_userName.Text = "";
            txt_password.Password = "";
        }
        
        

        private void btnlogin_Click(object sender, RoutedEventArgs e)
        {
            

            if (txt_userName.Text == "sm" && txt_password.Password == "sm")
            {
                Showroom_Manager sm = new Showroom_Manager();
                sm.Show();
                this.Close();
            }
            else if (txt_userName.Text == "hq" && txt_password.Password == "hq")
            {
                Headquarters_Manager hqm = new Headquarters_Manager();
                hqm.Show();
                this.Close();
            }
            else if (txt_userName.Text == "fm" && txt_password.Password == "fm")
            {
                Factory_Manager fm = new Factory_Manager();
                fm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong username or password", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void btncancel_Click(object sender, RoutedEventArgs e)
        {
            txt_userName.Text = "";
            txt_password.Password = "";
        }

       
    }
}
