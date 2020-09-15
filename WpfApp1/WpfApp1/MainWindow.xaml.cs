using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace WpfApp1
{
    public partial class MainWindow : Window
    {
        ObservableCollection<Clima_tech> Techs { get; set; }
        TechManager manager;

        public MainWindow()
        {
            InitializeComponent();

            manager = new TechManager();
            manager.Filters = new List<string>();

            Techs = new ObservableCollection<Clima_tech>(manager.Get_all_techs_by_category("all_techs"));

            techsList.ItemsSource = Techs;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Techs = new ObservableCollection<Clima_tech>(manager.Get_filtered_sorted_techs());
            techsList.ItemsSource = Techs;
        }

        private void TreeViewItem_Selected(object sender, RoutedEventArgs e)
        {
            TreeViewItem tvItem = (TreeViewItem)sender;
            switch (tvItem.Header.ToString())
            {
                case "Condition":
                    manager.category = "air_conditions";
                    break;
                case "Cleaner":
                    manager.category = "air_cleaners";
                    break;
                case "Fan":
                    manager.category = "fans";
                    break;
                case "Heater":
                    manager.category = "heaters";
                    break;
                case "Humidifier":
                    manager.category = "humidifiers";
                    break;
                case "All techs":
                    manager.category = "all_techs";
                    break;
            }
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            manager.Filters.Add("avaible");
        }

        private void CheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            manager.Filters.Remove("avaible");
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            manager.Filters.Add("more than 2000");
        }

        private void RadioButton_Unchecked(object sender, RoutedEventArgs e)
        {
            manager.Filters.Remove("more than 2000");
        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {
            manager.Filters.Add("less than 2001");
        }

        private void RadioButton_Unchecked_1(object sender, RoutedEventArgs e)
        {
            manager.Filters.Remove("less than 2001");
        }

        private void techsList_SelectionChanged(object sender, SelectionChangedEventArgs e)   
        {
            Clima_tech c = (Clima_tech)techsList.SelectedItem;
            if (c != null)
            {
                BitmapImage bitmap = new BitmapImage();
                bitmap.BeginInit();
                bitmap.UriSource = new Uri(c.ImagePath, UriKind.Absolute);
                bitmap.EndInit();

                last_item.Source = bitmap;
                last_item_label.Text = c.Name_of_tech;

                InfoWindow taskWindow = new InfoWindow(c);
                taskWindow.Owner = this;

                taskWindow.Show();
            }
        }

        private void TreeViewItem_Selected_1(object sender, RoutedEventArgs e)
        {
            TreeViewItem tvItem = (TreeViewItem)sender;
            switch (tvItem.Header.ToString())
            {
                case "ASC":
                    manager.option = "ASC";
                    break;
                case "DESC":
                    manager.option = "DESC";
                    break;
            }
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            manager.Search_option_name = (textBox.Text.ToString()).ToLower();
        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            manager.Search_option_area = (textBox.Text.ToString()).ToLower();
        }
    }
}
