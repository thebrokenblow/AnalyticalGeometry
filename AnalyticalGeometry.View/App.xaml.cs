using System.Windows;
using AnalyticalGeometry.ViewModel.Pages;
using AnalyticalGeometry.ViewModel.Service;
using AnalyticalGeometry.ViewModel.Windows;
using Microsoft.Extensions.DependencyInjection;

namespace AnalyticalGeometry.View;

/// <summary>
/// Interaction logic for App.xaml
/// </summary>
public partial class App : Application
{
    private readonly ServiceProvider serviceProvider;

    public App()
    {
        IServiceCollection services = new ServiceCollection();

        services.AddSingleton(provider => new MainWindow
        {
            DataContext = provider.GetService<MainWindowViewModel>()
        });

        services.AddSingleton<CircleAndPointVM>();
        services.AddSingleton<TriangleAndPoint>();

        services.AddSingleton<MainWindowViewModel>();

        services.AddSingleton<INavigationService, NavigationService>();

        services.AddSingleton<Func<Type, BasePageViewModel>>(
            serviceProvider =>
            viewModel =>
            (BasePageViewModel)serviceProvider.GetRequiredService(viewModel));

        serviceProvider = services.BuildServiceProvider();
    }

    protected override void OnStartup(StartupEventArgs e)
    {
        var mainWindow = serviceProvider.GetRequiredService<MainWindow>();
        mainWindow.Show();
        base.OnStartup(e);
    }
}