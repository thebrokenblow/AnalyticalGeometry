using AnalyticalGeometry.ViewModel.Core;
using AnalyticalGeometry.ViewModel.Pages;
using AnalyticalGeometry.ViewModel.Service;

namespace AnalyticalGeometry.ViewModel.Windows;

public class MainWindowViewModel
{
    public INavigationService NavigationService { get; }

    public RelayCommand NavigateToCircleAndPointCommand { get; set; }
    public RelayCommand NavigateToTriangleAndPointCommand { get; set; }

    public MainWindowViewModel(INavigationService navigationService)
    {
        NavigationService = navigationService;

        NavigateToCircleAndPointCommand = new(x => navigationService.NavigateTo<CircleAndPointVM>());
        NavigateToTriangleAndPointCommand = new(x => navigationService.NavigateTo<TriangleAndPoint>());

        NavigateToCircleAndPointCommand.Execute();
    }
}