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
using Context;

namespace UserApplication
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
   
    public partial class MainWindow : Window
    { 
        ApplicationContext db;
        public MainWindow()
        {
            InitializeComponent();
            
            //db = new ApplicationContext();

            //List<User> users = db.Users.ToList();
            //string str = "";
            // foreach (User user in users)
            //      str += "Login: " + user.Login + "  ";
            // RegisterTest.Text = str;
            //<TextBlock x:Name="RegisterTest" FontWeight="Bold" Margin="0 0 0 20"/> // near another textblock
        }

        private void ButtonReg_Click(object sender, RoutedEventArgs e)
        {
            string login = login_tb.Text.Trim();
            string pass = password_pb.Password.Trim();
            string pass2 =password_pb_2.Password.Trim();
            string email = email_tb.Text.Trim().ToLower();
            if (login.Length<5)
            {
                login_tb.ToolTip = "Login is too short, try to another one";
                login_tb.Background = Brushes.Red;
            }else if (pass.Length<5)
            {
                password_pb.ToolTip = "Password is too short, try to another one";
                password_pb.Background = Brushes.Red;
            }
            else if (pass2 != pass)
            {
                password_pb_2.ToolTip = "Password isn't equile, input correct one";
                password_pb_2.Background = Brushes.Red;
            }
            else if (email.Length < 5 || !email.Contains("@") || !email.Contains("."))
            {
                email_tb.ToolTip = "Password is too short, try to another one";
                email_tb.Background = Brushes.Red;
            }
            else
            {
                login_tb.ToolTip = "";
                login_tb.Background = Brushes.Transparent;
                password_pb.ToolTip = "";
                password_pb.Background = Brushes.Transparent;
                password_pb_2.ToolTip = "";
                password_pb_2.Background = Brushes.Transparent;
                email_tb.ToolTip = "";
                email_tb.Background = Brushes.Transparent;
                MessageBox.Show("Everything seems fine");
                User user = new User(login,email,pass);
                db.Users.Add(user);
               // db.SaveChanges();
            }
        }

        private void btnSignInWindowOpen_Click(object sender, RoutedEventArgs e)
        {
            AuthorithationWindow authorithationWindow = new AuthorithationWindow();
            authorithationWindow.Show();
            Hide();
        }
    }
}
