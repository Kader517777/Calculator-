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

        double first, second = 0;
        char op;

        public MainWindow()
        {
            InitializeComponent();
        }


        

        private void Button_point(object sender, RoutedEventArgs e)
        {

        }

        private void Button_OPERATOR(object sender, RoutedEventArgs e)
        {
            maintext.Clear();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            
            try
            {
                Button button = sender as Button;
                maintext.Text = maintext.Text + button.Content;
                maintext.Text = maintext.Text.ToString();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

       

    }
}
