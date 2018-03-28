﻿using System.Threading.Tasks;
using Xamarin.Forms;
using ProjetIncident.Core.ViewModel;
namespace ProjetIncident.Core
{
    public class NavigationService
    {
        #region Singleton

        private static NavigationService _currentService = null;
        public static NavigationService GetCurrent()
        {
            if (_currentService == null)
            {
                _currentService = new NavigationService();
            }

            return _currentService;
        }

        #endregion

        private Page _menuPage;
        private NavigationPage _navigationPage;
        protected NavigationPage NavigationPage
        {
            get { return _navigationPage; }
            private set
            {
                if (value != _navigationPage)
                {
                    _navigationPage = value;
                    RootPage.Detail = _navigationPage;
                }
            }
        }
        public MasterDetailPage RootPage { get; }

        public bool MenuIsPresented
        {
            get { return RootPage?.IsPresented ?? false; }
            set { if (RootPage != null) RootPage.IsPresented = value; }
        }

        private NavigationService()
        {
            RootPage = new MasterDetailPage()
            {
                MasterBehavior = MasterBehavior.Popover,
                //Title = "GraphismExamples"
            };

            _menuPage = new MainMenuPage();
            _menuPage.BindingContext = new MainMenuViewModel();
            RootPage.Master = _menuPage;

            _navigationPage = new NavigationPage(new HomePage());
            _navigationPage.BindingContext = new HomeViewModel();
            RootPage.Detail = NavigationPage;
        }


        public async Task NavigateToRootPage()
        {
            await _navigationPage.PopToRootAsync();
        }
        public void NavigateToWithoutPush(Page page, object viewModel = null)
        {
            if (viewModel != null) page.BindingContext = viewModel;
            NavigationPage = new NavigationPage(page);
            MenuIsPresented = false;
        }
        public async Task NavigateToWithPush(Page page, object viewModel = null)
        {
            if (viewModel != null) page.BindingContext = viewModel;
            await NavigationPage.Navigation.PushAsync(page);
        }

    }
}
