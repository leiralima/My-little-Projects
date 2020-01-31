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
        private float num1=0;//First number
        private float num2=0;//Second number
        private char operation='0';//Defines which operation will be used, as noted below:
        //'0' is none, '/' is division, '*' is multiplication, '-' is subtraction, '+' is addition
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)//Exits the program
        {
            this.Close();
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)//Clears the TextBox
        {
            TextBox.Text = "";
        }

        private void btnOne_Click(object sender, RoutedEventArgs e)//Adds the number 1 to the TextBox
        {
            TextBox.Text = TextBox.Text + "1";
        }

        private void btnTwo_Click(object sender, RoutedEventArgs e)//Adds the number 2 to the TextBox
        {
            TextBox.Text = TextBox.Text+"2";
        }

        private void btnThree_Click(object sender, RoutedEventArgs e)//Adds the number 3 to the TextBox
        {
            TextBox.Text = TextBox.Text + "3";
        }

        private void btnFour_Click(object sender, RoutedEventArgs e)//Adds the number 4 to the TextBox
        {
            TextBox.Text = TextBox.Text + "4";
        }

        private void btnFive_Click(object sender, RoutedEventArgs e)//Adds the number 5 to the TextBox
        {
            TextBox.Text = TextBox.Text + "5";
        }

        private void btnSix_Click(object sender, RoutedEventArgs e)//Adds the number 6 to the TextBox
        {
            TextBox.Text = TextBox.Text + "6";
        }

        private void btnSeven_Click(object sender, RoutedEventArgs e)//Adds the number 7 to the TextBox
        {
            TextBox.Text = TextBox.Text + "7";
        }

        private void btnEight_Click(object sender, RoutedEventArgs e)//Adds the number 8 to the TextBox
        {
            TextBox.Text = TextBox.Text + "8";
        }

        private void btnNine_Click(object sender, RoutedEventArgs e)//Adds the number 9 to the TextBox
        {
            TextBox.Text = TextBox.Text + "9";
        }

        private void btnZero_Click(object sender, RoutedEventArgs e)//Adds the number 0 to the TextBox
        {
            TextBox.Text = TextBox.Text + "0";
        }

        private void btnDot_Click(object sender, RoutedEventArgs e)//Adds a decimal point (technically a comma) to the TextBox but only if there isn't one already
        {
            if (!TextBox.Text.Contains(","))
            {
                TextBox.Text = TextBox.Text + ",";
            }
        }

        private void btnDiv_Click(object sender, RoutedEventArgs e)//Defines the operation as a division but only if the TextBox is not empty
        {
            if (TextBox.Text.Length != 0) {
                float.TryParse(TextBox.Text, out num1);
                operation = '/';
                btnClear_Click(sender, e);
            }
        }

        private void btnMulti_Click(object sender, RoutedEventArgs e)//Defines the operation as a multiplication but only if the TextBox is not empty
        {
            if (TextBox.Text.Length != 0)
            {
                float.TryParse(TextBox.Text, out num1);
                operation = '*';
                btnClear_Click(sender, e);
            }
        }

        private void btnMinus_Click(object sender, RoutedEventArgs e)//Defines the operation as a subtraction but only if the TextBox is not empty
        {
            if (TextBox.Text.Length != 0)
            {
                float.TryParse(TextBox.Text, out num1);
                operation = '-';
                btnClear_Click(sender, e);
            }
        }

        private void btnPlus_Click(object sender, RoutedEventArgs e)//Defines the operation as a addition but only if the TextBox is not empty
        {
            if (TextBox.Text.Length != 0)
            {
                float.TryParse(TextBox.Text, out num1);
                operation = '+';
                btnClear_Click(sender, e);
            }
        }

        private void btnErase_Click(object sender, RoutedEventArgs e)//Erases the last number typed on the TextBox but only if its not empty
        {
            if (TextBox.Text.Length != 0)
            {
                int index = TextBox.Text.Length;
                String st = TextBox.Text;
                TextBox.Text = st.Remove(index - 1);
            }
        }

        private void btnEquals_Click(object sender, RoutedEventArgs e)//Does a defined operation between num1 and num2
        {
            float.TryParse(TextBox.Text, out num2);
            switch (operation)
            {
                case '/'://Does a division between num1 and num2, then it returns the result to the TextBox
                    num1 = num1 / num2;
                    TextBox.Text = num1.ToString();
                    operation = '0';//The operation is set as "None"
                    break;
                case '*'://Does a multiplication between num1 and num2, then it returns the result to the TextBox
                    num1 = num1 * num2;
                    TextBox.Text = num1.ToString();
                    operation = '0';
                    break;
                case '-'://Does a subtraction between num1 and num2, then it returns the result to the TextBox
                    num1 = num1 - num2;
                    TextBox.Text = num1.ToString();
                    operation = '0';
                    break;
                case '+'://Does a addition between num1 and num2, then it returns the result to the TextBox
                    num1 = num1 + num2;
                    TextBox.Text = num1.ToString();
                    operation = '0';
                    break;
                case '0'://Does nothing, as the operation is set as "None"
                    break;
                default://This will never happen on this program as it is now. However is never a bad thing to have a failsafe
                    TextBox.Text = "Invalid Operation!";
                    operation = '0';
                    break;
            }
        }
    }
}
