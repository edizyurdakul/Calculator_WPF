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
using System.Diagnostics;

namespace Calculator_LearningActivity_5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        long firstNum = 0;
        long secondNum = 0;
        string operatorSelection = "";
 
        public MainWindow()
        {
            InitializeComponent();
        }

        private void zero_Click(object sender, RoutedEventArgs e)
        {
            if (operatorSelection == "")
            {
                firstNum = (firstNum * 10);
                Display.Content = firstNum.ToString();
            }
            else
            {
                secondNum = (secondNum * 10);
                Display.Content = secondNum;
            }
        }

        private void one_Click(object sender, RoutedEventArgs e)
        {
            if (operatorSelection == "")
            {
                firstNum = (firstNum * 10) + 1;
                Display.Content = firstNum.ToString();
            } else
            {
                secondNum = (secondNum * 10) + 1;
                Display.Content = secondNum;
            }
        }

        private void two_Click(object sender, RoutedEventArgs e)
        {
            if (operatorSelection == "")
            {
                firstNum = (firstNum * 10) + 2;
                Display.Content = firstNum.ToString();
            }
            else
            {
                secondNum = (secondNum * 10) + 2;
                Display.Content = secondNum;
            }
        }

        private void three_Click(object sender, RoutedEventArgs e)
        {
            if (operatorSelection == "")
            {
                firstNum = (firstNum * 10) + 3;
                Display.Content = firstNum.ToString();
            }
            else
            {
                secondNum = (secondNum * 10) + 3;
                Display.Content = secondNum;
            }
        }

        private void four_Click(object sender, RoutedEventArgs e)
        {
            if (operatorSelection == "")
            {
                firstNum = (firstNum * 10) + 4;
                Display.Content = firstNum.ToString();
            }
            else
            {
                secondNum = (secondNum * 10) + 4;
                Display.Content = secondNum;
            }
        }

        private void five_Click(object sender, RoutedEventArgs e)
        {
            if (operatorSelection == "")
            {
                firstNum = (firstNum * 10) + 5;
                Display.Content = firstNum.ToString();
            }
            else
            {
                secondNum = (secondNum * 10) + 5;
                Display.Content = secondNum;
            }
        }

        private void six_Click(object sender, RoutedEventArgs e)
        {
            if (operatorSelection == "")
            {
                firstNum = (firstNum * 10) + 6;
                Display.Content = firstNum;
            }
            else
            {
                secondNum = (secondNum * 10) + 6;
                Display.Content = secondNum;
            }
        }

        private void seven_Click(object sender, RoutedEventArgs e)
        {
            if (operatorSelection == "")
            {
                firstNum = (firstNum * 10) + 7;
                Display.Content = firstNum;
            }
            else
            {
                secondNum = (secondNum * 10) + 7;
                Display.Content = secondNum;
            }
        }

        private void eight_Click(object sender, RoutedEventArgs e)
        {
            if (operatorSelection == "")
            {
                firstNum = (firstNum * 10) + 8;
                Display.Content = firstNum;
            }
            else
            {
                secondNum = (secondNum * 10) + 8;
                Display.Content = secondNum ;
            }
        }

        private void nine_Click(object sender, RoutedEventArgs e)
        {
            if (operatorSelection == "")
            {
                firstNum = (firstNum * 10) + 9;
                Display.Content = firstNum;
            }
            else
            {
                secondNum = (secondNum * 10) + 9;
                Display.Content = secondNum;
            }
        }

        private void plus_Click(object sender, RoutedEventArgs e)
        {
            operatorSelection = "+";
            Display.Content = "0";
        }

        private void minus_Click(object sender, RoutedEventArgs e)
        {
            operatorSelection = "-";
            Display.Content = "0";
        }

        private void times_Click(object sender, RoutedEventArgs e)
        {
            operatorSelection = "*";
            Display.Content = "0";
        }

        private void divide_Click(object sender, RoutedEventArgs e)
        {
            operatorSelection = "/";
            Display.Content = "0";
        }

        private void ce_Click(object sender, RoutedEventArgs e)
        {
            Trace.WriteLine(firstNum);
            Debug.WriteLine("Test");

            if (operatorSelection == "")
            {
               firstNum = 0;
            } else
            {
               secondNum = 0;
            }
            Display.Content = 0;
            Debug.WriteLine("Test");

        }

        private void c_Click(object sender, RoutedEventArgs e)
        {
            firstNum = 0;
            secondNum = 0;
            operatorSelection = "";
            Display.Content = firstNum;

        }

        private void equal_Click(object sender, RoutedEventArgs e)
        {
            switch(operatorSelection)
            {
                case "+":
                    Display.Content = firstNum + secondNum;
                    break;
                case "-":
                    Display.Content = firstNum - secondNum;
                    break;
                case "*":
                    Display.Content = firstNum * secondNum;
                    break;
                case "/":
                    Display.Content = firstNum / secondNum;
                    break;
                default: break;
            }
        }

        private void switchPlusMinus_Click(object sender, RoutedEventArgs e)
        {
            if (operatorSelection == "")
            {
                firstNum = firstNum * -1;
                Display.Content = firstNum;
            }
            else
            {
                secondNum = secondNum * -1;
                Display.Content = secondNum;
            }
        }
    }
}
