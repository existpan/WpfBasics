using Prism.Commands;
using Prism.Mvvm;
using Prism.Services.Dialogs;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConversationServicesModuleC.ViewModels
{
    public class ViewCViewModel : IDialogAware
    {
        public DelegateCommand OkCommand { get; set; }

        public DelegateCommand CancelCommand { get; set; }

        public string Title { get; set; }

        public ViewCViewModel()
        {
            OkCommand = new DelegateCommand(Ok);
            CancelCommand = new DelegateCommand(Cancel);
        }

        public event Action<IDialogResult> RequestClose;

        private void Cancel()
        {
            RequestClose?.Invoke(new DialogResult(ButtonResult.Cancel));
        }

        private void Ok()
        {
            DialogParameters keys = new DialogParameters();
            keys.Add("value", "666");
            RequestClose?.Invoke(new DialogResult(ButtonResult.OK, keys));
        }

        public bool CanCloseDialog()
        {
            return true;
        }

        public void OnDialogClosed()
        {

        }

        public void OnDialogOpened(IDialogParameters parameters)
        {
            Title = parameters.GetValue<string>("Title");
        }
    }
}