using AnalyticalGeometry.ViewModel.Core;
using AnalyticalGeometry.ViewModel.Pages;

namespace AnalyticalGeometry.ViewModel.Service;

public class NavigationService(Func<Type, BasePageViewModel> factoryPageViewModel) : ObservableObject, INavigationService
{
    private BasePageViewModel? basePageViewModel;
    public BasePageViewModel? BasePageViewModel
    {
        get => basePageViewModel;
        private set
        {
            basePageViewModel = value;
            OnPropertyChanged();
        }
    }

    public void NavigateTo<T>() where T : BasePageViewModel
    {
        if (BasePageViewModel is not T)
        {
            BasePageViewModel = factoryPageViewModel.Invoke(typeof(T));
        }
    }
}
