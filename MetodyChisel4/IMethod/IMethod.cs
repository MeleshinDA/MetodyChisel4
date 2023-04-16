namespace MetodyChisel4;

public interface IMethod
{
    public double GetValue(Func<double, double> f, double a, double b, double h);
    public double GetError(double f1, double f2);
}