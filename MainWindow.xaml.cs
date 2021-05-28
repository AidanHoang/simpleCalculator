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

namespace WpfApp5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        String textString = "";
        int textLength = 0;
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(calcInput.Text))
            {
                calcInput.Text = "";
            }
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(calcInput.Text))
            {
                textLength = calcInput.Text.Length - 1;

                for (int count = 0; count < textLength; count++)
                {
                    textString += calcInput.Text[count];
                }

                calcInput.Text = textString;
                textString = "";
            }
        }

        private void multiply_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(calcInput.Text))
            {
                calcInput.Text += " * ";
            }
        }

        private void divide_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(calcInput.Text))
            {
                calcInput.Text += " ÷ ";
            }
        }
    }
}
