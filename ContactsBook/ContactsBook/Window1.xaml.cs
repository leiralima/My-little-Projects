using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ContactsBook
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            /*MainWindow mainWindow = new MainWindow();
            mainWindow.Show();*/
            this.Close();
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            //TxtBoxName.Text = person.generateID();
            /*person.setName(TxtBoxName.Text);
            person.setPhone(TxtBoxPhone.Text);
            person.setEmail(TxtBoxEmail.Text);*/
            /*MainWindow mainWindow = new MainWindow();
            mainWindow.Show();*/
            /*MainWindow win = new MainWindow();
            win.setContact(TxtBoxName.Text, TxtBoxPhone.Text, TxtBoxEmail.Text);
            win.Show();*/
            //win.Close();
            /*Contact person = new Contact();
            person.setName(TxtBoxName.Text);
            person.setPhone(TxtBoxPhone.Text);
            person.setEmail(TxtBoxEmail.Text);
            person.generateID();*/
            this.Close();
        }
    }
}
