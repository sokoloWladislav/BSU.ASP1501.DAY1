using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class Solver
    {
        public double MethodNewton(double num, double power, double fault)
        {
            double result = (power - 1 + num) / power;

            if (power == 0)
                result = 1;

            else if (num < 0 && power % 2 == 0)
                result = Double.NaN;

            else if (num == 0)
                result = 0;

            else
            {
                while (Math.Abs(RaiseInPower(result, power) - num) >= fault)
                    result = ((power - 1) * result + num / RaiseInPower(result, power - 1)) / power;
            }
            return result;
        }

        private double RaiseInPower(double num, double power)
        {
            double result = num;
            for (int i = 0; i < power - 1; ++i)
                result *= num;
            return result;
        }
    }
}
