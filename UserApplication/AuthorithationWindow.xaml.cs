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
using Context;
using Context.Entities;

namespace UserApplication
{
    /// <summary>
    /// Логика взаимодействия для AuthorithationWindow.xaml
    /// </summary>
    public partial class AuthorithationWindow : Window
    {
        public MyDataContext context { get; set; }

        public AuthorithationWindow()
        {
            InitializeComponent();
            context = new MyDataContext();
        }

        private void Button_Authorithation_Click(object sender, RoutedEventArgs e)
        {
            string login = login_tb.Text.Trim();
            string pass = password_pb.Password.Trim();
            if (login.Length < 5)
            {
                login_tb.ToolTip = "Login is too short, try to another one";
                login_tb.Background = Brushes.Red;
            }
            else if (pass.Length < 5)
            {
                password_pb.ToolTip = "Password is too short, try to another one";
                password_pb.Background = Brushes.Red;
            }
            else
            {
                login_tb.ToolTip = "";
                login_tb.Background = Brushes.Transparent;
                password_pb.ToolTip = "";
                password_pb.Background = Brushes.Transparent;

                User authUser = new User() { Login = login, Password = pass };
                if (context.Users.Any(u => u.Login == authUser.Login && u.Password == authUser.Password))
                {
                    authUser = context.Users.First(u => u.Login == authUser.Login && u.Password == authUser.Password);
                    MessageBox.Show($"This User exists {authUser.Email}");
                }
                else
                    MessageBox.Show("Incorrcet Login or Password");
            }
        }

        private void btnSignUpWindowOpen_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Hide();
        }
    }
}
