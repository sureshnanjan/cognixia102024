using System;

public static class StringExtensions
{
    // Extension method for string to return a string with first and last characters hyphenated
    public static string FirstAndLastHyphenated(this string input)
    {
        if (input.Length > 1)
        {
            return $"{input[0]}-{input[input.Length - 1]}";
        }
        throw new ArgumentException("String must have more than one character.");
    }
}

public class CustomClass
{
    public string Value { get; set; }

    public CustomClass(string value)
    {
        Value = value;
    }
}

public static class CustomClassExtensions
{
    // Extension method for CustomClass
    public static string FirstAndLastHyphenated(this CustomClass customClass)
    {
        if (customClass.Value.Length > 1)
        {
            return $"{customClass.Value[0]}-{customClass.Value[customClass.Value.Length - 1]}";
        }
        throw new ArgumentException("Value in CustomClass must have more than one character.");
    }
}
