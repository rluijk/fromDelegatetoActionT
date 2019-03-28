
using System;
using System.Collections.Generic;
using System.Text;
using System.Timers;

namespace delegateLamdasActionTFuncT
{
    class MathServices
    {
        public delegate void MathPerformedHandler(double result);
        //public EventHandler<MathPerformanceEventArgs> MathPerformed;

        public event MathPerformedHandler MathPerformed;

        public void MultiplyNumbers(double value1, double value2)
        {
            Timer timer = new Timer(5000);
            //MathPerformed(this, new MathPerformanceEventArgs { Result = value1 * value2});
            MathPerformed(value1 * value1);
        }
    }
}
