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

namespace NumberChecker
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private float num = 0;//number to be checked
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnCheck_Click(object sender, RoutedEventArgs e)
        {
            if(float.TryParse(TextBox.Text, out num))
            {
                writeLabel("");
                num = num % 2;
                if (num == 0)
                {
                    writeLabel("The number is even.");
                }
                else
                {
                    writeLabel("The number is odd.");
                }
            }
            else
            {
                writeLabel("Invalid entry. Please enter a valid number.");
            }
        }
        private void writeLabel(string s)
        {
            lbCheck.Content = s;
        }
    }
}
