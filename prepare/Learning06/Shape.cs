public class Shape
{
    private string _color;

    public Shape(string color)
    {
        SetColor(color);
    }
    public void SetColor(string color)
    {
        _color=color;
    }
    public string GetColor()
    {
        return _color;
    }
    public virtual double GetArea()
    {
        double area=0.00;
        return area;
    }
}