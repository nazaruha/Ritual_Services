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
        int cb_choice_selected { get; set; } = -1;

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
            isEng = true;
            ChangeLanguage();
        }

        private void lb_ua_MouseDown(object sender, MouseButtonEventArgs e)
        {
            isEng = false;
            ChangeLanguage();
        }

        private void cb_choice_Loaded(object sender, RoutedEventArgs e)
        {
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
            InitializeListView(isEng);
        }

        private void WindowToUkrainian()
        {
            btn_info.Content = "Інформація";
            btn_order.Content = "Замовити";
            father_info.Text = "Ефінапій Кронапій - 32 роки.\r\nНайкращий батя в світі!\r\nЛюбить дітей, реп і не тільки.\r\nЗнешкодив 10 демонів, 5 вампірів і 20 відьом";
            InitializeComboBox(isEng);
            InitializeListView(isEng);
        }

        private void InitializeListView(bool isEng)
        {
            switch (isEng)
            {
                case true:
                    {
                        ListViewToEng();
                        break;
                    }
                case false:
                    {
                        ListViewToUA();
                        break;
                    }
            }
        }

        private void ListViewToEng()
        {
            if (cb_choice.SelectedItem.ToString() == "All")
            {
                list_view.Items.Clear();
                foreach (var item in context.Services)
                {
                    MyListViewItems serviceEng = new MyListViewItems() { Id = item.Id, Name = item.NameEng, Price = item.Price, Description = item.DescriptionEng, Photo = item.Photo, ServiceTypeId = item.ServiceTypeId};
                    list_view.Items.Add(serviceEng);
                }
            }
            else if (cb_choice.SelectedItem.ToString() == "Church")
            {
                var st = context.ServicesTypes.Where(st => st.NameEng == "Church");
                list_view.Items.Clear();
                foreach (var item in context.Services)
                {
                    if (item.ServiceType == st)
                    {
                        MyListViewItems serviceEng = new MyListViewItems() { Id = item.Id, Name = item.NameEng, Price = item.Price, Description = item.DescriptionEng, Photo = item.Photo, ServiceTypeId = item.ServiceTypeId };
                        list_view.Items.Add(serviceEng);
                    }
                }
            }
            else if (cb_choice.SelectedItem.ToString() == "Ritual")
            {
                var st = context.ServicesTypes.Where(st => st.NameEng == "Ritual");
                list_view.Items.Clear();
                foreach (var item in context.Services)
                {
                    if (item.ServiceType == st)
                    {
                        MyListViewItems serviceEng = new MyListViewItems() { Id = item.Id, Name = item.NameEng, Price = item.Price, Description = item.DescriptionEng, Photo = item.Photo, ServiceTypeId = item.ServiceTypeId };
                        list_view.Items.Add(serviceEng);
                    }
                }
            }
        }

        private void ListViewToUA()
        {
            if (cb_choice.SelectedItem.ToString() == "Всі")
            {
                list_view.Items.Clear();
                foreach (var item in context.Services)
                {
                    MyListViewItems serviceEng = new MyListViewItems() { Id = item.Id, Name = item.NameUA, Price = item.Price, Description = item.DescriptionUA, Photo = item.Photo, ServiceTypeId = item.ServiceTypeId };
                    list_view.Items.Add(serviceEng);
                }
            }
            else if (cb_choice.SelectedItem.ToString() == "Церковні")
            {
                list_view.Items.Clear();
                foreach (var item in context.Services)
                {
                    MyListViewItems serviceEng = new MyListViewItems() { Id = item.Id, Name = item.NameUA, Price = item.Price, Description = item.DescriptionUA, Photo = item.Photo, ServiceTypeId = item.ServiceTypeId };
                    if (item.ServiceType == context.ServicesTypes.Where(st => st.NameUA == "Церковні"))
                        list_view.Items.Add(serviceEng);
                }
            }
            else if (cb_choice.SelectedItem.ToString() == "Ритуальні")
            {
                var st = context.ServicesTypes.Where(st => st.NameUA == "Ритуальні");
                list_view.Items.Clear();
                foreach (var item in context.Services)
                {
                    MyListViewItems serviceEng = new MyListViewItems() { Id = item.Id, Name = item.NameUA, Price = item.Price, Description = item.DescriptionUA, Photo = item.Photo, ServiceTypeId = item.ServiceTypeId };
                    if (item.ServiceType == context.ServicesTypes.Where(st => st.NameUA == "Ритуальні"))
                        list_view.Items.Add(serviceEng);
                }
            }
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
            MyComboBoxItems itemAll = new MyComboBoxItems() { Id = 0, Name = "All" };
            foreach (var item in context.ServicesTypes)
            {
                MyComboBoxItems itemEN = new MyComboBoxItems() { Id = item.Id, Name = item.NameEng };
                itemsEN.Add(itemEN);
            }
            itemsEN.Add(itemAll);
            cb_choice.ItemsSource = itemsEN;
            if (cb_choice.SelectedIndex == -1)
                cb_choice.SelectedItem = itemAll;
            else
                cb_choice.SelectedIndex = cb_choice_selected;
        }

        private void ComboBoxToUA()
        {
            List<MyComboBoxItems> itemsUA = new List<MyComboBoxItems>();
            MyComboBoxItems itemAll = new MyComboBoxItems() { Id = 0, Name = "Всі" };
            foreach (var item in context.ServicesTypes)
            {
                MyComboBoxItems itemUA = new MyComboBoxItems() { Id = item.Id, Name = item.NameUA };
                itemsUA.Add(itemUA);
            }
            itemsUA.Add(itemAll);
            cb_choice.ItemsSource = itemsUA;
            if (cb_choice.SelectedIndex == -1)
                cb_choice.SelectedItem = itemAll;
            else
                cb_choice.SelectedIndex = cb_choice_selected;

        }

        private void cb_choice_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cb_choice.SelectedIndex == -1) return;
            InitializeListView(isEng);
            cb_choice_selected = cb_choice.SelectedIndex;
        }
    }
}
