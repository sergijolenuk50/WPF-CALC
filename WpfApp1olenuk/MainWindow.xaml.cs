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

namespace WpfApp1olenuk
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

        float value = 0;
        float value1;
        float res = 0;
        string text;
        string sumbol;


        private void resBTN_Click(object sender, RoutedEventArgs e)
        {
            if (sumbol == "+")
            {
                text = (string)resalt.Content;
                value1 = float.Parse(text);
                res = value + value1;
                resalt.Content = res;
                value = res;
                sumbol = "";
            }
            else if (sumbol == "-")
            {
                text = (string)resalt.Content;
                value1 = float.Parse(text);
                res = value - value1;
                resalt.Content = res;
                value = res;
                sumbol = "";

            }
            else if (sumbol == "*")
            {
                text = (string)resalt.Content;
                value1 = float.Parse(text);
                res = value * value1;
                resalt.Content = res;
                value = res;
                sumbol = "";

            }
            else if (sumbol == "/")
            {
                text = (string)resalt.Content;
                value1 = float.Parse(text);
                res = value / value1;
                resalt.Content = res;
                value = res;
                sumbol = "";

            }
           
            //else if (sumbol == "")
            //{
            //    text = (string)resalt.Content;
            //    value = float.Parse(text);
            //    resalt.Content = value;
            //    sumbol = "0";

            //}

        }

        private void pointBTN_Click(object sender, RoutedEventArgs e)
        {
            resalt.Content += ",";
        }

        private void nullBTN_Click(object sender, RoutedEventArgs e)
        {
            resalt.Content += "0";
        }

        private void multiplicationBTN_Click(object sender, RoutedEventArgs e)
        {
            if (value > 0)
            {
                //text = (string)resalt.Content;
                //value1 = float.Parse(text);
                //res = value * value1;
                //resalt.Content = res;
                //value = res;
                if (sumbol == "+")
                {
                    text = (string)resalt.Content;
                    value1 = float.Parse(text);
                    res = value + value1;
                    resalt.Content = res;
                    value = res;
                }
                else if (sumbol == "-")
                {
                    text = (string)resalt.Content;
                    value1 = float.Parse(text);
                    res = value - value1;
                    resalt.Content = res;
                    value = res;
                }
                else if (sumbol == "*")
                {
                    text = (string)resalt.Content;
                    value1 = float.Parse(text);
                    res = value * value1;
                    resalt.Content = res;
                    value = res;
                }
                else if (sumbol == "/")
                {
                    text = (string)resalt.Content;
                    value1 = float.Parse(text);
                    res = value / value1;
                    resalt.Content = res;
                    value = res;
                }
                

            }
            else
            {
                text = (string)resalt.Content;
                value = float.Parse(text);
                resalt.Content = "";

            }
            sumbol = "*";
            //resalt.Content += "*";

        }

        private void oneBTN_Click(object sender, RoutedEventArgs e)
        {
            if (res > 0)
            {
                resalt.Content = "";
                res = 0;
            }
            resalt.Content +="1";
        }

        private void twoBTN_Click(object sender, RoutedEventArgs e)
        {
            if (res > 0)
            {
                resalt.Content = "";
                res = 0;
            }
            resalt.Content += "2";
        }

        private void freeBTN_Click(object sender, RoutedEventArgs e)
        {
            if (res > 0)
            {
                resalt.Content = "";
                res = 0;
            }
            resalt.Content += "3";
        }

        private void fourBTN_Click(object sender, RoutedEventArgs e)
        {
            if (res > 0)
            {
                resalt.Content = "";
                res = 0;
            }
            resalt.Content += "4";
        }

        private void fiveBTN_Click(object sender, RoutedEventArgs e)
        {
            if (res > 0)
            {
                resalt.Content = "";
                res = 0;
            }
            resalt.Content += "5";
        }

        private void sixBTN_Click(object sender, RoutedEventArgs e)
        {
            if (res > 0)
            {
                resalt.Content = "";
                res = 0;
            }
            resalt.Content += "6";

        }

        private void substractionBTN_Click(object sender, RoutedEventArgs e)
        {
            if (value > 0)
            {
                //text = (string)resalt.Content;
                //value1 = float.Parse(text);
                //res = value - value1;
                //resalt.Content = res;
                //value = res;
                if (sumbol == "+")
                {
                    text = (string)resalt.Content;
                    value1 = float.Parse(text);
                    res = value + value1;
                    resalt.Content = res;
                    value = res;
                }
                else if (sumbol == "-")
                {
                    text = (string)resalt.Content;
                    value1 = float.Parse(text);
                    res = value - value1;
                    resalt.Content = res;
                    value = res;
                }
                else if (sumbol == "*")
                {
                    text = (string)resalt.Content;
                    value1 = float.Parse(text);
                    res = value * value1;
                    resalt.Content = res;
                    value = res;
                }
                else if (sumbol == "/")
                {
                    text = (string)resalt.Content;
                    value1 = float.Parse(text);
                    res = value / value1;
                    resalt.Content = res;
                    value = res;
                }
               

            }
            else
            {
                text = (string)resalt.Content;
                value = float.Parse(text);
                resalt.Content = "";

            }
            sumbol = "-";

            // resalt.Content += "-";
        }

        private void idittionBTN_Click(object sender, RoutedEventArgs e)
        {
            if (value > 0)
            {
                if (sumbol == "+") {
                text = (string)resalt.Content;
                value1 = float.Parse(text);
                res = value + value1;
                resalt.Content = res;
                value = res;
                }
                else if(sumbol == "-")
                {
                    text = (string)resalt.Content;
                    value1 = float.Parse(text);
                    res = value - value1;
                    resalt.Content = res;
                    value = res;
                }
                else if (sumbol == "*")
                {
                    text = (string)resalt.Content;
                    value1 = float.Parse(text);
                    res = value * value1;
                    resalt.Content = res;
                    value = res;
                }
                else if (sumbol == "/")
                {
                    text = (string)resalt.Content;
                    value1 = float.Parse(text);
                    res = value / value1;
                    resalt.Content = res;
                    value = res;
                }
               

            }
            else
            {
                text = (string)resalt.Content;
                value = float.Parse(text);
                resalt.Content = "";

            }
            sumbol = "+";

            //  resalt.Content += "+";
        }

        private void naneBTN_Click(object sender, RoutedEventArgs e)
        {
            if (res > 0)
            {
                resalt.Content = "";
                res = 0;
            }
            resalt.Content += "9";
        }

        private void eightBTN_Click(object sender, RoutedEventArgs e)
        {
            if (res > 0)
            {
                resalt.Content = "";
                res = 0;
            }
            resalt.Content += "8";
        }

        private void sevenBTN_Click(object sender, RoutedEventArgs e)
        {
            if (res > 0)
            {
                resalt.Content = "";
                res = 0;
            }
            resalt.Content += "7";
        }

        private void devisionBTN_Click(object sender, RoutedEventArgs e)
        {
            if (value > 0)
            {
                //text = (string)resalt.Content;
                //value1 = float.Parse(text);
                //res = value / value1;
                //resalt.Content = res;
                //value = res;
                if (sumbol == "+")
                {
                    text = (string)resalt.Content;
                    value1 = float.Parse(text);
                    res = value + value1;
                    resalt.Content = res;
                    value = res;
                }
                else if (sumbol == "-")
                {
                    text = (string)resalt.Content;
                    value1 = float.Parse(text);
                    res = value - value1;
                    resalt.Content = res;
                    value = res;
                }
                else if (sumbol == "*")
                {
                    text = (string)resalt.Content;
                    value1 = float.Parse(text);
                    res = value * value1;
                    resalt.Content = res;
                    value = res;
                }
                else if (sumbol == "/")
                {
                    text = (string)resalt.Content;
                    value1 = float.Parse(text);
                    res = value / value1;
                    resalt.Content = res;
                    value = res;
                }
               
            }
            else
            {
                text = (string)resalt.Content;
                value = float.Parse(text);
                resalt.Content = "";

            }
            sumbol = "/";

            // resalt.Content += "/";
        }

        private void interestBTN_Click(object sender, RoutedEventArgs e)
        {
            if (value > 0)
            {
                //text = (string)resalt.Content;
                //value1 = float.Parse(text);
                //res = value / value1;
                //resalt.Content = res;
                //value = res;
                if (sumbol == "+")
                {
                    text = (string)resalt.Content;
                    value1 = float.Parse(text);
                    res =value + ((value * value1) / 100);
                    resalt.Content = res;
                    value = res;
                    sumbol = "";
                }
                else if (sumbol == "-")
                {
                    text = (string)resalt.Content;
                    value1 = float.Parse(text);
                    res = value - ((value * value1) / 100);
                    resalt.Content = res;
                    value = res;
                    sumbol = "";
                }
                
                //else if (sumbol == "%")
                //{
                //    text = (string)resalt.Content;
                //    value1 = float.Parse(text);
                //    res = ((value * value1)/100);
                //    resalt.Content = res;
                //    value = res;
                //}
            }
            else
            {
                text = (string)resalt.Content;
                value = float.Parse(text);
                resalt.Content = "";

            }
           // sumbol = "%";

           // resalt.Content += "%";
        }

        private void negatibBTN_Click(object sender, RoutedEventArgs e)
        {
            resalt.Content += "+/-";
        }

        private void ac_Click(object sender, RoutedEventArgs e)
        {
            value = 0;
            value1 = 0; ;
            res = 0;
            sumbol ="";
            resalt.Content = "";
            text =(string)resalt.Content;

        }
    }
}
