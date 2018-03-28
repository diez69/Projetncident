using System;
using System.Collections.ObjectModel;

namespace ProjetIncident.Core.ViewModel
{
    public class ProjetIncidentViewModel : BaseViewModel
    {
        public ProjetIncidentViewModel()
        {
            MaListe = new ObservableCollection<string>();
            MaListe.Add("Elément1");
        }

        public string MonTexte {
            get => (string)GetProperty();
            set { SetProperty(value);}
        }

        public string MaSelection
        {
            get => (string)GetProperty();
            set { SetProperty(value); }
        }

        public ObservableCollection<string> MaListe {
            get => (ObservableCollection<string>)GetProperty();
            set { SetProperty(value); }
        }
    }
}
