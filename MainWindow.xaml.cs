using System;
using System.Collections;
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

using BDD.practika2DataSet1TableAdapters;

namespace BDD
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        clothes__TableAdapter clothes = new clothes__TableAdapter();
        public MainWindow()
        {
            InitializeComponent();
            clothesDataGrid.ItemsSource = clothes.GetData();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            add add_ = new add();
            add_.Show();
            this.Close();
        }

        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            warehouse warehousee = new warehouse();
            warehousee.Show();
            this.Close();
        }

    }
}
