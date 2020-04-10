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
        private Contact person;
        //Contact[] personList;
        private Window1 objwin;// = new Window1();
        public string name="0", phone="0", email="0";
        private static int _variable1;
        public static int variable1
        {
            get // this makes you to access value in form2
            {
                return _variable1;
            }
            set // this makes you to change value in form2
            {
                _variable1 = value;
            }
        }
        public MainWindow()
        {
            InitializeComponent();
            /*lbTest.Content = "";
            lbTest.Content = lbTest.Content + name;
            lbTest.Content = lbTest.Content + phone;
            lbTest.Content = lbTest.Content + email;*/
        }
        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            objwin.Close();
            this.Close();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            /*if (name.Length != 0)
            {*/
            lbTest.Content = "";
            lbTest.Content = lbTest.Content + name;
            lbTest.Content = lbTest.Content + phone;
            lbTest.Content = lbTest.Content + email;
            //}
            objwin = new Window1();
            //this.Hide();
            objwin.Show();
        }
        public void setContact(string name,string phone,string email)
        {
            person = new Contact();
            this.phone = phone;
            this.email = email;
            person.setName(name);
            person.setPhone(phone);
            person.setEmail(email);
            person.generateID();
        }
    }
}
