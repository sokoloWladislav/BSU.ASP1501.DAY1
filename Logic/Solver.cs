using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class Solver
    {
        #region Newton's Method
        public static double MethodNewton(double num, double power, double fault)
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

        public static int EuclideMethod(int a, int b)
        {
            GetAbs(ref a, ref b);
            CheckOnOrder(ref a, ref b);
            int result = a;
            if (b != 0)
            {
                if (a % b == 0)
                {
                    result = Math.Abs(b);
                }
                else
                    result = EuclideMethod(b, a % b);
            }
            return result;
        } 
        #endregion

        #region Euclide's Method
        public static int EuclideMethod(out long time, int a, int b)
        {
            var stopWatch = new System.Diagnostics.Stopwatch();
            stopWatch.Start();
            int result = EuclideMethod(a, b);
            stopWatch.Stop();
            time = stopWatch.Elapsed.Ticks;
            return result;
        }

        public static int EuclideMethod(int a, int b, int c)
        {
            int result = EuclideMethod(a, b);
            result = EuclideMethod(result, c);
            return result;
        }

        public static int EuclideMethod(out long time, int a, int b, int c)
        {
            var stopWatch = new System.Diagnostics.Stopwatch();
            stopWatch.Start();
            int result = EuclideMethod(a, b, c);
            stopWatch.Stop();
            time = stopWatch.Elapsed.Ticks;
            return result;
        }

        public static int EuclideMethod(params int[] data)
        {
            int result = data[0];
            for (int i = 1; i < data.Length; ++i)
                result = EuclideMethod(data[i], result);
            return result;
        }

        public static int EuclideMethod(out long time, params int[] data)
        {
            var stopWatch = new System.Diagnostics.Stopwatch();
            int result = data[0];
            for (int i = 1; i < data.Length; ++i)
            {
                stopWatch.Start();
                result = EuclideMethod(data[i], result);
                stopWatch.Stop();
            }
            time = stopWatch.Elapsed.Ticks;
            return result;
        } 
        #endregion

        #region Sten's Method
        public static int SteinMethod(int a, int b)
        {
            GetAbs(ref a, ref b);
            CheckOnOrder(ref a, ref b);
            int result = a;
            if (a != b && b != 1 && b != 0)
            {
                if (a % 2 == 0 && b % 2 == 0)
                    result = 2 * SteinMethod(a / 2, b / 2);
                if (a % 2 == 0 && b % 2 == 1)
                    result = SteinMethod(a / 2, b);
                if (a % 2 == 1 && b % 2 == 0)
                    result = SteinMethod(a, b / 2);
                if (a % 2 == 1 && b % 2 == 1)
                    result = SteinMethod((a - b) / 2, b);
            }
            if (b == 1)
                result = 1;
            return result;
        }

        public static int SteinMethod(out long time, int a, int b)
        {
            var stopWatch = new System.Diagnostics.Stopwatch();
            stopWatch.Start();
            int result = SteinMethod(a, b);
            stopWatch.Stop();
            time = stopWatch.Elapsed.Ticks;
            return result;
        }

        public static int SteinMethod(int a, int b, int c)
        {
            int result = SteinMethod(a, b);
            result = SteinMethod(result, c);
            return result;
        }

        public static int SteinMethod(out long time, int a, int b, int c)
        {

            var stopWatch = new System.Diagnostics.Stopwatch();
            stopWatch.Start();
            int result = SteinMethod(a, b, c);
            stopWatch.Stop();
            time = stopWatch.Elapsed.Ticks;
            return result;
        }


        public static int SteinMethod(params int[] data)
        {
            int result = data[0];
            for (int i = 1; i < data.Length; ++i)
                result = EuclideMethod(data[i], result);
            return result;
        }

        public static int SteinMethod(out long time, params int[] data)
        {
            var stopWatch = new System.Diagnostics.Stopwatch();
            int result = data[0];
            for (int i = 1; i < data.Length; ++i)
            {
                stopWatch.Start();
                result = EuclideMethod(data[i], result);
                stopWatch.Stop();
            }
            time = stopWatch.Elapsed.Ticks;
            return result;
        }
        #endregion

        #region Private Methods
        private static double RaiseInPower(double num, double power)
        {
            double result = num;
            for (int i = 0; i < power - 1; ++i)
                result *= num;
            return result;
        }

        private static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        private static void CheckOnOrder(ref int a, ref int b)
        {
            if (a < b)
                Swap(ref a, ref b);
        }

        private static void GetAbs(ref int a, ref int b)
        {
            a = Math.Abs(a);
            b = Math.Abs(b);
        }
        #endregion

    }
}
