using _12.WpfAppPrismDemo.Views;
using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.WpfAppPrismDemo.ViewModels
{
    public class MainViewModel : BindableBase
    {
        public DelegateCommand<string> OpenCommand { get; set; }

        public MainViewModel()
        {
            this.OpenCommand = new DelegateCommand<string>(Open);
        }

        private object body;

        public object Body
        {
            get { return body; }
            set
            {
                body = value;
                RaisePropertyChanged();
            }
        }

        private void Open(string obj)
        {
            switch (obj)
            {
                case "A":
                    Body = new UserControlA();
                    break;
                case "B":
                    Body = new UserControlB();
                    break;
                case "C":
                    Body = new UserControlC();
                    break;
                default:
                    break;
            }
        }
    }
}
