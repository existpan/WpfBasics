using _12.WpfAppPrismDemo.Views;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
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

        private readonly IRegionManager regionManager;

        public MainViewModel(IRegionManager regionManager)
        {
            this.OpenCommand = new DelegateCommand<string>(Open);
            this.regionManager = regionManager;
        }

        private void Open(string obj)
        {
            this.regionManager.Regions["ContentRegion"].RequestNavigate(obj);
        }
    }
}
