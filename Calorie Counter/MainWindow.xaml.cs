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
using System.Xml.Linq;

namespace Calorie_Counter
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int value = 0;
        int banana = 115;
        int apple = 80;
        int orange = 90;
        int peer = 120;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void orange_button(object sender, RoutedEventArgs e)
        {
            value = value + orange;
            txtbox1.Text = "" + value;
        }

        private void peer_button(object sender, RoutedEventArgs e)
        {
            value = value + peer;
            txtbox1.Text = "" + value;
        }

        private void apple_button(object sender, RoutedEventArgs e)
        {
            value = value + apple;
            txtbox1.Text = "" + value;
        }

        private void banana_button(object sender, RoutedEventArgs e)
        {
            value = value + banana;
            txtbox1.Text = "" + value;
        }

        private void btntextbox_Click(object sender, RoutedEventArgs e)
        {
            value = 0;
            txtbox1.Text = "" + value;
        }

        private void exitbtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
