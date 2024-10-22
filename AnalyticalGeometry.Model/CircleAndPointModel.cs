using AnalyticalGeometry.Model.Core;

namespace AnalyticalGeometry.Model;

public class CircleAndPointModel(Point2D coordinateCircle, Point2D coordinatePoint, double radius)
{
    public bool IsIncluded() =>
        Math.Pow(coordinatePoint.X - coordinateCircle.X, 2) + Math.Pow(coordinatePoint.Y - coordinateCircle.Y, 2) < (radius * radius);
}