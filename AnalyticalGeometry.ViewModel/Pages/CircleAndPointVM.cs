using AnalyticalGeometry.Model;
using AnalyticalGeometry.Model.Core;
using AnalyticalGeometry.ViewModel.Core;

namespace AnalyticalGeometry.ViewModel.Pages;

public class CircleAndPointVM : BasePageViewModel
{
    private const int diameterPoint = 5;
    public static int DiameterPoint => diameterPoint;
    public Coordinate2D ConvertedCoordinateCircle { get; set; } = new();
    public Coordinate2D ConvertedCoordinatePoint { get; set; } = new();

    private double xCoordinateCircle;
    public double XCoordinateCircle
    {
        get => xCoordinateCircle;
        set
        {
            xCoordinateCircle = value;
            SetXCoordinateCircle();
        }
    }

    private double yCoordinateCircle;
    public double YCoordinateCircle
    {
        get => yCoordinateCircle;
        set
        {
            yCoordinateCircle = value;
            SetYCoordinateCircle();
        }
    }

    private double xCoordinatePoint;
    public double XCoordinatePoint 
    {
        get => xCoordinatePoint;
        set
        {
            xCoordinatePoint = value;

            SetXCoordinatePoint();
        }
    }

    private double yCoordinatePoint;
    public double YCoordinatePoint 
    {
        get => yCoordinatePoint;
        set
        {
            yCoordinatePoint = value;

            SetYCoordinatePoint();
        }
    }

    private const int defaultDiameterCircle = 50;

    private double diameterCircle = defaultDiameterCircle;
    public double DiameterCircle
    {
        get => diameterCircle;
        set
        {
            diameterCircle = value;

            SetXCoordinateCircle();
            SetYCoordinateCircle();

            OnPropertyChanged();
        }
    }

    private double actualWidth;
    public double ActualWidth 
    {
        get => actualWidth;
        set
        {
            actualWidth = value;

            SetXCoordinateCircle();
            SetXCoordinatePoint();
        }
    }

    private double actualHeight;
    public double ActualHeight 
    {
        get => actualHeight;
        set
        {
            actualHeight = value;

            SetYCoordinateCircle();
            SetYCoordinatePoint();
        }
    }

    public bool isIncluded;
    public bool IsIncluded
    {
        get => isIncluded;
        set
        {
            isIncluded = value;

            SerResponseMessage();
        }
    }

    private string includedResponse = string.Empty;
    public string IncludedResponse
    {
        get => includedResponse;
        set
        {
            includedResponse = value;
            OnPropertyChanged();
        }
    }

    public CircleAndPointVM()
    {
        XCoordinateCircle = 0;
        YCoordinateCircle = 0;

        XCoordinatePoint = 0;
        YCoordinatePoint = 0;
    }

    private void SetXCoordinateCircle()
    {
        ConvertedCoordinateCircle.X = xCoordinateCircle - diameterCircle / 2 + actualWidth / 2;
        IsIncluded = CheckIncluded();
    }

    private void SetYCoordinateCircle()
    {
        ConvertedCoordinateCircle.Y = yCoordinateCircle - diameterCircle / 2 + actualHeight / 2;
        IsIncluded = CheckIncluded();
    }

    private void SetXCoordinatePoint()
    {
        ConvertedCoordinatePoint.X = xCoordinatePoint - diameterPoint / 2 + actualWidth / 2;
        IsIncluded = CheckIncluded();
    }

    private void SetYCoordinatePoint()
    {
        ConvertedCoordinatePoint.Y = yCoordinatePoint - diameterPoint / 2 + actualHeight / 2;
        IsIncluded = CheckIncluded();
    }

    private bool CheckIncluded()
    {
        var coordinatePointModel = new Point2D
        {
            X = xCoordinatePoint,
            Y = yCoordinatePoint
        };

        var coordinateCircleModel = new Point2D
        {
            X = xCoordinateCircle,
            Y = yCoordinateCircle
        };

        var radius = diameterCircle / 2;

        var circleAndPointModel = new CircleAndPointModel(coordinateCircleModel, coordinatePointModel, radius);

        return circleAndPointModel.IsIncluded();
    }

    private void SerResponseMessage()
    {
        if (isIncluded)
        {
            IncludedResponse = "Точка входит в окружность";
        }
        else
        {
            IncludedResponse = "Точка не входит в окружность";
        }
    }
}