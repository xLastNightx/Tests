using System;
public static class Kata
{
    public static int Add(int a, int b)
    {
        return a + b;
    }
    public static int Multiply(int a, int b)
    {
        return a * b;
    }
    public static int Divide(int a, int b)
    {
        return a / b;
    }
    public static int Mod(int a, int b)
    {
        return a % b;
    }
    public static int Exponent(int a, int b)
    {
        int res = (int)Math.Pow(a, b);
        return res;
    }
    public static int Subt(int a, int b)
    {
        return a - b;
    }
}