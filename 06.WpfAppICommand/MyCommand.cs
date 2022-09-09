using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace _06.WpfAppICommand
{
    public class MyCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public Action show { get; set; }

        public MyCommand(Action action)
        {
            show = action;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            show();
        }
    }
}
