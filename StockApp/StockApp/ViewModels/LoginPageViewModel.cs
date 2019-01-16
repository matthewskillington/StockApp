using System;
using System.Windows.Input;
using Xamarin.Forms;
using StockApp.Services;

namespace StockApp.ViewModels
{
    public class LoginPageViewModel
    {
        public INavigationService _navigationService;

        public LoginPageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
        }

        public ICommand LoginCommand => new Command(OnLogin);

        private void OnLogin()
        {
            _navigationService.NavigateToAsync<MainPageViewModel>();
        }
    }
}
