using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Логика взаимодействия для RegPage.xaml
    /// </summary>
    public partial class RegPage : Page
    {
        public static ObservableCollection<User> users { get; set; }
        public RegPage()
        {
            InitializeComponent();
            users = new ObservableCollection<User>(db_connection.conection.User.ToList());
        }

        private void Button_Click_Reg(object sender, RoutedEventArgs e)
        {
            var a = new User();
            a.Login = txt_login.Text;
            a.Password = txt_passwors.Password;
            db_connection.conection.User.Add(a);
            db_connection.conection.SaveChanges();
            NavigationService.GoBack();
            NavigationService.Navigate(new HomePage());
        }

        private void Button_Click_Back(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
