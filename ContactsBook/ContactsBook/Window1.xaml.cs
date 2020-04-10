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
        private Contact person = new Contact();
        public Window1()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            newContact(TxtBoxName.Text, TxtBoxPhone.Text, TxtBoxEmail.Text);
            //Insert person into file
            Arquive arq = new Arquive();
            arq.writeFile(person.getName(),person.getPhone(),person.getEmail(),person.generateID());
            person = null;
            this.Close();
        }
        private void newContact(string name, string phone, string email)
        {
            person.setName(name);
            person.setPhone(phone);
            person.setEmail(email);
        }
    }
}
