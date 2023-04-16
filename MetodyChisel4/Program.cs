using MetodyChisel4;

public class Program
{
    
    private static int a = 1;
    private static int b = 3;
    private static readonly Func<double, double> f = (double x) => Math.Pow(x, 3) * Math.Cos(x * x + 1);

    public static void Main(string[] args)
    {
        var h = 0.1;
        PrintResult(h, MethodManager.Methods[Method.LFA].GetValue(f, a, b, h), 
            MethodManager.Methods[Method.LFA].GetError(
                MethodManager.Methods[Method.LFA].GetValue(f, a, b, h),
                MethodManager.Methods[Method.LFA].GetValue(f, a, b, 2*h)));

        PrintResult2(h, MethodManager.Methods[Method.SF].GetValue(f, a, b, h),
            MethodManager.Methods[Method.SF].GetError(
                MethodManager.Methods[Method.SF].GetValue(f, a, b, h),
                MethodManager.Methods[Method.SF].GetValue(f, a, b, 2 * h)));
        h = 0.05;
        PrintResult(h, MethodManager.Methods[Method.LFA].GetValue(f, a, b, h), 
            MethodManager.Methods[Method.LFA].GetError(
                MethodManager.Methods[Method.LFA].GetValue(f, a, b, h),
                MethodManager.Methods[Method.LFA].GetValue(f, a, b, 2*h)));

        PrintResult2(h, MethodManager.Methods[Method.SF].GetValue(f, a, b, h),
            MethodManager.Methods[Method.SF].GetError(
                MethodManager.Methods[Method.SF].GetValue(f, a, b, h),
                MethodManager.Methods[Method.SF].GetValue(f, a, b, 2 * h)));
        
        h = 0.025;
        PrintResult(h, MethodManager.Methods[Method.LFA].GetValue(f, a, b, h), 
            MethodManager.Methods[Method.LFA].GetError(
                MethodManager.Methods[Method.LFA].GetValue(f, a, b, h),
                MethodManager.Methods[Method.LFA].GetValue(f, a, b, 2*h)));
        
        PrintResult2(h, MethodManager.Methods[Method.SF].GetValue(f, a, b, h),
            MethodManager.Methods[Method.SF].GetError(
                MethodManager.Methods[Method.SF].GetValue(f, a, b, h),
                MethodManager.Methods[Method.SF].GetValue(f, a, b, 2 * h)));
        
        
        
    }

    private static void PrintResult(double h, double result, double error)
    {
        Console.WriteLine($"Метод левых прямоугольников с шагом {h}: {result}, с погрешностью: {error}");
    }
    
    private static void PrintResult2(double h, double result, double error)
    {
        Console.WriteLine($"Метод Симпсона с шагом {h}: {result}, с погрешностью: {error}");
    }
}