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

namespace Education_Practic_num_1
{
    public partial class EF_Page : Page
    {
        private Information_System_Of_MarketEntities context = new Information_System_Of_MarketEntities();  
        public EF_Page()
        {
            InitializeComponent();
            Products_DataGrid.ItemsSource = context.Products.ToList();
            Stock_DataGrid.ItemsSource = context.Stock.ToList();
        }

        private void Open_Table_Products_Click(object sender, RoutedEventArgs e)
        {
            Stock_DataGrid.Visibility = Visibility.Hidden;
            Products_DataGrid.Visibility = Visibility.Visible;
        }

        private void Open_Table_Stock_Click(object sender, RoutedEventArgs e)
        {
            Products_DataGrid.Visibility = Visibility.Hidden;
            Stock_DataGrid.Visibility = Visibility.Visible;
        }
    }
}
