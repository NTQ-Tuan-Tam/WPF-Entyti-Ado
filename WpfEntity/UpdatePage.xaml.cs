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
    /// Interaction logic for UpdatePage.xaml
    /// </summary>
    public partial class UpdatePage : Window
    {
        EntityWPFEntities _db = new EntityWPFEntities();
        int _id;

        public UpdatePage( int UserId)
        {
            InitializeComponent();
            _id = UserId;
        }

        private void InsertBtn_Click(object sender, RoutedEventArgs e)
        {
            User  updateUser = (from m in _db.Users
                               where m.Id == _id
                               select m).Single();
            _db.SaveChanges();
            MainWindow.datagrid.ItemsSource = _db.Users.ToList();
            this.Hide();
        }

        private void ComboBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
