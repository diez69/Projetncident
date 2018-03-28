using System;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace ProjetIncident.Core.ViewModel
{
    public class HomeViewModel : BaseViewModel
    {
        public HomeViewModel()
        {
            ListIncident = new ObservableCollection<string>();
            NameIncident = "";
        }

        public string Title
        {
            get => (string)GetProperty();
            set { SetProperty(value); }
        }

        public string MaSelection
        {
            get => (string)GetProperty();
            set { SetProperty(value); }
        }

        public string NameIncident
        {
            get => (string)GetProperty();
            set { SetProperty(value); }
        }

        public ObservableCollection<string> ListIncident
        {
            get => (ObservableCollection<string>)GetProperty();
            set { SetProperty(value); }
        }
    }
}

