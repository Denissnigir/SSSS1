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
    /// Логика взаимодействия для MessageWindow.xaml
    /// </summary>
    public partial class MessageWindow : Window
    {
        DispatcherTimer dispatcherTimer;
        TimeSpan counter;
        public static string code { get; set; }
        public MessageWindow()
        {
            InitializeComponent();
            CodeTB.Text = $"{GetSms()}";
            dispatcherTimer = new DispatcherTimer();
            dispatcherTimer.Interval = TimeSpan.FromSeconds(1);
            dispatcherTimer.Tick += DispatcherTimer_Tick;
            dispatcherTimer.Start();
        }

        private void DispatcherTimer_Tick(object sender, EventArgs e)
        {
            counter += TimeSpan.FromSeconds(1);
            if (counter >= TimeSpan.FromSeconds(10))
            {
                code = "Никогда не введёшь этот текст и не попадёшь на страницу";
                counter = new TimeSpan(0, 0, 0);
                dispatcherTimer.Stop();
                this.Close();
            }
        }

        private string GetSms()
        {
            Random random = new Random();
            code = $"F{random.Next(1000, 9999)}!d";
            string result = $"Text: \"Здарова, обыкновенич, вот твой код для авторизации: {code}\"";
            return result;
        }
    }
}
