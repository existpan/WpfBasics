using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Text;

namespace WpfAppConversationServices.ViewModels
{
    public class MainWindowViewModel:BindableBase 
    {
        public DelegateCommand<string> OpenCommand{ get; set; }
        
        private IRegionManager regionManager;
        
        public MainWindowViewModel(IRegionManager regionManager)
        {
            this.OpenCommand = new DelegateCommand<string>(Open);
            this.regionManager = regionManager;
        }

        private void Open(string obj)
        {
            regionManager.Regions["region"].RequestNavigate(obj);
        }
    }
}
