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

namespace ContactsBook
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Window1 objwin = new Window1();
        private Archive arq = new Archive();
        public MainWindow()
        {
            InitializeComponent();
            loadDataGrid();
        }
        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            arq = null;
            objwin.Close();
            this.Close();
        }
        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            if (objwin.IsActive == false)
            {
                objwin.Close();
                objwin = new Window1();
            }
            objwin.Show();
        }
        private void loadDataGrid()
        {
            List<string> contacts = new List<string>();
            List<User> aux = new List<User>();
            string[] str;
            string line;
            contacts = arq.readFile();
            for (int i = 0; i < contacts.Count-1; i++)
            {
                line = contacts[i];
                str = line.Split(";");
                aux.Add(new User() { Name = str[0], Phone = str[1], Email = str[2], ID = str[3] });
            }
            MainList.ItemsSource = aux;
        }

        private void btnRefresh_Click(object sender, RoutedEventArgs e)
        {
            loadDataGrid();
        }
        public class User
        {
            public string Name { get; set; }
            public string Phone { get; set; }
            public string Email { get; set; }
            public string ID { get; set; }
        }
        private void MainList_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                ListView list = sender as ListView;
                ContextMenu contextMenu = list.ContextMenu;
                contextMenu.PlacementTarget = list;
                contextMenu.Placement = System.Windows.Controls.Primitives.PlacementMode.Top;
                contextMenu.IsOpen = true;
            }
        }
        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            arq.editFile();
        }
        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            arq.deleteLineFile();
        }
    }
}
