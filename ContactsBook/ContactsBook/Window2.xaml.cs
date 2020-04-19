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
    /// Lógica interna para Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        private Archive arq = new Archive();
        private string name, phone, email, id;
        public Window2(string name,string phone,string email,string id)
        {
            InitializeComponent();
            //the TextBoxes will be used to edited the contact
            TxtBoxName.Text = name;
            TxtBoxPhone.Text = phone;
            TxtBoxEmail.Text = email;
            //while the private strings will store the old unedited versions
            this.name = name;
            this.phone = phone;
            this.email = email;
            this.id = id;
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            if (TxtBoxName.Text.Length != 0 && TxtBoxPhone.Text.Length != 0 && TxtBoxEmail.Text.Length != 0)//checks if any field is empty
            {
                if (TxtBoxName.Text == this.name && TxtBoxPhone.Text == this.phone && TxtBoxEmail.Text == this.email)//checks if all fields are equal to the unedited versions
                {
                    MessageBox.Show("Cannot save. The fields where not changed.", "Error!");//if it is a warning is given
                }
                else//if not the operation follows
                {
                    string newStr, oldStr;
                    oldStr = this.name + ";" + this.phone + ";" + this.email + ";" + this.id;//construction of the old string
                    newStr = TxtBoxName.Text + ";" + TxtBoxPhone.Text + ";" + TxtBoxEmail.Text + ";" + id;//construction of the new string
                    arq.editFile(oldStr,newStr);//sending both strings to the edit function
                    this.Close();
                }
            }
            else//if any field is empty a warning is given
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
