using Prism.DryIoc;
using Prism.Ioc;
using Prism.Modularity;
using PublishSubscriptionsModuleA;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using WpfAppPublishSubscriptions.ViewModels;

namespace WpfAppPublishSubscriptions
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : PrismApplication
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<MainWindow, MainWindowViewModel>();
        }

        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
            moduleCatalog.AddModule<ViewCProfile>();
            base.ConfigureModuleCatalog(moduleCatalog);
        }
    }
}
