using System;

namespace delegateLamdasActionTFuncT
{
    class Program
    {
        static void Main(string[] args)
        {
            MathServices mathserv = new MathServices();
            mathserv.MathPerformed += OnMathPerformed;

            // actual do something
            mathserv.MultiplyNumbers(1.22, 3.44);
        }

        static void OnMathPerformed(object sender, MathPerformanceEventArgs e) {
            Console.WriteLine("Calc result: " + e.Result);
           
        }
    }
}
