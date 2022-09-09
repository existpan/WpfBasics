using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace _06.WpfAppICommand
{
    public class MainViewModel
    {
        public MyCommand myCommand { get; set; }

        public MainViewModel()
        {
            myCommand = new MyCommand(show);
        }

        public void show()
        {
            MessageBox.Show("2333");
        }
    }
}
