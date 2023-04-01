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
    /// Логика взаимодействия для add2.xaml
    /// </summary>
    public partial class add2 : Window
    {
        staff_TableAdapter staff_ = new staff_TableAdapter();
        warehouse_TableAdapter warehouse_ = new warehouse_TableAdapter();

        public add2()
        {
            InitializeComponent();
            spisok2.ItemsSource = staff_.GetData();
            spisok2.DisplayMemberPath = "name_w";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            staff_.InsertQuery1(enter2.Text, enter3.Text, enter4.Text, enter5.Text, spisok2.SelectedIndex+1);
            staff stafff = new staff();
            stafff.Show();
            this.Close();
        }
    }
}
