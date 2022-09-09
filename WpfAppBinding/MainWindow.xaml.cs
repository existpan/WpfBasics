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

namespace WpfAppBinding
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = new Person()
            {
                Name="Zhangsan"
            };
        }

        //private void slider1_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        //{
        //    textbox1.Text = slider1.Value.ToString();
        //    textbox2.Text = slider1.Value.ToString();
        //    textbox3.Text = slider1.Value.ToString();
        //}

        //private void textbox1_TextChanged(object sender, TextChangedEventArgs e)
        //{
        //    slider1.Value = Convert.ToDouble(textbox1.Text);
        //}

    }
}
