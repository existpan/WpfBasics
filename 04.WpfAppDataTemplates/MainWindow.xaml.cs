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

namespace _04.WpfAppDataTemplates
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //List<int> temp = new List<int>();
            //for (int i = 0; i < 10; i++)
            //{
            //    temp.Add(i);
            //}
            //list.ItemsSource = temp;

            List<Color> colors = new List<Color>();

            colors.Add(new Color() { Name = "Lightsalmon", Code = "#FFA07A" });
            colors.Add(new Color() { Name = "三文鱼", Code = "#FA8072" });
            colors.Add(new Color() { Name = "黑鲑", Code = "#E9967A" });
            colors.Add(new Color() { Name = "轻珊瑚", Code = "#F08080" });
            colors.Add(new Color() { Name = "印第安人", Code = "#CD5C5C" });

            grid.ItemsSource = colors;
        }
        public class Color
        {
            public string Name { get; set; }
            public string Code { get; set; }
        }
    }
}
