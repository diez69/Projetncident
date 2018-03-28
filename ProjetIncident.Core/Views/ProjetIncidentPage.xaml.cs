using Xamarin.Forms;
using ProjetIncident.Core.ViewModel;
namespace ProjetIncident
{
    public partial class ProjetIncidentPage : ContentPage
    {

        public ProjetIncidentPage()
        {
            this.BindingContext = new Core.ViewModel.ProjetIncidentViewModel();
            ((Core.ViewModel.ProjetIncidentViewModel)BindingContext).MonTexte = "Welcome toi";
            InitializeComponent();
        }
        void Handle_Clicked(object sender, System.EventArgs e)
        {
            ((Core.ViewModel.ProjetIncidentViewModel)BindingContext).MonTexte = "Après clic sur le bouton";
        }

        void Handle_Ajout(object sender, System.EventArgs e)
        {
            ((ProjetIncidentViewModel)BindingContext).MaListe.Add("Nouvel élément");
        }

        void Handle_Sup(object sender, System.EventArgs e)
        {
            ((ProjetIncidentViewModel)BindingContext).MaListe.Remove(((ProjetIncidentViewModel)BindingContext).MaSelection);
        }
    }
}