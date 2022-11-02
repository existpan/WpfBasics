﻿using Prism.Ioc;
using Prism.Modularity;
using System;
using System.Collections.Generic;
using System.Text;
using WpfAppConversationServicesModuleA.ViewModels;
using WpfAppConversationServicesModuleA.Views;

namespace WpfAppConversationServicesModuleA
{
    public class ViewAProfile : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {

        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<ViewA, ViewAViewModel>();
        }

    }
}
