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
        private float num1=0;
        private float num2=0;
        private char operation='0';
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
            if (!TextBox.Text.Contains(","))
            {
                TextBox.Text = TextBox.Text + ",";
            }
        }

        private void btnDiv_Click(object sender, RoutedEventArgs e)
        {
            if (TextBox.Text.Length != 0) {
                float.TryParse(TextBox.Text, out num1);
                operation = '/';
                btnClear_Click(sender, e);
            }
        }

        private void btnMulti_Click(object sender, RoutedEventArgs e)
        {
            if (TextBox.Text.Length != 0)
            {
                float.TryParse(TextBox.Text, out num1);
                operation = '*';
                btnClear_Click(sender, e);
            }
        }

        private void btnMinus_Click(object sender, RoutedEventArgs e)
        {
            if (TextBox.Text.Length != 0)
            {
                float.TryParse(TextBox.Text, out num1);
                operation = '-';
                btnClear_Click(sender, e);
            }
        }

        private void btnPlus_Click(object sender, RoutedEventArgs e)
        {
            if (TextBox.Text.Length != 0)
            {
                float.TryParse(TextBox.Text, out num1);
                operation = '+';
                btnClear_Click(sender, e);
            }
        }

        private void btnErase_Click(object sender, RoutedEventArgs e)
        {
            if (TextBox.Text.Length != 0)
            {
                int index = TextBox.Text.Length;
                String st = TextBox.Text;
                TextBox.Text = st.Remove(index - 1);
            }
        }

        private void btnEquals_Click(object sender, RoutedEventArgs e)
        {
            float.TryParse(TextBox.Text, out num2);
            switch (operation)
            {
                case '/':
                    num1 = num1 / num2;
                    TextBox.Text = num1.ToString();
                    operation = '0';
                    break;
                case '*':
                    num1 = num1 * num2;
                    TextBox.Text = num1.ToString();
                    operation = '0';
                    break;
                case '-':
                    num1 = num1 - num2;
                    TextBox.Text = num1.ToString();
                    operation = '0';
                    break;
                case '+':
                    num1 = num1 + num2;
                    TextBox.Text = num1.ToString();
                    operation = '0';
                    break;
                case '0':
                    break;
                default:
                    TextBox.Text = "Invalid Operation!";
                    operation = '0';
                    break;
            }
        }
    }
}
