
using ModuleA;
using Prism.DryIoc;
using Prism.Ioc;
using System.Windows;
using WpfAppPrismDemo.Views;

namespace WpfAppPrismDemo
{
    /// <summary>
    /// App.xaml 的交互逻辑
    /// </summary>
    public partial class App:PrismApplication
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<MainView>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {

        }
    }
}
