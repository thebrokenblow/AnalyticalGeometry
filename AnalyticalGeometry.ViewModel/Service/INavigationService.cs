using AnalyticalGeometry.ViewModel.Pages;

namespace AnalyticalGeometry.ViewModel.Service;

public interface INavigationService
{
    BasePageViewModel? BasePageViewModel { get; }
    void NavigateTo<T>() where T : BasePageViewModel;
}