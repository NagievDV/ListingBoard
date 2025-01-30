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

namespace ListingBoard.Pages
{
    /// <summary>
    /// Логика взаимодействия для LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Page
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            var login = tbLogin.Text.Trim();
            var password = pbPassword.Password.Trim();

            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Пожалуйста, заполните поля логина и пароля.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            using (var context = new Entities())
            {
                var user = context.Users.FirstOrDefault(u => u.Login == login && u.Password == password);

                if (user != null)
                {
                    MessageBox.Show($"Добро пожаловать, {user.Login}!", "Успешный вход", MessageBoxButton.OK, MessageBoxImage.Information);
                    if (Application.Current.MainWindow is MainWindow mainWindow)
                    {
                        mainWindow.userdata = user;
                        mainWindow.btnUserPage.Visibility = Visibility.Visible;
                    }
                    NavigationService?.Navigate(new UserPage());
                }
                else
                {
                    MessageBox.Show("Неверный логин или пароль.", "Ошибка входа", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }
    }
}
