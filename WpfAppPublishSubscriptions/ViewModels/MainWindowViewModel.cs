using Prism.Commands;
using Prism.Mvvm;
using Prism.Services.Dialogs;
using System;
using System.Collections.Generic;
using System.Text;

namespace WpfAppPublishSubscriptions.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        public DelegateCommand<string> OpenCommand{ get; set; }

        private IDialogService dialogService;

        public MainWindowViewModel(IDialogService dialogService)
        {
            this.OpenCommand = new DelegateCommand<string>(Open);
            this.dialogService = dialogService;
        }

        private void Open(string obj)
        {
            DialogParameters keys = new DialogParameters();
            keys.Add("Title","测试弹窗");
            dialogService.ShowDialog(obj, keys, callback =>
             {
                 if (callback.Result==ButtonResult.OK)
                 {
                     string result = callback.Parameters.GetValue<string>("value");
                 }
             });
        }
    }
}