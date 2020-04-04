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

namespace Scrambler
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnScr_Click(object sender, RoutedEventArgs e)
        {
            var builder = new StringBuilder();//variable for building a string
            string s1, s2;//string to input
            //This sets the string with the given text and cleans the third text box
            s1 = TxtBox1.Text;
            s2 = TxtBox2.Text;
            TxtBox3.Text = "";
            //Checks which string is bigger to be used as limit for the FOR operation
            int index = 0;
            if (s1.Length > s2.Length)
            {
                index = s1.Length;
            }
            else
            {
                index = s2.Length;
            }
            for (int i = 0; i < index; i++)//FOR operation that builds the new string
            {
                if (i < s1.Length)
                {
                    builder.Append(s1[i]);
                }
                if (i < s2.Length)
                {
                    builder.Append(s2[i]);
                }//Both IF check if the given string still has characters left. If they do it is integrated into the final string
            }
            TxtBox3.Text = builder.ToString();
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            TxtBox1.Text = "";
            TxtBox2.Text = "";
            TxtBox3.Text = "";
        }

        private void btnUnscr_Click(object sender, RoutedEventArgs e)
        {
            var builder1 = new StringBuilder();
            var builder2 = new StringBuilder();//variables for building a string
            string str;//string to input
            //This sets the strings with the given texts and cleans the first and second text boxes
            str = TxtBox3.Text;
            TxtBox1.Text = "";
            TxtBox2.Text = "";
            //Sets the limit to the FOR operation
            int index = str.Length;
            for (int i = 0; i < index; i++)//FOR operation that builds the new string
            {
                if (i % 2 == 0)
                {
                    builder1.Append(str[i]);
                }
                else
                {
                    builder2.Append(str[i]);
                }
            }
            TxtBox1.Text = builder1.ToString();
            TxtBox2.Text = builder2.ToString();
        }
    }
}
