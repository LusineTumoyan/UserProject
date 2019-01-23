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

namespace UserWPF
{
    public partial class Address : Page
    {
        public Address(IEnumerable<UserBusinessLayer.AddressLib> data)
        {
            InitializeComponent();
            AddressListView.ItemsSource = data;
        }

        private void Button_Click_Back(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(MainWindow.UserPage);
        }

        private void Button_Click_Forward(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(MainWindow.CompanyPage);
        }
    }
}
