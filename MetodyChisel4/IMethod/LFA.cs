namespace MetodyChisel4;

public class LFA : IMethod
{
    public double GetValue(Func<double, double> f, double a, double b, double h)
    {
        var res = 0d;
        for (var cur = a; cur < b-0.001; cur += h) //0.001 потому что double плохие :(
            res += f(cur);
         
        return h * res;
    }

    public double GetError(double f1, double f2) => Math.Abs(f2 - f1);
}