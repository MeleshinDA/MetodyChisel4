namespace MetodyChisel4;

public static class MethodManager
{
    public static readonly Dictionary<Method, IMethod> Methods = new()
    {
        [Method.LFA] = new LFA(),
        [Method.SF] = new SF()
    };
}