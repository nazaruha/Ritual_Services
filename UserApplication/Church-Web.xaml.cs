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
using UserApplication.Moduls;

namespace UserApplication
{
    /// <summary>
    /// Логика взаимодействия для Church_Web.xaml
    /// </summary>
    public partial class Church_Web : Window
    {
        public Church_Web()
        {
            InitializeComponent();
        }
        private void Button_Info_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Order_Click(object sender, RoutedEventArgs e)
        {

        }

        private void lb_en_MouseDown(object sender, MouseButtonEventArgs e)
        {
            btn_info.Content = "Info";
            btn_order.Content = "Order";
            pope_info.Content = "Some pope info";
            //cb_choice.Items i
        }

        private void lb_ua_MouseDown(object sender, MouseButtonEventArgs e)
        {
            btn_info.Content = "Інформація";
            btn_order.Content = "Замовлення";
            pope_info.Content = "Якась інформація";
        }

        private void cb_choice_Loaded(object sender, RoutedEventArgs e)
        {
            // cb_choice.SelectedIndex = 0;
            List<MyComboBoxItems> itemsEN = new List<MyComboBoxItems>
            {
                new MyComboBoxItems { Id = 0, Name = "test" },
                new MyComboBoxItems { Id = 1, Name = "Test" }
            };
            List<MyComboBoxItems> itemsUA = new List<MyComboBoxItems>
            {
                new MyComboBoxItems { Id = 0, Name = "тест" },
                new MyComboBoxItems { Id = 1, Name = "Тест" }
            };
            cb_choice.ItemsSource = itemsEN;
            cb_choice.SelectedIndex = 0;
            var data = cb_choice.Items[0] as MyComboBoxItems;
        }
    }
}
