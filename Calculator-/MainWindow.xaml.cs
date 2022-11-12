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


namespace Calculator_
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


        int first, second;
        char op;

        private void Button_point(object sender, RoutedEventArgs e)
        {

        }

        private void Button_divided(object sender, RoutedEventArgs e)
        {
            first = Int32.Parse(maintext.Text);
            op = '/';
            
            
        }
        
        

        private void Button_into(object sender, RoutedEventArgs e)
        {

        }

        private void Button_minus(object sender, RoutedEventArgs e)
        {

        }

        private void Button_plus(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Equal(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            maintext.Text = button.Content.ToString();
            second = Int32.Parse(maintext.Text);
        }

        

    }
}
