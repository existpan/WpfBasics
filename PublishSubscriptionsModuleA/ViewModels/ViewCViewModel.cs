using Prism.Commands;
using Prism.Events;
using Prism.Services.Dialogs;
using PublishSubscriptionsModuleA.Event;
using System;
using System.Collections.Generic;
using System.Text;

namespace PublishSubscriptionsModuleA.ViewModels
{
    public class ViewCViewModel : IDialogAware
    {

        /// <summary>
        /// ok
        /// </summary>
        public DelegateCommand OkCommand { get; set; }

        /// <summary>
        /// cancel
        /// </summary>
        public DelegateCommand CancelCommand { get; set; }

        public string Title { get; set; }

        public event Action<IDialogResult> RequestClose;

        public ViewCViewModel()
        {
            this.OkCommand = new DelegateCommand(Ok);
            this.CancelCommand = new DelegateCommand(Cancel);
        }

        private void Cancel()
        {
            RequestClose?.Invoke(new DialogResult(ButtonResult.Cancel));
        }

        private void Ok()
        {
            OnDialogClosed();
        }

        public bool CanCloseDialog()
        {
            return true;
        }

        public void OnDialogClosed()
        {
            DialogParameters keys = new DialogParameters();
            keys.Add("value", "666");
            RequestClose?.Invoke(new DialogResult(ButtonResult.OK, keys));
        }

        public void OnDialogOpened(IDialogParameters parameters)
        {
            Title = parameters.GetValue<string>("Title");
        }
    }
}
