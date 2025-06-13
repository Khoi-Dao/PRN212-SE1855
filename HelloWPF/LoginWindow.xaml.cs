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
using System.Windows.Shapes;

namespace HelloWPF
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

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }


        

        private void btnLogin_Click_1(object sender, RoutedEventArgs e)
        {
            //make login buttin, if success  access MainWindow
            //else show error message
            if (txtUserName.Text == "Kira" && txtPassword.Password == "12345")
            {
                //access MainWindow
                MainWindow mw = new MainWindow();
                mw.Show();
                //close login window
                Close();
            }
            else
            {
                MessageBox.Show("Login failed");
            }
        }
    }
}
