using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public delegate bool Key(double[] array, double[] brray);
    public static class SortClass
    {
        private static List<Key> keys;
        static SortClass()
        {
            keys = new List<Key>();
            keys.Add(KeySumIncr);
            keys.Add(KeySumDecr);
            keys.Add(KeyMaxIncr);
            keys.Add(KeyMaxDecr);
            keys.Add(KeyMinIncr);
            keys.Add(KeyMinDecr);
        }

        public static void Sort(double[][] array, Key key)
        {

            for (int i = 0; i < array.Length - 1; ++i)
                for (int j = 0; j < array.Length - i - 1; ++j)
                {
                    if (key(array[j], array[j + 1]))
                        Swap(ref array[j], ref array[j + 1]);
                }
        }

        public static void SortBySumIncr(double[][] array)
        {
            Sort(array, keys[0]);
        }

        public static void SortBySumDecr(double[][] array)
        {
            Sort(array, keys[1]);
        }

        public static void SortByMaxIncr(double[][] array)
        {
            Sort(array, keys[2]);
        }

        public static void SortByMaxDecr(double[][] array)
        {
            Sort(array, keys[3]);
        }

        public static void SortByMinIncr(double[][] array)
        {
            Sort(array, keys[4]);
        }

        public static void SortByMinDecr(double[][] array)
        {
            Sort(array, keys[5]);
        }

        #region Keys
        private static bool KeySumIncr(double[] array, double[] brray)
        {
            double a = FindSum(array);
            double b = FindSum(brray);
            return a > b;
        }

        private static bool KeySumDecr(double[] array, double[] brray)
        {
            double a = FindSum(array);
            double b = FindSum(brray);
            return a < b;
        }

        private static bool KeyMaxIncr(double[] array, double[] brray)
        {
            double a = FindMax(array);
            double b = FindMax(brray);
            return a > b;
        }

        private static bool KeyMaxDecr(double[] array, double[] brray)
        {
            double a = FindMax(array);
            double b = FindMax(brray);
            return a < b;
        }

        private static bool KeyMinIncr(double[] array, double[] brray)
        {
            double a = FindMin(array);
            double b = FindMin(brray);
            return a > b;
        }

        private static bool KeyMinDecr(double[] array, double[] brray)
        {
            double a = FindMin(array);
            double b = FindMin(brray);
            return a < b;
        } 
        #endregion

        #region Private methods
        private static double FindSum(double[] array)
        {
            double sum = 0;
            foreach (double elem in array)
                sum += elem;
            return sum;
        }

        private static double FindMax(double[] array)
        {
            double a = array[0];
            for (int i = 1; i < array.Length; ++i)
                if (array[i] > a)
                    a = array[i];
            return a;
        }

        private static double FindMin(double[] array)
        {
            double a = array[0];
            for (int i = 1; i < array.Length; ++i)
                if (array[i] < a)
                    a = array[i];
            return a;
        }

        private static void Swap(ref double[] a, ref double[] b)
        {
            double[] temp = a;
            a = b;
            b = temp;
        } 
        #endregion
    }
}
