using BDD.practika2DataSet1TableAdapters;
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

namespace BDD
{
    /// <summary>
    /// Логика взаимодействия для add.xaml
    /// </summary>
    public partial class add : Window
    {
        clothes__TableAdapter clothes_ = new clothes__TableAdapter();
        warehouse_TableAdapter warehouse_ = new warehouse_TableAdapter();

        public add()
        {
            InitializeComponent();
            spisok.ItemsSource = warehouse_.GetData();
            spisok.DisplayMemberPath = "name_w";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            clothes_.InsertQuery(enter1.Text, spisok.SelectedIndex+1);
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void enter1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
