namespace Todos.App.Extensions;

public static class ConversionExtensions
{
    public static bool ToBool(this object? value)
    {
        return value is not null && (bool)value;
    }
}
