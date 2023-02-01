using System;
using System.Collections.ObjectModel;
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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для AuthoPage.xaml
    /// </summary>
    public partial class AuthoPage : Page
    {
        public static ObservableCollection<User> user { get; set; }
        public AuthoPage()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //user = new ObservableCollection<User>(db_connection.conection.User.ToList());
            //var z = user.Where(s => s.Login == txt_login.Text && s.Password == txt_passwors.Password).FirstOrDefault();
            //if (z != null)
            {
                NavigationService.Navigate(new HomePage());
            }
            //else
            //{
            //    MessageBox.Show("логин или пароль не верные", "error", MessageBoxButton.OK, MessageBoxImage.Error);
            //}
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new RegPage());
        }
    }
}
