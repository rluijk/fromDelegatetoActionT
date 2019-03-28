using System;

namespace delegateLamdasActionTFuncT
{
    class Program
    {
        static void Main(string[] args)
        {
            MathServices mathserv = new MathServices();
            mathserv.MathPerformed += (result) =>
            {
                Console.WriteLine("Calc result: " + result);
            };
            
            // actual do something
            mathserv.MultiplyNumbers(1.22, 3.44);
            int i = 0;

        }


    }
}