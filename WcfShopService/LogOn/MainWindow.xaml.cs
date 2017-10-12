using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
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
using LogOn.ServiceReference1;

namespace LogOn
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        ServiceReference1.Service1Client channel = new Service1Client();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBlock_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            passAgainBlock.Visibility = passwordAgainBox.Visibility = emailBlock.Visibility = emailBox.Visibility = Visibility.Visible;
            regButton.Content = "Regist";
        }

        private void regButton_Click(object sender, RoutedEventArgs e)
        {
            if (regButton.Content.ToString() == "Enter")
            {
                User user = new User() { Login = loginBox.Text, Password = passwordBox.Text };
                if (channel.isEnter(user))
                {
                    
                    passAgainBlock.Visibility = passwordAgainBox.Visibility = emailBlock.Visibility = emailBox.Visibility = Visibility.Hidden;
                    regButton.Content = "Enter";
                    new Window1(channel).ShowDialog();
                }
                else
                {
                    MessageBox.Show("Not correct login or password");
                }
            }
            else
            {
                if (passwordBox.Text == passwordAgainBox.Text)
                {
                    //if (channel.Reg(new User() { Login = loginBox.Text, Password = passwordBox.Text, Email = emailBox.Text })) MessageBox.Show("Regist was success");
                    //else MessageBox.Show("Regist was failed");
                    MessageBox.Show(channel.Reg(new ServiceReference1.User() { Login = loginBox.Text, Password = passwordBox.Text, Email = emailBox.Text }));
                }
                else MessageBox.Show("Password dont match");
            }
        }
    }
}
