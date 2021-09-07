using System;
using System.Data;
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

namespace WpfApp9.Pages
{
    /// <summary>
    /// Логика взаимодействия для kalkulyator.xaml
    /// </summary>
    public partial class kalkulyator : Page
    {
        public kalkulyator()
        {
            InitializeComponent();
            foreach (UIElement el in GroupButton.Children)
            {
                if (el is Button)
                {
                    ((Button)el).Click += Button_Click;
                }
            }
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string str = (string)((Button)e.OriginalSource).Content;
            if (str == "C")
                Display.Text = "";
            else if (str == "=")
            {
                string value = new DataTable().Compute(Display.Text, null).ToString();
                Display.Text = value;
            }
            else
                Display.Text += str;

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_11(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_12(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_13(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_14(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_15(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_16(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_17(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_18(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_19(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_20(object sender, RoutedEventArgs e)
        {

        }

    }
}

