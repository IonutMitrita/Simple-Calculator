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

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        string number1 = "";
        string number2 = "";
        string result = "";
        string operation = "";
        

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {

            if(operation == "")
            {
                number1 += 1;
                txtDisplay.Text = number1;
            }
            else
            {
                number2 += 1;
                txtDisplay.Text = number2;
            }
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 += 2;
                txtDisplay.Text = number1;
            }
            else
            {
                number2 += 2;
                txtDisplay.Text = number2;
            }
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "" )
            {
                number1 += 3;
                txtDisplay.Text = number1;
            }
            else
            {
                number2 += 3;
                txtDisplay.Text = number2;
            }
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "" )
            {
                number1 += 4;
                txtDisplay.Text = number1;
            }
            else
            {
                number2 += 4;
                txtDisplay.Text = number2;
            }
        }

        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "" )
            {
                number1 += 6;
                txtDisplay.Text = number1;
            }
            else
            {
                number2 += 6;
                txtDisplay.Text = number2;
            }
        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "" )
            {
                number1 += 5;
                txtDisplay.Text = number1;
            }
            else
            {
                number2 += 5;
                txtDisplay.Text = number2;
            }
        }

        private void btn7_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "" )
            {
                number1 += 7;
                txtDisplay.Text = number1;
            }
            else
            {
                number2 += 7;
                txtDisplay.Text = number2;
            }
        }

        private void btn8_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "" )
            {
                number1 += 8;
                txtDisplay.Text = number1;
            }
            else
            {
                number2 += 8;
                txtDisplay.Text = number2;
            }
        }

        private void btn9_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "" )
            {
                number1 += 9;
                txtDisplay.Text = number1;
            }
            else
            {
                number2 += 9;
                txtDisplay.Text = number2;
            }
        }

        private void btn0_Click(object sender, RoutedEventArgs e)
        {

            if (operation == "")
            {
                number1 += 0;
                txtDisplay.Text = number1;
            }
            else
            {
                number2 += 0;
                txtDisplay.Text = number2;
            }
        }

        private void btnPlus_Click(object sender, RoutedEventArgs e)
        {
            operation = "+";
            txtDisplay.Text = "0";
        }

        private void btnMinus_Click(object sender, RoutedEventArgs e)
        {
            operation = "-";
            txtDisplay.Text = "0";
        }

        private void btnTimes_Click(object sender, RoutedEventArgs e)
        {
            operation = "*";
            txtDisplay.Text = "0";
        }

        private void btnDivide_Click(object sender, RoutedEventArgs e)
        {
            operation = "/";
            txtDisplay.Text = "0";
        }
        //mai am de lucrat la "="
        private void btnEquals_Click(object sender, RoutedEventArgs e)
        {
            
            
            
            switch (operation)
            {
                case "+":
                    result = (Convert.ToDouble(number1) + Convert.ToDouble(number2)).ToString();
                    txtDisplay.Text = result;
                    number1 = result;
                    operation = "";                   
                    number2 = "";
                    break;
                case "-":
                    result = (Convert.ToDouble(number1) - Convert.ToDouble(number2)).ToString();
                    txtDisplay.Text = result;
                    number1 = result;
                    operation = "";                   
                    number2 = "";
                    break;
                case "/":
                    result = (Convert.ToDouble(number1) / Convert.ToDouble(number2)).ToString();      
                    txtDisplay.Text = result;
                    number1 = result;
                    operation = "";          
                    number2 = "";
                    break;
                case "*":
                    result = (Convert.ToDouble(number1) * Convert.ToDouble(number2)).ToString();
                    txtDisplay.Text = result;
                    number1 = result;
                    operation = "";                   
                    number2 = "";
                    break;
                

                    
            }
        }

         

         private void btnClearEntry_Click(object sender, RoutedEventArgs e)
         {
             if(operation == "")
             {
                number1 = "";

             }
             else
             {
                number2 = "";
             }
             txtDisplay.Text = "0";
         }

         private void btnClear_Click(object sender, RoutedEventArgs e)
         {
            number1 = "";
            number2 = "";
             operation = "";
             txtDisplay.Text = "0";
         }

         private void btnBackSpace_Click(object sender, RoutedEventArgs e)
         {
             if (operation == "")
             {
                if(number1.Length == 0)
                {
                    number1 = "";
                }
                else
                {
                number1 = number1.Substring(0, number1.Length-1);
                txtDisplay.Text = number1;

                }
             }
             else
             {
                if (number2.Length == 0)
                {
                    number2 = "";
                }
                else
                {
                    number2 = number2.Substring(0, number2.Length - 1);
                    txtDisplay.Text = number2;

                }
            }
         }

         private void btnPositiveNegative_Click(object sender, RoutedEventArgs e)
         {
             if (operation == "")
             {
                number1 = "-" + number1;
                txtDisplay.Text = number1;
             }
             else
             {
                number2 = "-" + number2;
                txtDisplay.Text = number2;
             }
         }

         private void btnDot_Click(object sender, RoutedEventArgs e)
         {
             if (operation == "" && !number1.Contains("."))
             {
                number1 = number1 + ".";
                txtDisplay.Text = number1;
             }
             else 
             {
                if (!number2.Contains("."))
                {
                number2 = number2 + ".";
                txtDisplay.Text = number2;

                }
             }
         }
    }
}
