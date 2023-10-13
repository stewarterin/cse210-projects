using System;
using System.Dynamic;

// Create the Fraction class.

public class Fraction
{
    // Define attributes.
    private int _top;
    private int _bottom;

    // Create constructors.
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }
    
    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }
    
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    // Create getters.
    public int GetTop()
    {
        return _top;
    }

    public int GetBottom()
    {
        return _bottom;
    }

    // Create setters.
    public void SetTop(int top)
    {
        _top = top;
    }

    public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }

    // Create methods.
    public string GetFractionString()
    {
        string fractionString = $"{_top}/{_bottom}";
        return fractionString;
    }

    public double GetDecimalValue()
    {
        return (double)_top / (double)_bottom;
    }
}