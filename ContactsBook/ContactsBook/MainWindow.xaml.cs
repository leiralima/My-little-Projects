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
            //loadDataGrid();
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
                //objwin.Activate();
            }
            objwin.Show();
        }
        private void loadDataGrid()
        {
            List<Contact> contacts;// = new List<string>();
            contacts = arq.readFile();
            int i = 0;
            string str;// = new string[] { contacts };
            //DataGrid grid = new DataGrid();
            //DataGridCell cellName = new DataGridCell();//, cellPhone = new DataGridCell(), cellEmail = new DataGridCell(), cellId = new DataGridCell();
            //DataGridRow row = new DataGridRow();//, rowPhone = new DataGridRow(), rowEmail = new DataGridRow(), rowId = new DataGridRow();
            //DataGridColumn column;// = new DataGridColumn();
            //MessageBox.Show(contacts.Count.ToString(), "Title");
            for (i = 0; i < contacts.Count-1; i++)
            {
                //TabItem tab = new TabItem();
                //TextBox txt = new TextBox();
                
                //str = contacts.ElementAt(i).ToString();
                MainList.ItemsSource = contacts;
                //MainList.Items.Add(str);

                //tab.Content = str;
                //DataGridMain.Items.Add(tab);
                //tab = null;
                //DataGridMain.Items.Insert(i, row);
                //txt.Text = str;
                //cellName.Content = str;
                //row.DataContext = cellName;
                //row.Item = cellName;
                //MessageBox.Show(cellName.ToString(),"title");
                //MessageBox.Show(row.ToString(), "title");
                //DataGridMain.Columns.Add(row.DataContext);
                //DataGridMain.Items.Add(row);
                //contacts.RemoveAt(i);
                //MessageBox.Show(row,"Contacts");
            }
        }

        private void btnRefresh_Click(object sender, RoutedEventArgs e)
        {
            //DataGridMain.Items.Clear();
            //MainList.Items.Clear();
            loadDataGrid();
        }
    }
}
