﻿namespace AppsLab_007_Casting;

/// <summary>
/// This class contains methods to convert between different data types.
/// </summary>
public class Converter
{
    /// <summary>
    /// This method converts a string to an integer.
    /// </summary>
    public double IntToDouble(int number)
    {
        double result;
        result = (double)number;
        return result;
    }

    /// <summary>
    /// This method converts a double to an integer.
    /// </summary>
    public int DoubleToInt(double number)
    {
        int result;
        result = (int)number;
        return result;
    }

    /// <summary>
    /// This method converts a string to a double.
    /// </summary>
    public double StringToDouble(string number)
    {
        double result;
        result = Double.Parse(number);
        return result;

    }

    /// <summary>
    /// This method converts a double to a string.
    /// </summary>
    public string DoubleToString(double number)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// This method converts a string to a boolean.
    /// </summary>
    public string IntToString(int number)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// This method converts a boolean to a string.
    /// </summary>
    public bool StringToBool(string boolValue)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// This method converts a boolean to a string.
    /// </summary>
    public string BoolToString(bool boolValue)
    {
        throw new NotImplementedException();
    }
}

