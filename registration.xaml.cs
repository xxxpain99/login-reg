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

namespace WpfApp9.Pages
{
    /// <summary>
    /// Логика взаимодействия для registration.xaml
    /// </summary>
    public partial class registration : Page
    {
        public registration()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ///возвращаемся назад
            //NavigationService.Navigate(new login());
            if(NavigationService.CanGoBack)
            {
                NavigationService.GoBack();
            }

            NavigationService.Navigate(Class1.PageLogin);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ///регистрируемся
           
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (textBox.Text.Length > 0)
            {
                if (password.Text.Length > 0)
                {
                    if  (password1.Text.Length > 0)
                    { 

                    }
                    else MessageBox.Show("Повторите пароль");

                }
                else MessageBox.Show("Укажите пароль");

            }
            else MessageBox.Show("Укажите логин");
            
        } 
         
    }
}
