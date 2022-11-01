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
using LibContext;

namespace UserApplication
{
    /// <summary>
    /// Логика взаимодействия для Church_Web.xaml
    /// </summary>
    public partial class Church_Web : Window
    {
        public MyDataContext context;
        bool isEng { get; set; } = true;
        public Church_Web(bool isEng)
        {
            InitializeComponent();
            context = new MyDataContext();
            this.isEng = isEng;
            if (!this.isEng)
            {
                ChangeLanguage();
            }
        }

        private void Button_Info_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Order_Click(object sender, RoutedEventArgs e)
        {

        }

        private void lb_en_MouseDown(object sender, MouseButtonEventArgs e)
        {
            //btn_info.Content = "Info";
            //btn_order.Content = "Order";
            //pope_info.Content = "Info 'bout priest";
            //cb_choice.Items i
            isEng = true;
            ChangeLanguage();
        }

        private void lb_ua_MouseDown(object sender, MouseButtonEventArgs e)
        {
            //btn_info.Content = "Інформація";
            //btn_order.Content = "Замовити";
            //pope_info.Content = "Інформація про Батюшку";
            isEng = false;
            ChangeLanguage();
        }

        private void cb_choice_Loaded(object sender, RoutedEventArgs e)
        {
            // cb_choice.SelectedIndex = 0;
            //List<MyComboBoxItems> itemsEN = new List<MyComboBoxItems>
            //{
            //    new MyComboBoxItems { Id = 0, Name = "test" },
            //    new MyComboBoxItems { Id = 1, Name = "Test" }
            //};
            //List<MyComboBoxItems> itemsUA = new List<MyComboBoxItems>
            //{
            //    new MyComboBoxItems { Id = 0, Name = "тест" },
            //    new MyComboBoxItems { Id = 1, Name = "Тест" }
            //};
            //cb_choice.ItemsSource = itemsEN;
            //cb_choice.SelectedIndex = 0;
            //var data = cb_choice.Items[0] as MyComboBoxItems;
            InitializeComboBox(isEng);

        }

        private void ChangeLanguage() // Need to make changes with listView only 
        {
            switch (isEng)
            {
                case true: // english
                    {
                        WindowToEnglish();
                        break;
                    }
                case false: // ukrainian
                    {
                        WindowToUkrainian();
                        break;
                    }
            }
            
        }

        private void WindowToEnglish()
        {
            btn_info.Content = "Info";
            btn_order.Content = "Order";
            father_info.Text = "Ephinapiy Kronapiy - 32 y.o.\r\nThe best father in the world!\r\nLoves children, rep etc.\r\nNeutralized 10 demons, 5 vampires and 20 witches.";
            InitializeComboBox(isEng);
            
        }

        private void WindowToUkrainian()
        {
            btn_info.Content = "Інформація";
            btn_order.Content = "Замовити";
            father_info.Text = "Ефінапій Кронапій - 32 роки.\r\nНайкращий батя в світі!\r\nЛюбить дітей, реп і не тільки.\r\nЗнешкодив 10 демонів, 5 вампірів і 20 відьом";
            InitializeComboBox(isEng);
        }

        private void InitializeComboBox(bool isEng)
        {
            switch (isEng)
            {
                case true:
                    {
                        ComboBoxToEng();
                        break;
                    }
                case false:
                    {
                        ComboBoxToUA();
                        break;
                    }
            }
        }

        private void ComboBoxToEng()
        {
            List<MyComboBoxItems> itemsEN = new List<MyComboBoxItems>();
            foreach (var item in context.ServicesTypes)
            {
                MyComboBoxItems itemEN = new MyComboBoxItems() { Id = item.Id, Name = item.NameEng };
                itemsEN.Add(itemEN);
            }
            cb_choice.ItemsSource = itemsEN;
        }

        private void ComboBoxToUA()
        {
            List<MyComboBoxItems> itemsUA = new List<MyComboBoxItems>();
            foreach (var item in context.ServicesTypes)
            {
                MyComboBoxItems itemUA = new MyComboBoxItems() { Id = item.Id, Name = item.NameUA };
                itemsUA.Add(itemUA);
            }
            cb_choice.ItemsSource = itemsUA;
        }
    }
}
