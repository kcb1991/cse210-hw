using System.Reflection.Metadata.Ecma335;

public class Fraction
{
    private int _topNumber;
    private int _bottomNumber;

    public Fraction()
    {
        _topNumber = 1;
        _bottomNumber = 1;
    }

    public Fraction(int number)
    {
        _topNumber = number;
        _bottomNumber = 1;
    }

    public Fraction(int top, int bottom)
    {
        _topNumber = top;
        _bottomNumber = bottom;
    }

    public int GetTop()
    {
        return _topNumber;
    }
    public void SetTop(int value)
    {
        _topNumber = value;
    }
    public int GetBottom()
    {
        return _bottomNumber;
    }
    public void SetBottom(int value)
    {
        _bottomNumber = value;
    }

    public string GetFractionString()
    {
        string text = $"{_topNumber}/{_bottomNumber}";
        return text;
    }
    public double GetDecimal()
    {
        return (double)_topNumber / _bottomNumber;
    }
}