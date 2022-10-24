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

namespace UserApplication
{
    /// <summary>
    /// Логика взаимодействия для AuthorithationWindow.xaml
    /// </summary>

    public partial class AuthorithationWindow : Window
    {
        public AuthorithationWindow()
        {
            InitializeComponent();
            //db = new 
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
                User authUser = null;
                //using (ApplicationContext db = new ApplicationContext())
                //{
                //    authUser = db.Users.Where(b => b.Login == login && b.Pass == pass).FirstOrDefault();
                //}
                if (authUser != null)
                    MessageBox.Show("Everything seems fine");
                else
                    MessageBox.Show("Something is bad");
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
