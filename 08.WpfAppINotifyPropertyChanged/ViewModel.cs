using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace _08.WpfAppINotifyPropertyChanged
{
    public class ViewModel : ViewModelBase
    {
        public ShowCommand ShowCommand { get; set; }

        private string name;

        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                OnPropertyChanged();
            }
        }

        private string title;

        public string Title
        {
            get { return title; }
            set
            {
                title = value;
                OnPropertyChanged();
            }
        }

        public ViewModel()
        {
            ShowCommand = new ShowCommand(show);
        }

        public void show()
        {
            Name = "Button";
            Title = "Label";
            MessageBox.Show("Click ");
        }
    }
}
