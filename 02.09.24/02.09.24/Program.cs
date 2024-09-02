internal class Program
{
    private static void Main(string[] args)
    {
        int i = 0;
        double d = 0;
        float f = 0;
        CustomConverter.Convert("2", out i);
        Console.WriteLine(i);
        CustomConverter.Convert("2,2", out d);
        Console.WriteLine(d);
        CustomConverter.Convert("2,2", out f);
        Console.WriteLine(f);
    }
}

internal static class CustomConverter
{
    public static void Convert(string par, out int a)
    {
        a = System.Convert.ToInt32(par);
    }
    public static void Convert(string par, out double a)
    {
        a = System.Convert.ToDouble(par);
    }
    public static void Convert(string par, out float a)
    {
        a = System.Convert.ToSingle(par);
    }
}