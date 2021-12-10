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
using CabelApp.Model;

namespace CabelApp.Windows
{
    /// <summary>
    /// Логика взаимодействия для LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public static User user { get; set; }
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void SignIn(object sender, RoutedEventArgs e)
        {
            user = Context._con.User.Where(p => p.Phone == PhoneTB.Text && p.Password == PasswordTB.Text).FirstOrDefault();

            if (user != null)
            {
                CodeWindow codeWindow = new CodeWindow();
                codeWindow.Show();

                MessageWindow messageWindow = new MessageWindow();
                messageWindow.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Пользователь не найден!");
            }
        }
    }
}
