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


using BDD.practika2DataSet1TableAdapters;
namespace BDD
{
    /// <summary>
    /// Логика взаимодействия для warehouse.xaml
    /// </summary>
    public partial class warehouse : Window
    {
        warehouse_TableAdapter warehouse_ = new warehouse_TableAdapter();
        public warehouse()
        {
            InitializeComponent();
            warehouseDataGrid.ItemsSource = warehouse_.GetData();
        }

        private void warehouseDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            staff stafff = new staff();
            stafff.Show();
            this.Close();
        }
    }
}
