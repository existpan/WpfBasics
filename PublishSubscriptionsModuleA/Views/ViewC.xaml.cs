using Prism.Events;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PublishSubscriptionsModuleA.Views
{
    /// <summary>
    /// ViewC.xaml 的交互逻辑
    /// </summary>
    public partial class ViewC : UserControl
    {
        private IEventAggregator eventAggregator;

        public ViewC(IEventAggregator eventAggregator)
        {
            InitializeComponent();
           this.eventAggregator = eventAggregator;
        }

    }
}
