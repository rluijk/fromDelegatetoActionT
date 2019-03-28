using System;

namespace delegateLamdasActionTFuncT
{
    class Program
    {
        static void Main(string[] args)
        {
            MathServices mathserv = new MathServices();
            mathserv.MathPerformed += (result) =>
                 Console.WriteLine("Calc result: " + result);
            
            // actual do something
            mathserv.CalculateNumbers(1.22, 3.44,   (value1,value2) => value1 * value2);
            int i = 0;

        }


    }
}