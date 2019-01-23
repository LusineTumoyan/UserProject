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
using UserBusinessLayer;
using Newtonsoft.Json;
using System.Net;
using Xceed.Wpf.Toolkit;
using System.Collections;

namespace UserWPF
{
    public partial class MainWindow : Window
    {
        public static List<UserFullInfoLib> usersList = null;
        public static User UserPage { get; private set; } = null;
        public static Address AddressPage { get; private set; } = null;
        public static Company CompanyPage { get; private set; } = null;
        public static AddUser AddUserPage { get; private set; } = null;
        private static bool IsCleared = true;

        public MainWindow()
        {
            InitializeComponent();
        }

        private async void Button_Click_GetData(object sender, RoutedEventArgs e)
        {
            try
            {                
                mainClearButton.Content = "Clear";
                mainClearButton.IsEnabled = false;
                mainAddDataButton.IsEnabled = false;
                mainDataButton.IsEnabled = false;
                mainDataButton.Visibility = Visibility.Hidden;
                busyIndicator1.Visibility = Visibility.Visible;
                busyIndicator1.IsBusy = true;

                if (usersList == null)
                {
                    usersList = new List<UserFullInfoLib>();
                }
                                
                IEnumerable<UserFullInfoLib> i = usersList.Union(await GetDataAsync());
                
                UserPage = new User(i);
                AddressPage = new Address(i.Select(u => u.Address));
                CompanyPage = new Company(i.Select(u => u.Company));

                await Task.Delay(2000);
                busyIndicator1.IsBusy = false;
                busyIndicator1.Visibility = Visibility.Hidden;
                mainDataButton.Visibility = Visibility.Visible;
                mainDataButton.Content = "Done";
                mainClearButton.IsEnabled = true;
                mainAddDataButton.IsEnabled = true;                

                myPageFrame.Navigate(UserPage);
            }
            catch (Exception)
            {

            }
        }

        private async void Button_Click_ClearData(object sender, RoutedEventArgs e)
        {
            try
            {
                if (usersList != null)
                {                    
                    mainClearButton.IsEnabled = false;
                    mainAddDataButton.IsEnabled = false;
                    mainDataButton.Content = "Get Data";
                    mainClearButton.Visibility = Visibility.Hidden;
                    busyIndicator2.Visibility = Visibility.Visible;
                    busyIndicator2.IsBusy = true;

                    await Task.Delay(2000);
                    usersList = null;
                    UserPage = null;
                    AddressPage = null;
                    CompanyPage = null;

                    busyIndicator2.IsBusy = false;
                    busyIndicator2.Visibility = Visibility.Hidden;
                    mainClearButton.Visibility = Visibility.Visible;
                    mainClearButton.Content = "Cleared";
                    mainDataButton.IsEnabled = true;
                    mainAddDataButton.IsEnabled = true;

                    myPageFrame.Navigate(UserPage);
                }
            }
            catch (Exception)
            {

            }
        }

        private async Task<List<UserFullInfoLib>> GetDataAsync()
        {
            return await Task.Run(() =>
            {
                WebClient client = new WebClient();
                string data = client.DownloadString("https://jsonplaceholder.typicode.com/users");

                usersList = JsonConvert.DeserializeObject<List<UserFullInfoLib>>(data);
                IsCleared = false;

                return usersList;
            });
        }

        private void Button_Click_AddData(object sender, RoutedEventArgs e)
        {            
            mainDataButton.Content = "Get Data";
            mainDataButton.IsEnabled = true;
            AddUserPage = new AddUser();

            myPageFrame.Navigate(AddUserPage);
        }       
    }
}

