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

namespace GlazedForms
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double x, y;
            x = Convert.ToDouble(TextBox1.Text);
            y = Convert.ToDouble(TextBox2.Text);
            double p = x * y;
            double price = 0;


            if (ComboBox1.SelectedIndex == 0) 
            {
                if (radioButton1.IsChecked == true)
                {
                    price = p * 0.25;
                }
                else if (radioButton2.IsChecked == true)
                {
                    price = p * 0.3;
                }
            }

            else if (ComboBox1.SelectedIndex == 1)
            {
                if (radioButton1.IsChecked == true)
                {
                    price = p * 0.05;
                }
                else if (radioButton2.IsChecked == true)
                {
                    price = p * 0.1;
                }
            }

            else if (ComboBox1.SelectedIndex == 2)
            {
                if (radioButton1.IsChecked == true)
                {
                    price = p * 0.15;
                }
                else if (radioButton2.IsChecked == true)
                {
                    price = p * 0.2;
                }
            }

            if (CheckBox1.IsChecked == true)
            {
                price = price + 35;
            }

            //radioButton2.IsChecked == true


            TextBox3.Text = price.ToString();

        }
    }
}
