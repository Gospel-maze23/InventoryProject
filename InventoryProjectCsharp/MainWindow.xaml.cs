using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace InventoryProjectCsharp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Inventory inventory;
        public MainWindow()
        {
            InitializeComponent();

            inventory = new Inventory();

            listView.ItemsSource = inventory.ProductTbls.ToList();
        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            listView.ItemsSource = inventory.ProductTbls
                .Where(p => p.ProductName.Contains(((TextBox)sender).Text))
                .ToList();
        }

        private void comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var x = (ComboBox)sender;

            try
            {
                if (x.SelectedIndex == 0)
                {
                    listView.ItemsSource = inventory.ProductTbls
                        .OrderBy(p => p.ProductName)
                        .ToList();
                }
                else if (x.SelectedIndex == 1)
                {
                    listView.ItemsSource = inventory.ProductTbls
                        .OrderByDescending(p => p.ProductName)
                        .ToList();
                }
                else if (x.SelectedIndex == 2)
                {
                    listView.ItemsSource = inventory.ProductTbls
                        .OrderBy(p => p.ProductStock)
                        .ToList();
                }
                else
                {
                    listView.ItemsSource = inventory.ProductTbls
                        .OrderByDescending(p => p.ProductStock)
                        .ToList();
                }
            }
            catch (Exception) { }
        }
    }
}
