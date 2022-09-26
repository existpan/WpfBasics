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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _11.WpfAppAnimationBasics
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            DoubleAnimation doubleAnimation = new DoubleAnimation();
            doubleAnimation.From = this.button.Width;
            doubleAnimation.To = this.button.Width + 30;
            doubleAnimation.Duration =  TimeSpan.FromSeconds(0.8);
            doubleAnimation.AutoReverse = false;
            doubleAnimation.RepeatBehavior = new RepeatBehavior(2);

            doubleAnimation.Completed += DoubleAnimation_Completed;

            button.BeginAnimation(Button.WidthProperty, doubleAnimation);

        }

        private void DoubleAnimation_Completed(object sender, EventArgs e)
        {
            button.Content = "Animation Is Completed";
        }
    }
}
