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

        /// <summary>
        /// 下一步
        /// </summary>
        public DelegateCommand NextCommand { get; set; }

        /// <summary>
        /// 上一步
        /// </summary>
        public DelegateCommand BackCommand { get; set; }

        private readonly IRegionManager regionManager;

        /// <summary>
        /// 导航日志
        /// </summary>
        private IRegionNavigationJournal navigationJournal;

        public MainViewModel(IRegionManager regionManager)
        {
            this.OpenCommand = new DelegateCommand<string>(Open);
            this.NextCommand = new DelegateCommand(Next);
            this.BackCommand = new DelegateCommand(Back);
            this.regionManager = regionManager;
        }

        private void Next()
        {
            if (navigationJournal.CanGoForward && navigationJournal != null)
            {
                navigationJournal.GoForward();
            }
        }

        private void Back()
        {
            if (navigationJournal.CanGoBack && navigationJournal != null)
            {
                navigationJournal.GoBack();
            }
        }

        private void Open(string obj)
        {
            //通过IRegionManager接口获取当前全局定义的可用区域。
            //往这个区域动态设置内容。
            //设置内容的方式是通过依赖注入。
            NavigationParameters keys = new NavigationParameters();
            keys.Add("Title", "Hello!");
            this.regionManager.Regions["ContentRegion"].RequestNavigate(obj, callBack =>
            {
                if ((bool)callBack.Result)
                {
                    navigationJournal = callBack.Context.NavigationService.Journal;
                }
            }, keys);
        }
    }
}
