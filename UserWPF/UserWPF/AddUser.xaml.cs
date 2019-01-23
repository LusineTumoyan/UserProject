using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
using UserBusinessLayer;

namespace UserWPF
{
    public partial class AddUser : Page
    {
        private readonly SynchronizationContext sync;

        public AddUser()
        {
            InitializeComponent();
            sync = SynchronizationContext.Current;
        }

        private void Button_Click_Add(object sender, RoutedEventArgs e)
        {
            AddButton.IsEnabled = false;

            Geo geo = new Geo()
            {
                Lat = LatBox.Text,
                Lng = LngBox.Text
            };
            AddressLib address = new AddressLib()
            {
                Street = StreetBox.Text,
                City = CityBox.Text,
                Suite = SuiteBox.Text,
                Zipcode = ZipcodeBox.Text,
                Geo = geo
            };
            CompanyLib company = new CompanyLib()
            {
                Name = CompanyNameBox.Text,
                CatchPhrase = CatchPhraseBox.Text,
                Bs = BsBox.Text
            };

            int Id = 1;
            if (MainWindow.usersList != null)
            {
                Id = MainWindow.usersList.Select(u => u.ID).Max() + 1;
            }

            UserFullInfoLib user = new UserFullInfoLib()
            {
                ID = Id,
                Name = NameBox.Text,
                UserName = UserNameBox.Text,
                Email = EmailBox.Text,
                Phone = PhoneBox.Text,
                Website = WebsiteBox.Text,
                Address = address,
                Company = company
            };

            if (MainWindow.usersList != null)
            {
                MainWindow.usersList.Add(user);
            }
            else
            {
                MainWindow.usersList = new List<UserFullInfoLib>();
                MainWindow.usersList.Add(user);
            }
            AddButton.Content = "Done";            
        }

        private void Button_Click_GoBack(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(Parent);
        }
    }
}
