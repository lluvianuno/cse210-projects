using System.Formats.Asn1;
using System.Reflection.Metadata.Ecma335;

class Shape
{
    protected string _color;

    public Shape(string color)
    {
        _color = color;
    }

    public string GetColor()
    {
        return _color;
    }

    public void SetColor(string color)
    {
        _color = color;
    }
    
    public virtual double GetArea()
    {
        return 0;
    }
}