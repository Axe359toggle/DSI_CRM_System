﻿using System;
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
    /// Interaction logic for customer_details.xaml
    /// </summary>
    public partial class Customer_Details : Window
    {
        public Customer_Details()
        {
            InitializeComponent();
        }

       

        private void btnCDOk_Click(object sender, RoutedEventArgs e)
        {
            Complaint_Type ct = new Complaint_Type();
            ct.Show();
            this.Hide();
        }
    }
}
