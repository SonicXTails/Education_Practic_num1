using Education_Practic_num_1.Information_System_Of_MarketDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
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
    public partial class DataSet_Page : Page
    {
        ProductsTableAdapter product = new ProductsTableAdapter();
        StockTableAdapter stock = new StockTableAdapter();

        public DataSet_Page()
        {
            InitializeComponent();
            Products_DataGrid.ItemsSource = product.GetData();
            Stock_DataGrid.ItemsSource = stock.GetData();

            Stock_DataGrid.Visibility = Visibility.Hidden;
            Products_DataGrid.Visibility = Visibility.Hidden;

            
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
