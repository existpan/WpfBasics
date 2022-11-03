using Prism.Ioc;
using Prism.Modularity;
using PublishSubscriptionsModuleA.ViewModels;
using PublishSubscriptionsModuleA.Views;
using System;
using System.Collections.Generic;
using System.Text;

namespace PublishSubscriptionsModuleA
{
    public class ViewCProfile : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {

        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<ViewC, ViewCViewModel>();
        }
    }
}
