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

        private void btnClose_Click(object sender, RoutedEventArgs e)//closes the program
        {
            this.Close();
        }

        private void writeLabelEven(string s)//writes on the label designated to the response of Even/Odd check
        {
            lbEven.Content = s;
        }
        private void writeLabelPrime(string s)//writes on the label designated to the response of Prime check
        {
            lbPrime.Content = s;
        }
        private void writeLabelPalind(string s)//writes on the label designated to the response of Palindrome check
        {
            lbPalind.Content = s;
        }
        private void btnClear_Click(object sender, RoutedEventArgs e)//Clears all the boxes and labels
        {
            TextBox.Text = "";
            writeLabelEven("");
            writeLabelPrime("");
            writeLabelPalind("");
        }
        private void btnCheck_Click(object sender, RoutedEventArgs e)//Does all checks on the number typed
        {
            writeLabelEven("");
            writeLabelPrime("");
            writeLabelPalind("");
            if (float.TryParse(TextBox.Text, out num))//if the entry is valid, therefore no letters, special characters
            {
                checkEvenOdd(num);//operation to check if the number is even or odd
                checkPrime(num);//operation to check if the number is prime
                checkPalindrome(num);//operation to check if the number is palindrome
            }
            else//if the entry is not valid
            {
                writeLabelEven("Invalid entry. Please enter a valid number.");
            }
        }
        private void checkEvenOdd(float n)
        {
            n = n % 2;
            if (n == 0)
            {
                writeLabelEven("The number is even.");
            }
            else
            {
                writeLabelEven("The number is odd.");
            }
        }
        private void checkPrime(float n)
        {
            bool prime = true;//boolean to show if the number is prime or not
            float m = n / 2;//number that defines the maximum iterations of the for
            for(int i = 2; i <= m; i++)
            {
                if (n % i == 0)
                {
                    writeLabelPrime("The number is not prime.");
                    prime = false;
                    break;
                }
            }
            if (prime == true)
            {
                writeLabelPrime("The number is prime.");
            }
        }
        private void checkPalindrome(float n)
        {
            int r, sum = 0, aux;
            aux = (int)n;
            //int.TryParse(n, out aux);
            while (aux > 0)
            {
                r = aux % 10;
                sum = (sum * 10) + r;
                aux = aux / 10;
            }
            if (n == sum)
            {
                writeLabelPalind("The number is a palindrome.");
            }
            else
            {
                writeLabelPalind("The number is not a palindrome.");
            }
        }
    }
}
