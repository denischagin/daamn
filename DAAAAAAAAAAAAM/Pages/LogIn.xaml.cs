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

namespace DAAAAAAAAAAAAM.Pages
{
    /// <summary>
    /// Логика взаимодействия для LogIn.xaml
    /// </summary>
    public partial class LogIn : Page
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            User user = Singleton.DB.User.FirstOrDefault(u => u.Username == username.Text && u.Password == password.Password);
            if (user == null)
            {
                MessageBox.Show("Иди нахуй");
                return;
            }

            MainWindow mainWindow = Window.GetWindow(this) as MainWindow;


            if (user.Role_ID == 1)
            {
                mainWindow.Frame.Navigate(new Test());
                return;
            }

            if (user.Role_ID == 2)
            {
                mainWindow.Frame.Navigate(new Test2());
                return;
            }

            MessageBox.Show("Хз что за роль");
        }

        private void Registration_Click(object sender, RoutedEventArgs e)
        {
            MainWindow window  = Window.GetWindow(this) as MainWindow;
            window.Frame.Navigate(new Registration());
        }
    }
}
