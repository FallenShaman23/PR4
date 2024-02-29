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

namespace Practic4
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Button1.Click += Button1_Click;
        }
        private void Button1_Click(object sender, RoutedEventArgs e)
        {

            double tot;
            double amount = double.Parse(Summa.Text);

            // RUB
            if (((ComboBoxItem)ComboBox1.SelectedItem).Content.ToString() == "RUB" &&
                ((ComboBoxItem)ComboBox2.SelectedItem).Content.ToString() == "USD")
            {
                tot = amount * 0.0110;
                konvert.Content = tot.ToString();

            }
            else if (((ComboBoxItem)ComboBox1.SelectedItem).Content.ToString() == "RUB" &&
                ((ComboBoxItem)ComboBox2.SelectedItem).Content.ToString() == "EUR")
            {
                tot = amount * 0.0101;
                konvert.Content = tot.ToString();
            }
            else if (((ComboBoxItem)ComboBox1.SelectedItem).Content.ToString() == "RUB" &&
                ((ComboBoxItem)ComboBox2.SelectedItem).Content.ToString() == "BYN")
            {
                tot = amount * 0.0354;
                konvert.Content = tot.ToString();
            }
            else if (((ComboBoxItem)ComboBox1.SelectedItem).Content.ToString() == "RUB" &&
                ((ComboBoxItem)ComboBox2.SelectedItem).Content.ToString() == "AED")
            {
                tot = amount * 0.0404;
                konvert.Content = tot.ToString();
            }
            else if (((ComboBoxItem)ComboBox1.SelectedItem).Content.ToString() == "RUB" &&
                ((ComboBoxItem)ComboBox2.SelectedItem).Content.ToString() == "PLN")
            {
                tot = amount * 0.0438;
                konvert.Content = tot.ToString();
            }
            else if (((ComboBoxItem)ComboBox1.SelectedItem).Content.ToString() == "RUB" &&
                ((ComboBoxItem)ComboBox2.SelectedItem).Content.ToString() == "JPY")
            {
                tot = amount * 1.6578;
                konvert.Content = tot.ToString();
            }
            else if (((ComboBoxItem)ComboBox1.SelectedItem).Content.ToString() == "RUB" &&
                ((ComboBoxItem)ComboBox2.SelectedItem).Content.ToString() == "TRY")
            {
                tot = amount * 0.3429;
                konvert.Content = tot.ToString();
            }


            // USD
            if (((ComboBoxItem)ComboBox1.SelectedItem).Content.ToString() == "USD" &&
                ((ComboBoxItem)ComboBox2.SelectedItem).Content.ToString() == "EUR")
            {
                tot = amount * 0.9238;
                konvert.Content = tot.ToString();

            }
            else if (((ComboBoxItem)ComboBox1.SelectedItem).Content.ToString() == "USD" &&
                ((ComboBoxItem)ComboBox2.SelectedItem).Content.ToString() == "BYN")
            {
                tot = amount * 3.2391;
                konvert.Content = tot.ToString();
            }
            else if (((ComboBoxItem)ComboBox1.SelectedItem).Content.ToString() == "USD" &&
                ((ComboBoxItem)ComboBox2.SelectedItem).Content.ToString() == "AED")
            {
                tot = amount * 3.6725;
                konvert.Content = tot.ToString();
            }
            else if (((ComboBoxItem)ComboBox1.SelectedItem).Content.ToString() == "USD" &&
                ((ComboBoxItem)ComboBox2.SelectedItem).Content.ToString() == "PLN")
            {
                tot = amount * 3.9803;
                konvert.Content = tot.ToString();
            }
            else if (((ComboBoxItem)ComboBox1.SelectedItem).Content.ToString() == "USD" &&
                ((ComboBoxItem)ComboBox2.SelectedItem).Content.ToString() == "JPY")
            {
                tot = amount * 150.5999;
                konvert.Content = tot.ToString();
            }
            else if (((ComboBoxItem)ComboBox1.SelectedItem).Content.ToString() == "USD" &&
                ((ComboBoxItem)ComboBox2.SelectedItem).Content.ToString() == "TRY")
            {
                tot = amount * 31.1481;
                konvert.Content = tot.ToString();
            }
            else if (((ComboBoxItem)ComboBox1.SelectedItem).Content.ToString() == "USD" &&
                ((ComboBoxItem)ComboBox2.SelectedItem).Content.ToString() == "RUB")
            {
                tot = amount * 90.8423;
                konvert.Content = tot.ToString();
            }

            // EUR
            if (((ComboBoxItem)ComboBox1.SelectedItem).Content.ToString() == "EUR" &&
                ((ComboBoxItem)ComboBox2.SelectedItem).Content.ToString() == "USD")
            {
                tot = amount * 1.0848;
                konvert.Content = tot.ToString();

            }
            else if (((ComboBoxItem)ComboBox1.SelectedItem).Content.ToString() == "EUR" &&
                ((ComboBoxItem)ComboBox2.SelectedItem).Content.ToString() == "BYN")
            {
                tot = amount * 3.4907;
                konvert.Content = tot.ToString();
            }
            else if (((ComboBoxItem)ComboBox1.SelectedItem).Content.ToString() == "EUR" &&
               ((ComboBoxItem)ComboBox2.SelectedItem).Content.ToString() == "AED")
            {
                tot = amount * 3.9839;
                konvert.Content = tot.ToString();
            }
            else if (((ComboBoxItem)ComboBox1.SelectedItem).Content.ToString() == "EUR" &&
               ((ComboBoxItem)ComboBox2.SelectedItem).Content.ToString() == "PLN")
            {
                tot = amount * 4.3178;
                konvert.Content = tot.ToString();
            }
            else if (((ComboBoxItem)ComboBox1.SelectedItem).Content.ToString() == "EUR" &&
               ((ComboBoxItem)ComboBox2.SelectedItem).Content.ToString() == "JPY")
            {
                tot = amount * 163.3690;
                konvert.Content = tot.ToString();
            }
            else if (((ComboBoxItem)ComboBox1.SelectedItem).Content.ToString() == "EUR" &&
               ((ComboBoxItem)ComboBox2.SelectedItem).Content.ToString() == "TRY")
            {
                tot = amount * 33.7891;
                konvert.Content = tot.ToString();
            }
            else if (((ComboBoxItem)ComboBox1.SelectedItem).Content.ToString() == "EUR" &&
                ((ComboBoxItem)ComboBox2.SelectedItem).Content.ToString() == "RUB")
            {
                tot = amount * 98.5447;
                konvert.Content = tot.ToString();
            }
            // BYN
            if (((ComboBoxItem)ComboBox1.SelectedItem).Content.ToString() == "BYN" &&
               ((ComboBoxItem)ComboBox2.SelectedItem).Content.ToString() == "USD")
            {
                tot = amount * 0.3108;
                konvert.Content = tot.ToString();

            }
            else if (((ComboBoxItem)ComboBox1.SelectedItem).Content.ToString() == "BYN" &&
                ((ComboBoxItem)ComboBox2.SelectedItem).Content.ToString() == "EUR")
            {
                tot = amount * 0.2865;
                konvert.Content = tot.ToString();
            }
            else if (((ComboBoxItem)ComboBox1.SelectedItem).Content.ToString() == "BYN" &&
                ((ComboBoxItem)ComboBox2.SelectedItem).Content.ToString() == "AED")
            {
                tot = amount * 1.1413;
                konvert.Content = tot.ToString();
            }
            else if (((ComboBoxItem)ComboBox1.SelectedItem).Content.ToString() == "BYN" &&
                ((ComboBoxItem)ComboBox2.SelectedItem).Content.ToString() == "PLN")
            {
                tot = amount * 1.2369;
                konvert.Content = tot.ToString();
            }
            else if (((ComboBoxItem)ComboBox1.SelectedItem).Content.ToString() == "BYN" &&
                ((ComboBoxItem)ComboBox2.SelectedItem).Content.ToString() == "JPY")
            {
                tot = amount * 46.8007;
                konvert.Content = tot.ToString();
            }
            else if (((ComboBoxItem)ComboBox1.SelectedItem).Content.ToString() == "BYN" &&
                ((ComboBoxItem)ComboBox2.SelectedItem).Content.ToString() == "TRY")
            {
                tot = amount * 9.6796;
                konvert.Content = tot.ToString();
            }
            else if (((ComboBoxItem)ComboBox1.SelectedItem).Content.ToString() == "BYN" &&
               ((ComboBoxItem)ComboBox2.SelectedItem).Content.ToString() == "RUB")
            {
                tot = amount * 28.2303;
                konvert.Content = tot.ToString();
            }
            // AED
            if (((ComboBoxItem)ComboBox1.SelectedItem).Content.ToString() == "AED" &&
               ((ComboBoxItem)ComboBox2.SelectedItem).Content.ToString() == "USD")
            {
                tot = amount * 0.2723;
                konvert.Content = tot.ToString();

            }
            else if (((ComboBoxItem)ComboBox1.SelectedItem).Content.ToString() == "AED" &&
                ((ComboBoxItem)ComboBox2.SelectedItem).Content.ToString() == "EUR")
            {
                tot = amount * 0.2510;
                konvert.Content = tot.ToString();
            }
            else if (((ComboBoxItem)ComboBox1.SelectedItem).Content.ToString() == "AED" &&
                ((ComboBoxItem)ComboBox2.SelectedItem).Content.ToString() == "BYN")
            {
                tot = amount * 0.8762;
                konvert.Content = tot.ToString();
            }
            else if (((ComboBoxItem)ComboBox1.SelectedItem).Content.ToString() == "AED" &&
                ((ComboBoxItem)ComboBox2.SelectedItem).Content.ToString() == "PLN")
            {
                tot = amount * 1.0838;
                konvert.Content = tot.ToString();
            }
            else if (((ComboBoxItem)ComboBox1.SelectedItem).Content.ToString() == "AED" &&
                ((ComboBoxItem)ComboBox2.SelectedItem).Content.ToString() == "JPY")
            {
                tot = amount * 41.0074;
                konvert.Content = tot.ToString();
            }
            else if (((ComboBoxItem)ComboBox1.SelectedItem).Content.ToString() == "AED" &&
                ((ComboBoxItem)ComboBox2.SelectedItem).Content.ToString() == "TRY")
            {
                tot = amount * 8.4814;
                konvert.Content = tot.ToString();
            }
            else if (((ComboBoxItem)ComboBox1.SelectedItem).Content.ToString() == "AED" &&
               ((ComboBoxItem)ComboBox2.SelectedItem).Content.ToString() == "RUB")
            {
                tot = amount * 24.7358;
                konvert.Content = tot.ToString();
            }
            // PLN
            if (((ComboBoxItem)ComboBox1.SelectedItem).Content.ToString() == "PLN" &&
              ((ComboBoxItem)ComboBox2.SelectedItem).Content.ToString() == "USD")
            {
                tot = amount * 0.2512;
                konvert.Content = tot.ToString();

            }
            else if (((ComboBoxItem)ComboBox1.SelectedItem).Content.ToString() == "PLN" &&
                ((ComboBoxItem)ComboBox2.SelectedItem).Content.ToString() == "EUR")
            {
                tot = amount * 0.2316;
                konvert.Content = tot.ToString();
            }
            else if (((ComboBoxItem)ComboBox1.SelectedItem).Content.ToString() == "PLN" &&
                ((ComboBoxItem)ComboBox2.SelectedItem).Content.ToString() == "BYN")
            {
                tot = amount * 0.8085;
                konvert.Content = tot.ToString();
            }
            else if (((ComboBoxItem)ComboBox1.SelectedItem).Content.ToString() == "PLN" &&
                ((ComboBoxItem)ComboBox2.SelectedItem).Content.ToString() == "AED")
            {
                tot = amount * 0.9227;
                konvert.Content = tot.ToString();
            }
            else if (((ComboBoxItem)ComboBox1.SelectedItem).Content.ToString() == "PLN" &&
                ((ComboBoxItem)ComboBox2.SelectedItem).Content.ToString() == "JPY")
            {
                tot = amount * 37.8364;
                konvert.Content = tot.ToString();
            }
            else if (((ComboBoxItem)ComboBox1.SelectedItem).Content.ToString() == "PLN" &&
                ((ComboBoxItem)ComboBox2.SelectedItem).Content.ToString() == "TRY")
            {
                tot = amount * 7.8256;
                konvert.Content = tot.ToString();
            }
            else if (((ComboBoxItem)ComboBox1.SelectedItem).Content.ToString() == "PLN" &&
               ((ComboBoxItem)ComboBox2.SelectedItem).Content.ToString() == "RUB")
            {
                tot = amount * 22.8230;
                konvert.Content = tot.ToString();
            }
            // JPY
            if (((ComboBoxItem)ComboBox1.SelectedItem).Content.ToString() == "JPY" &&
              ((ComboBoxItem)ComboBox2.SelectedItem).Content.ToString() == "USD")
            {
                tot = amount * 0.0066;
                konvert.Content = tot.ToString();

            }
            else if (((ComboBoxItem)ComboBox1.SelectedItem).Content.ToString() == "JPY" &&
                ((ComboBoxItem)ComboBox2.SelectedItem).Content.ToString() == "EUR")
            {
                tot = amount * 0.0061;
                konvert.Content = tot.ToString();
            }
            else if (((ComboBoxItem)ComboBox1.SelectedItem).Content.ToString() == "JPY" &&
                ((ComboBoxItem)ComboBox2.SelectedItem).Content.ToString() == "BYN")
            {
                tot = amount * 0.0214;
                konvert.Content = tot.ToString();
            }
            else if (((ComboBoxItem)ComboBox1.SelectedItem).Content.ToString() == "JPY" &&
                ((ComboBoxItem)ComboBox2.SelectedItem).Content.ToString() == "AED")
            {
                tot = amount * 0.0244;
                konvert.Content = tot.ToString();
            }
            else if (((ComboBoxItem)ComboBox1.SelectedItem).Content.ToString() == "JPY" &&
                ((ComboBoxItem)ComboBox2.SelectedItem).Content.ToString() == "PLN")
            {
                tot = amount * 0.0264;
                konvert.Content = tot.ToString();
            }
            else if (((ComboBoxItem)ComboBox1.SelectedItem).Content.ToString() == "JPY" &&
                ((ComboBoxItem)ComboBox2.SelectedItem).Content.ToString() == "TRY")
            {
                tot = amount * 0.2068;
                konvert.Content = tot.ToString();
            }
            else if (((ComboBoxItem)ComboBox1.SelectedItem).Content.ToString() == "JPY" &&
              ((ComboBoxItem)ComboBox2.SelectedItem).Content.ToString() == "RUB")
            {
                tot = amount * 0.6032;
                konvert.Content = tot.ToString();
            }
            // TRY
            if (((ComboBoxItem)ComboBox1.SelectedItem).Content.ToString() == "TRY" &&
              ((ComboBoxItem)ComboBox2.SelectedItem).Content.ToString() == "USD")
            {
                tot = amount * 0.0321;
                konvert.Content = tot.ToString();

            }
            else if (((ComboBoxItem)ComboBox1.SelectedItem).Content.ToString() == "TRY" &&
                ((ComboBoxItem)ComboBox2.SelectedItem).Content.ToString() == "EUR")
            {
                tot = amount * 0.0296;
                konvert.Content = tot.ToString();
            }
            else if (((ComboBoxItem)ComboBox1.SelectedItem).Content.ToString() == "TRY" &&
                ((ComboBoxItem)ComboBox2.SelectedItem).Content.ToString() == "BYN")
            {
                tot = amount * 0.1033;
                konvert.Content = tot.ToString();
            }
            else if (((ComboBoxItem)ComboBox1.SelectedItem).Content.ToString() == "TRY" &&
                ((ComboBoxItem)ComboBox2.SelectedItem).Content.ToString() == "AED")
            {
                tot = amount * 0.1179;
                konvert.Content = tot.ToString();
            }
            else if (((ComboBoxItem)ComboBox1.SelectedItem).Content.ToString() == "TRY" &&
                ((ComboBoxItem)ComboBox2.SelectedItem).Content.ToString() == "PLN")
            {
                tot = amount * 0.1278;
                konvert.Content = tot.ToString();
            }
            else if (((ComboBoxItem)ComboBox1.SelectedItem).Content.ToString() == "TRY" &&
                ((ComboBoxItem)ComboBox2.SelectedItem).Content.ToString() == "JPY")
            {
                tot = amount * 4.8350;
                konvert.Content = tot.ToString();
            }
            else if (((ComboBoxItem)ComboBox1.SelectedItem).Content.ToString() == "TRY" &&
              ((ComboBoxItem)ComboBox2.SelectedItem).Content.ToString() == "RUB")
            {
                tot = amount * 2.9165;
                konvert.Content = tot.ToString();
            }
        }

        private void Summa_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ComboBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}