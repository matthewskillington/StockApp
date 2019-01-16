using System;
using System.Threading.Tasks;
namespace StockApp.Services
{
    public interface INavigationService
    {
        void InitializeAsync();
        void NavigateToAsync<TViewModel>();
    }
}
