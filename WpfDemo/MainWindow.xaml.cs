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

namespace WpfDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnHello_Click(object sender, RoutedEventArgs e)
        {
            //Create a message box that will show the text Hello World
            MessageBox.Show("Hello World");
        }

        private void listBoxApple_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("I am an apple list box");
        }

        private void listBoxApple_Selected(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("I am the apple messagebox");
        }

        private void TextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                MessageBox.Show(txtBox.Text);
                
            }
        }
    }
}
