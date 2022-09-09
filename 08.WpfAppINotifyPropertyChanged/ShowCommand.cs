using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace _08.WpfAppINotifyPropertyChanged
{
    public class ShowCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public Action show { get; set; }
        public ShowCommand(Action show) => this.show = show;

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
