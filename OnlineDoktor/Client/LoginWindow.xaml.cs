using Common.ServiceContracts;
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
using System.Windows.Shapes;

namespace Client
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            ChannelFactory<IAuthentication> channel = new ChannelFactory<IAuthentication>("AuthenticationService");
            IAuthentication proxy = channel.CreateChannel();

            if (proxy.Login(TbUsername.Text, TbPassword.Password, CheckRBS()))
            {
                MainWindow window = new MainWindow(CheckRBS());
                window.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("asdas", "asdsa", MessageBoxButton.OK);
            }
        }

        private string CheckRBS()
        {
            bool pt = PatientRB.IsChecked == true && AdminRB.IsChecked == false;
            bool ad = PatientRB.IsChecked == false && AdminRB.IsChecked == true;
            if(pt == true && ad == false)
            {
                return "Patient";
            }
            if(pt == false && ad == true)
            {
                return "Admin";
            }
            return "";
        }
    }
}
