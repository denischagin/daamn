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
    /// Логика взаимодействия для Test.xaml
    /// </summary>
    public partial class Test : Page
    {
        public Test()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = Window.GetWindow(this) as MainWindow;
            mainWindow.Frame.Navigate(new LogIn());
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            Singleton.DB.User.ToList();
            table.ItemsSource = Singleton.DB.User.Local;
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (String.IsNullOrEmpty(filter.Text))
            {
                table.ItemsSource = Singleton.DB.User.ToList();
                return;
            }

            string lowerText = filter.Text.ToLower();

            table.ItemsSource = Singleton.DB.User.Where(u => u.Username.ToLower().Contains(lowerText) || u.Password.ToLower().Contains(lowerText)).ToList();
        }

        private void edit_Click(object sender, RoutedEventArgs e)
        {
            if (table.SelectedItem == null)
            {
                MessageBox.Show("Выбери пользователя для редактирования");
                return;
            }

        }
    }
}
