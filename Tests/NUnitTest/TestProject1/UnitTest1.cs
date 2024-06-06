using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Operations
{
    public int Add(int a, int b)
    {
        return a + b;
    }
    public int Multiply(int a, int b)
    {
        return a * b;
    }
    public int Divide(int a, int b)
    {
        return a / b;
    }
    public int Mod(int a, int b)
    {
        return a % b;
    }
    public int Exponent(int a, int b)
    {
        int res = (int)Math.Pow(a, b);
        return res;
    }
    public int Subt(int a, int b)
    {
        return a - b;
    }
}
