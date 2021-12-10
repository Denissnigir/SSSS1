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
using System.Windows.Threading;

namespace CabelApp.Windows
{
    /// <summary>
    /// Логика взаимодействия для CodeWindow.xaml
    /// </summary>
    public partial class CodeWindow : Window
    {

        public CodeWindow()
        {
            InitializeComponent();
        }


        private void UpdateCode(object sender, RoutedEventArgs e)
        {

            MessageWindow messageWindow = new MessageWindow();
            messageWindow.Show();
        }

        private void ValidateCode(object sender, RoutedEventArgs e)
        {
            if(AnswerTB.Text == MessageWindow.code)
            {
                MessageBox.Show($"Вы успешно авторизовались под ролью {LoginWindow.user.Role.Name}");
                LoginWindow loginWindow = new LoginWindow();
                loginWindow.Show();
                LoginWindow.user = null;
                this.Close();
            }
        }
    }
}
