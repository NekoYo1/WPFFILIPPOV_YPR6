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

namespace WPFFILIPPOV_YPR6
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string User = Username.Text;
            string Password1 = Password.Text;
            if (User == "" && Password1 == "")
                MessageBox.Show($"{Environment.NewLine}Enter username{Environment.NewLine}Enter password");
            else if (User == "")
                MessageBox.Show("Enter username");
            else if (Password1 == "")
                MessageBox.Show("Enter password");
            else if (User == "Admin" && Password1 == "Admin")
                Bruh1.Navigate(new Uri("Page1.xaml", UriKind.Relative));
            else if (User != "Admin" && User != "User")
                MessageBox.Show("User is not found");
            else if (Password1 != "Admin" && Password1 != "User")
                MessageBox.Show("Password incorrect");
            else if (User == "User" && Password1 == "User")
                Bruh1.Navigate(new Uri("Page2.xaml", UriKind.Relative));



            Label2.Content = "Password";
            Password.Text = "";

            if (RM.IsChecked == false)
            {
                Label1.Content = "Username";
                Username.Text = "";
            }

            else if (RM.IsChecked == true)
            {
                Label1.Content = "";
                Username.Text = User;
            }
        }

        private void Username_TextChanged(object sender, TextChangedEventArgs e)
        {
            Label1.Content = "";
            if (Username.Text == "")
                Label1.Content = "Username";
        }

        private void Password_TextChanged(object sender, TextChangedEventArgs e)
        {
            Label2.Content = "";
            if (Password.Text == "")
                Label2.Content = "Password";
        }
    }
}
