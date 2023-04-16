namespace MetodyChisel4;

public class SF : IMethod
{
    public double GetValue(Func<double, double> f, double a, double b, double h)
    {
        var res = 0d;
        for (var cur = a; cur < b-0.001; cur += 2 * h)
            res += f(cur) + 4 * f(cur + h) + f(cur + h + h);
        
        return h / 3 * res;
    }

    public double GetError(double f1, double f2) => Math.Abs((f2 - f1) / 15.0);
}