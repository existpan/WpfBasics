using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace _09.WpfAppMvvmLight
{
    public class MainViewModel : ViewModelBase
    {
        public MainViewModel()
        {
            title = "MvvmLight";
            ShowCommand = new RelayCommand<string>(show);
        }

        public RelayCommand<string> ShowCommand { get; set; }

        private string name;
        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                RaisePropertyChanged();
            }
        }

        private string title;
        public string Title
        {
            get { return title; }
            set
            {
                title = value;
                RaisePropertyChanged();
            }
        }

        public void show(string name)
        {
            Messenger.Default.Send<string>(name, "Token1");
        }
    }
}
