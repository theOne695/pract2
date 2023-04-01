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
    /// Логика взаимодействия для staff.xaml
    /// </summary>
    public partial class staff : Window
    {
        staff_TableAdapter staff_ = new staff_TableAdapter();
        public staff()
        {
            InitializeComponent();
            staffDataGrid.ItemsSource = staff_.GetData();
        }

        private void staffDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            add2 mainWindow = new add2();
            mainWindow.Show();
            this.Close();
        }
    }
}
