namespace AnalyticalGeometry.ViewModel.Core;

public class Coordinate2D : ObservableObject
{
    private double x;
    public double X 
    {
        get => x;
        set
        {
            x = value;
            OnPropertyChanged();
        }
    }

    private double y;
    public double Y
    {
        get => y;
        set
        {
            y = value;
            OnPropertyChanged();
        }
    }
}