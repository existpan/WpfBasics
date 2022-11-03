using ConversationServicesModuleC.ViewModels;
using ConversationServicesModuleC.Views;
using Prism.Ioc;
using Prism.Modularity;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConversationServicesModuleC
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
