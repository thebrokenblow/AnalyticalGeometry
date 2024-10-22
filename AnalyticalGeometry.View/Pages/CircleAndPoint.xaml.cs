using System.Windows;
using System.Windows.Controls;
using AnalyticalGeometry.ViewModel.Pages;

namespace AnalyticalGeometry.View.Pages;

/// <summary>
/// Логика взаимодействия для CircleAndPoint.xaml
/// </summary>
public partial class CircleAndPoint : UserControl
{
    private CircleAndPointVM? circleAndPointVM;
    public CircleAndPoint()
    {
        InitializeComponent();
    }

    private void Canvas_SizeChanged(object sender, SizeChangedEventArgs e)
    {
        circleAndPointVM ??= (CircleAndPointVM)DataContext;

        circleAndPointVM.ActualWidth = gridCartesianCoordinateSystem.ActualWidth;
        circleAndPointVM.ActualHeight = gridCartesianCoordinateSystem.ActualHeight;
    }
}