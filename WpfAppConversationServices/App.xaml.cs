using Prism.DryIoc;
using Prism.Ioc;
using Prism.Modularity;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using WpfAppConversationServices.ViewModels;
using WpfAppConversationServices.Views;
using WpfAppConversationServicesModuleA;
using WpfAppConversationServicesModuleB;

namespace WpfAppConversationServices
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : PrismApplication
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindowView>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            //containerRegistry.RegisterForNavigation<MainWindowView, MainWindowViewModel>();
        }

        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
            moduleCatalog.AddModule<ViewAProfile>();
            moduleCatalog.AddModule<ViewBProfile>();
            base.ConfigureModuleCatalog(moduleCatalog);
        }
    }
}
