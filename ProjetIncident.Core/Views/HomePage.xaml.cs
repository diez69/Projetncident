using Xamarin.Forms;
using ProjetIncident.Core.ViewModel;
namespace ProjetIncident
{
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            this.BindingContext = new Core.ViewModel.HomeViewModel();
            ((Core.ViewModel.HomeViewModel)BindingContext).Title = "Bienvenue sur ProjetIncident !";
            InitializeComponent();
        }

        void Handle_Declare(object sender, System.EventArgs e)
        {
            if (((HomeViewModel)BindingContext).NameIncident != "") {
                ((HomeViewModel)BindingContext).ListIncident.Add(
                ((HomeViewModel)BindingContext).NameIncident);
                ((HomeViewModel)BindingContext).NameIncident = "";
            } else {
                DisplayAlert("Attention", "Veuilliez remplir le champ pour déclarer l'incident", "OK");
            }

        }

        void Handle_Sup(object sender, System.EventArgs e)
        {
            ((HomeViewModel)BindingContext).ListIncident.Remove(((HomeViewModel)BindingContext).MaSelection);
        }

        void Handle_Photo(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new ProjetIncidentPage());
        }
    }
}
