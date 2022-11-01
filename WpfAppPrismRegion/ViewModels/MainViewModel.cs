using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Text;
using WpfAppPrismRegion.Views;

namespace WpfAppPrismRegion.ViewModels
{
    public class MainViewModel : BindableBase
    {
        public DelegateCommand<string> OpenCommand { get; set; }

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

        public MainViewModel()
        {
            this.OpenCommand = new DelegateCommand<string>(Open);
        }

        private void Open(string obj)
        {
            switch (obj)
            {
                case "ViewA":
                    Body = new ViewA();
                    break;
                case "ViewB":
                    Body = new ViewB();
                    break;
                case "ViewC":
                    Body = new ViewC();
                    break;
                default:
                    break;
            }
        }
    }
}
