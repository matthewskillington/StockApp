using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using StockApp.ViewModels;
using StockApp.Views;
using Xamarin.Forms;

namespace StockApp.Services
{
    public class NavigationService : INavigationService
    {
        protected Application CurrentApplication => Application.Current;

        private readonly Dictionary<Type, Type> _mappings;

        public NavigationService()
        {
            _mappings = new Dictionary<Type, Type>();
            CreatePageViewModelMappings();
        }

        public void InitializeAsync()
        {   
            NavigateToAsync<LoginPageViewModel>();
        }

        public void NavigateToAsync<TViewModel>()
        {
            var page = CreatePage(typeof(TViewModel));

            CurrentApplication.MainPage = (Xamarin.Forms.Page)page;
        }

        private object CreatePage(Type viewModelType)
        {
            Type pageType = GetPageTypeForViewModel(viewModelType);

            if (pageType == null)
            {
                throw new Exception($"Mapping type for {viewModelType} is not a page");
            }

            Page page = Activator.CreateInstance(pageType) as Page;
            return page;
        }

        private Type GetPageTypeForViewModel(Type viewModelType)
        {
            if (!_mappings.ContainsKey(viewModelType))
            {
                throw new KeyNotFoundException($"No map found ${viewModelType} was found on navigation mappings");
            }
            return _mappings[viewModelType];
        }

        private void CreatePageViewModelMappings()
        {
            _mappings.Add(typeof(LoginPageViewModel), typeof(LoginPage));
            _mappings.Add(typeof(MainPageViewModel), typeof(MainPage));
        }
    }
}

