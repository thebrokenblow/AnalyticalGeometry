namespace AnalyticalGeometry.ViewModel.Pages;

public class CircleAndPointVM : BasePageViewModel
{
    private double convertedXCoordinateCircle;
    public double ConvertedXCoordinateCircle 
    {
        get => convertedXCoordinateCircle;
        set
        {
            convertedXCoordinateCircle = value;
            OnPropertyChanged();
        }
    }

    private double convertedYCoordinateCircle;
    public double ConvertedYCoordinateCircle
    {
        get => convertedYCoordinateCircle;
        set
        {
            convertedYCoordinateCircle = value;
            OnPropertyChanged();
        }
    }

    private double xCoordinateCircle;
    public double XCoordinateCircle
    {
        get => xCoordinateCircle;
        set
        {
            xCoordinateCircle = value;
            ConvertedXCoordinateCircle = xCoordinateCircle - (diameter / 2);
            OnPropertyChanged();
        }
    }

    private double yCoordinateCircle;
    public double YCoordinateCircle
    {
        get => yCoordinateCircle;
        set
        {
            yCoordinateCircle = value;
            ConvertedYCoordinateCircle = yCoordinateCircle - diameter / 2;
            OnPropertyChanged();
        }
    }

    private double diameter;
    public double Diameter
    {
        get => diameter;
        set
        {
            diameter = value;
            OnPropertyChanged();
        }
    }

    private double xCoordinatePoint;
    public double XCoordinatePoint 
    {
        get => xCoordinatePoint;
        set
        {
            xCoordinatePoint = value;
            OnPropertyChanged();
        }
    }

    private double yCoordinatePoint;
    public double YCoordinatePoint 
    {
        get => yCoordinatePoint;
        set
        {
            yCoordinatePoint = value;
            OnPropertyChanged();
        }
    }
}