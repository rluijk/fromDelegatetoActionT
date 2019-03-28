
using System;
using System.Collections.Generic;
using System.Text;
using System.Timers;

namespace delegateLamdasActionTFuncT
{
    class MathServices
    {
        public delegate void MathPerformedHandler(double result);
        public delegate double CalculationHandler(double value1, double value2);
        

        public event MathPerformedHandler MathPerformed;

        public void CalculateNumbers(double value1, double value2, CalculationHandler calc)
        {
            Timer timer = new Timer(5000);
            MathPerformed(calc(value1, value2));
           
        }
    }  
}
