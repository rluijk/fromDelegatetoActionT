using System;

namespace delegateLamdasActionTFuncT
{
    class Program
    {
        static void Main(string[] args)
        {
            MathServices mathserv = new MathServices();
            mathserv.MathPerformed +=  ( sender,  e) => {
                Console.WriteLine("Calc result: " + e.Result);
            };

            // actual do something
            mathserv.MultiplyNumbers(1.22, 3.44);
            int i = 0;

        }


    }
}