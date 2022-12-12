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

namespace WpfEntity
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        EntityWPFEntities _db = new EntityWPFEntities();
        public static DataGrid datagrid;
        public MainWindow()
        {
            InitializeComponent();
            Load();
        }
        private void Load()
        {
            myDataGrid.ItemsSource = _db.Users.ToList();
            datagrid = myDataGrid;
        }

        private void InsertBtn_Click(object sender, RoutedEventArgs e)
        {
            InsertPage Ipage = new InsertPage();
            Ipage.ShowDialog();
        }

        private void UpdateBtn_Click(object sender, RoutedEventArgs e)
        {
            int id = (myDataGrid.SelectedItems as User).Id;
            UpdatePage Upage = new UpdatePage(id);
            Upage.ShowDialog();
        }

        private void DeleteBtn_Click(object sender, RoutedEventArgs e)
        {
            int id = (myDataGrid.SelectedItem as User).Id;
            var deleteUser = _db.Users.Where(x => x.Id == id).Single();
            _db.Users.Remove(deleteUser);
            _db.SaveChanges();
            myDataGrid.ItemsSource = _db.Users.ToList();
        }

        private void myDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            InsertPage Ipage = new InsertPage();
            Ipage.ShowDialog();
        }
    }
}
