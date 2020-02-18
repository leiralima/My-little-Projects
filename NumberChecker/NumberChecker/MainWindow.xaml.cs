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
        private int num = 0;//number to be checked
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
        private void writeLabelFatorization(string s)//writes on the label designated to the response of Dividend check
        {
            lbFatorization.Content = s;
            //lbFatorization.Content = lbFatorization.Content + s;
        }
        private void btnClear_Click(object sender, RoutedEventArgs e)//Clears all the boxes and labels
        {
            TextBox.Text = "";
            writeLabelEven("");
            writeLabelPrime("");
            writeLabelPalind("");
            writeLabelFatorization("");
        }
        private void btnCheck_Click(object sender, RoutedEventArgs e)//Does all checks on the number typed
        {
            writeLabelEven("");
            writeLabelPrime("");
            writeLabelPalind("");
            writeLabelFatorization("");
            if (int.TryParse(TextBox.Text, out num))//if the entry is valid, therefore no letters, special characters
            {
                checkEvenOdd(num);//operation to check if the number is even or odd
                checkPrime(num);//operation to check if the number is prime
                checkPalindrome(num);//operation to check if the number is palindrome
                checkFatorization(num);//operation to show the dividends of a number
            }
            else//if the entry is not valid
            {
                writeLabelEven("Invalid entry. Please enter a valid number.");
            }
        }
        private void checkEvenOdd(int n)//Check that verifies if given number is odd or even
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
        private void checkPrime(int n)//Check that verifies if given number is prime
        {
            bool prime = true;//boolean to show if the number is prime or not
            int m = n / 2;//number that defines the maximum iterations of the for
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
        private void checkPalindrome(int n)//Check that verifies if given number is a palindrome
        {
            int r, sum = 0, aux;
            aux = n;
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
        private void checkFatorization(int n)//Check gives the prime factors of a given number
        {
            int aux1, aux2 = n;
            String st="";
            for (aux1 = 2; aux2 > 1; aux1++)
            {
                int x = 0;
                if (aux2 % aux1 == 0)
                {
                    aux2 /= aux1;
                    x++;
                    st = st + aux1.ToString() + " is a prime factor " + x.ToString() + " times!\n";
                }
            }
            writeLabelFatorization(st);
        }
    }
}
