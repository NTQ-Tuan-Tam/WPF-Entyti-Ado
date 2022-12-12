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

namespace WpfEntity
{
    /// <summary>
    /// Interaction logic for InsertPage.xaml
    /// </summary>
    public partial class InsertPage : Window
    {
        EntityWPFEntities _db = new EntityWPFEntities();
        public InsertPage()
        {
            InitializeComponent();
        }

        

        //private void InsertBtn_Click(object sender, RoutedEventArgs e)
        //{
        //    User newUsers = new User()
        //    {
        //        Name = NameTextBox.Text,
        //        Gender = GenderComboBox.Text

        //    };
        //    _db.Users.Add(newUsers);
        //    _db.SaveChanges();
        //    MainWindow.datagrid.ItemsSource = _db.Users.ToList();
        //    this.Hide();

        //}

        private void ComboBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void InsertBtn_Click_1(object sender, RoutedEventArgs e)
        {
            User newUsers = new User()
            {
                Name = NameTextBox.Text,
                Gender = GenderComboBox.Text

            };
            _db.Users.Add(newUsers);
            _db.SaveChanges();
            MainWindow.datagrid.ItemsSource = _db.Users.ToList();
            this.Hide();
        }
    }
}
