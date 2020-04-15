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
            if (TxtBoxName.Text.Length != 0 && TxtBoxPhone.Text.Length != 0 && TxtBoxEmail.Text.Length != 0)//Checks if there is any field empty
            {
                if (TxtBoxEmail.Text.Contains(";") || TxtBoxName.Text.Contains(";") || TxtBoxPhone.Text.Contains(";"))//Checks if any field contains ";"
                {
                    MessageBox.Show("Warning! The entry fields can not contain ';' character.", "Invalid entry");//If there is it gives a warning message
                }
                else//If none of the fields contain ";" then it proceeds to save the contact on the file
                {
                    person.setName(TxtBoxName.Text);
                    person.setPhone(TxtBoxPhone.Text);
                    person.setEmail(TxtBoxEmail.Text);
                    Archive arq = new Archive();
                    arq.writeFile(person.getName(), person.getPhone(), person.getEmail(), person.generateID());//This part inserts new contact into the file
                    person = null;//deletes the instance of the Contact object
                    this.Close();
                }
            }
            else//If any field is empty it gives a warning message
            {
                string message = "The following field(s) is(are) empty:\n";
                if (TxtBoxName.Text.Length == 0)
                {
                    message += "Name\n";
                }
                if (TxtBoxPhone.Text.Length == 0)
                {
                    message += "Phone\n";
                }
                if (TxtBoxEmail.Text.Length == 0)
                {
                    message += "E-mail\n";
                }
                MessageBox.Show(message, "Warning! Empty field(s)!");
            }
        }
    }
}
