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
    /// ListView is named MainList
    /// </summary>
    public partial class MainWindow : Window
    {
        private Window1 objwin = new Window1();
        private Window2 objedit;
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
            contacts = arq.readFile();//recieves each line of the file as an item on the list
            for (int i = 0; i < contacts.Count - 1; i++)//splits each item into attributes of the auxiliary class User
            {
                line = contacts[i];
                str = line.Split(";");
                aux.Add(new User() { Name = str[0], Phone = str[1], Email = str[2], ID = str[3] });
            }
            MainList.ItemsSource = aux;//Loads the List view by making each of the corresponding columns of the ListView recieve the list of Users
        }

        private void btnRefresh_Click(object sender, RoutedEventArgs e)
        {
            loadDataGrid();
        }
        private class User//auxiliary class
        {
            public string Name { get; set; }
            public string Phone { get; set; }
            public string Email { get; set; }
            public string ID { get; set; }
        }
        private void MainList_MouseDown(object sender, MouseButtonEventArgs e)//Opens the context menu when an item of the ListView is clicked with the right mouse button
        {
            if (e.ChangedButton == MouseButton.Right)
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
            var selectedStockObject = MainList.SelectedItems[0] as User;//gets the value of the selected item of the ListView
            if (selectedStockObject == null)
            {
                return;
            }
            objedit = new Window2(selectedStockObject.Name, selectedStockObject.Phone, selectedStockObject.Email, selectedStockObject.ID);//send the values to the edit window
            objedit.Show();
            loadDataGrid();
        }
        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            var selectedStockObject = MainList.SelectedItems[0] as User;//gets the value of the selected item of the ListView
            if (selectedStockObject == null)
            {
                return;
            }
            string str = selectedStockObject.Name + ";" + selectedStockObject.Phone + ";" + selectedStockObject.Email + ";" + selectedStockObject.ID;
            arq.deleteLineFile(str);//send the value of all added values of the selected item to the delete function
            loadDataGrid();
        }
    }
}
