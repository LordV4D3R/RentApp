using Microsoft.Extensions.Configuration;
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
using System.Windows.Shapes;

namespace RentAppForm.View
{
    /// <summary>
    /// Interaction logic for LoginView.xaml
    /// </summary>
    public partial class LoginView : Window
    {
        private readonly IConfiguration _configuration;
        public LoginView()
        {
            InitializeComponent();
            _configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if(e.LeftButton==MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        private void btnMinimize_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();

        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            string username = txtuserName.Text;
            string password = txtPassword.Password;

            string adminUsername = _configuration["DefaultAdminAccount:Username"];
            string adminPassowrrd = _configuration["DefaultAdminAccount:Password"];

            if(username == adminUsername && password == adminPassowrrd)
            {
                //login success, move to next form
                //var adminManagement = new 
            }
            else
            {
                MessageBox.Show("Mật khẩu hay tên đăng nhập không đúng hoặc không tồn tại. Vui lòng thử lại!!!");
            }

        }

        private void resetPwd(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Tài khoản:admin123, Mật khẩu:admin123");
        }
    }
}
