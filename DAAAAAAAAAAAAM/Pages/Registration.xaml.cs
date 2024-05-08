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
    /// Логика взаимодействия для Registration.xaml
    /// </summary>
    public partial class Registration : Page
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = Window.GetWindow(this) as MainWindow;
            mainWindow.Frame.Navigate(new LogIn());
        }

        private void registrationButton_Click(object sender, RoutedEventArgs e)
        {
            if (!registrationValidation()) return;

            MainWindow mainWindow = Window.GetWindow(this) as MainWindow;
            mainWindow.Frame.Navigate(new Test());
        }

        private bool registrationValidation()
        {
            string[] notEmptyFields = { username.Text, password.Password, repeatPassword.Password };

            if (!notEmptyFields.ToList().All(el => !string.IsNullOrWhiteSpace(el)))
            {
                MessageBox.Show("Заполните все поля");
                return false;
            }
            
            if (password.Password.Length < 6)
            {
                MessageBox.Show("Пароль должен быть от 6 символов");
                return false;
            }


            if (password.Password != repeatPassword.Password)
            {
                MessageBox.Show("Пароли не совпадают");
                return false;
            }

            return true;
        }
    }
}
