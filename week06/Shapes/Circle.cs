public class Circle : Shape
{
    private double _radius;

    public Circle(string color, double radius) : base (color)
    {
        _radius = radius;
    }

    public override double GetArea()
    {
        // formula: pi * radius^2
        //double pi = Math.PI;
        //double diameter = Math.Pow(_radius, 2);
        //return diameter * pi;

        // or simply
        return _radius * _radius * Math.PI;
    }
}