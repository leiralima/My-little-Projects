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

namespace Calculator1
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

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            TextBox.Text = "";
        }

        private void btnOne_Click(object sender, RoutedEventArgs e)
        {
            TextBox.Text = TextBox.Text + "1";
        }

        private void btnTwo_Click(object sender, RoutedEventArgs e)
        {
            TextBox.Text = TextBox.Text+"2";
        }

        private void btnThree_Click(object sender, RoutedEventArgs e)
        {
            TextBox.Text = TextBox.Text + "3";
        }

        private void btnFour_Click(object sender, RoutedEventArgs e)
        {
            TextBox.Text = TextBox.Text + "4";
        }

        private void btnFive_Click(object sender, RoutedEventArgs e)
        {
            TextBox.Text = TextBox.Text + "5";
        }

        private void btnSix_Click(object sender, RoutedEventArgs e)
        {
            TextBox.Text = TextBox.Text + "6";
        }

        private void btnSeven_Click(object sender, RoutedEventArgs e)
        {
            TextBox.Text = TextBox.Text + "7";
        }

        private void btnEight_Click(object sender, RoutedEventArgs e)
        {
            TextBox.Text = TextBox.Text + "8";
        }

        private void btnNine_Click(object sender, RoutedEventArgs e)
        {
            TextBox.Text = TextBox.Text + "9";
        }

        private void btnZero_Click(object sender, RoutedEventArgs e)
        {
            TextBox.Text = TextBox.Text + "0";
        }

        private void btnDot_Click(object sender, RoutedEventArgs e)
        {
            TextBox.Text = TextBox.Text + ".";
        }
    }
}
